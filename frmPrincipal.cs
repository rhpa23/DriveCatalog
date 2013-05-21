using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Xml;

namespace DriveCatalog
{
    public partial class frmPrincipal : Form
    {
        private bool cancelar;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dirListBox1.Path = driveListBox1.Drive;
                dirListBox1.Update();

                fileListBox1.Path = dirListBox1.get_DirList(dirListBox1.DirListIndex);
                fileListBox1.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível fazer a leitura do Drive.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path = dirListBox1.get_DirList(dirListBox1.DirListIndex);
            fileListBox1.Update();
        }

        private void btCatalog_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIndentificador.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("O campo 'Identificador' é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.btCancelar.Enabled = true;
                    string path = dirListBox1.get_DirList(dirListBox1.DirListIndex);
                    if (path.ToLower() != "c:\\")
                    {
                        Dictionary<string, string> listaDirArquivo = RecuperaArquivos(path);
                        if (listaDirArquivo.Count > 0)
                        {
                            GerarDados(listaDirArquivo);
                        }
                    }
                    else
                    {
                        DialogResult dResult = MessageBox.Show("Catalogar o drive 'c:' pode demorar horas. Deseja realmente continuar?",
                            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dResult == DialogResult.Yes)
                        {
                            Dictionary<string, string> listaDirArquivo = RecuperaArquivos(path);
                            if (listaDirArquivo.Count > 0)
                            {
                                GerarDados(listaDirArquivo);    
                            }
                        }
                    }
                }
            }
            finally
            {
                this.btCancelar.Enabled = false;
            }
        }

        private void GerarDados(Dictionary<string, string> listaDirArquivo)
        {
            try
            {
                if (File.Exists(txtIndentificador.Text + ".xml"))
                {
                    DialogResult dResult = MessageBox.Show("O catálogo '" 
                        + txtIndentificador.Text 
                        + "' já existe! Deseja substituir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dResult != DialogResult.Yes)
                    {
                        return;
                    }
                }

                DriveData driveData = new DriveData();
                driveData.Identificador = txtIndentificador.Text;
                driveData.Data = dtpData.Value.ToShortDateString();
                driveData.TipoArquivos = cbTipoArquivos.Text;
                driveData.File = new List<ChaveValorSer<string, string>>();
                progressBar1.Value = 0;
                progressBar1.Maximum = listaDirArquivo.Count;

                foreach (KeyValuePair<string, string> dirArquivo in listaDirArquivo)
                {
                    if (cancelar)
                    {
                        cancelar = false;
                        return;
                    }
                    else
                    {
                        progressBar1.Value += 1;
                        ChaveValorSer<string, string> info = new ChaveValorSer<string, string>();
                        info.Size = dirArquivo.Value;
                        info.File = dirArquivo.Key;
                        driveData.File.Add(info);
                    }
                    Application.DoEvents();
                }

                XmlSerializer writer = new XmlSerializer(driveData.GetType());
                StreamWriter file = new StreamWriter(driveData.Identificador + ".xml", false);
                writer.Serialize(file, driveData);
                file.Close();
                file.Dispose();
                MessageBox.Show("Arquivo de catálogo gerado com sucesso.", 
                    "Catálogo gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao gerar arquivo de catálogo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                progressBar1.Value = 0;
            }
        }

        private Dictionary<string, string> RecuperaArquivos(string path)
        {
            Dictionary<string, string> listaDirArquivo = new Dictionary<string, string>();
            try
            {
                //Marca o diretório a ser listado
                DirectoryInfo diretorio = new DirectoryInfo(path);
                //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
                FileInfo[] Arquivos = diretorio.GetFiles(cbExtensao.Text, SearchOption.AllDirectories);

                progressBar1.Value = 0;
                progressBar1.Maximum = Arquivos.Length;

                //Começamos a listar os arquivos
                foreach (FileInfo fileinfo in Arquivos)
                {
                    if (cancelar)
                    {
                        cancelar = false;
                        return new Dictionary<string, string>();
                    }
                    else
                    {
                        listaDirArquivo.Add(fileinfo.DirectoryName 
                            + Path.DirectorySeparatorChar 
                            + fileinfo.Name, fileinfo.Length.ToString());
                        progressBar1.Value += 1;
                    }
                    
                    Application.DoEvents();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao recuperar informações dos arquivos no drive selecionado.\nVerificar as permissões de acesso."
                    , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            finally
            {
                progressBar1.Value = 0;
            }
            return listaDirArquivo;
        }

        private void AddRange(Dictionary<string, string> listaDirArquivo, Dictionary<string, string> listaNovos)
        {
            foreach (KeyValuePair<string, string> dirArquivo in listaNovos)
            {
                listaDirArquivo.Add(dirArquivo.Key, dirArquivo.Value);
            }
        }

        private void btSearchCatalog_Click(object sender, EventArgs e)
        {
            frConsulta consulta = new frConsulta();
            consulta.ShowDialog(this);
        }

        private void btID_Aleatorio_Click(object sender, EventArgs e)
        {
            Random rNum = new Random();
            txtIndentificador.Text = rNum.Next(1000, 9999).ToString();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            driveListBox1.Drive = "c:";
            driveListBox1.Update();

            dirListBox1.Path = "c:\\";
            dirListBox1.Update();

            fileListBox1.Path = dirListBox1.get_DirList(dirListBox1.DirListIndex);
            fileListBox1.Update();

            cbExtensao.Text = "*.*";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cancelar = true;
        }
    }
}