using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace DriveCatalog
{
    public partial class frConsulta : Form
    {
        private List<DriveData> listaDados;
        DataTable dtDados;

        public frConsulta()
        {
            InitializeComponent();
        }

        private void frConsulta_Load(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Application.StartupPath);
            FileInfo[] filesInfos = dirInfo.GetFiles("*.xml");
            StreamReader sr;
            listaDados = new List<DriveData>();
            foreach (FileInfo fInfo in filesInfos)
            {
                sr = new StreamReader(fInfo.DirectoryName + Path.DirectorySeparatorChar + fInfo.Name);
                XmlSerializer xs = new XmlSerializer(typeof(DriveData));
                DriveData driveData = (DriveData)xs.Deserialize(sr);
                listaDados.Add(driveData);
            }

            PopulaListaArquivos(listaDados);

        }

        private void PopulaListaArquivos(List<DriveData> listaDados)
        {
            dtDados = new DataTable();
            dtDados.Columns.Add("NomeArquivo", typeof(string));
            dtDados.Columns.Add("Identidicador", typeof(string));
            dtDados.Columns.Add("Diretorio", typeof(string));
            dtDados.Columns.Add("Tamanho", typeof(string));
            dtDados.Columns.Add("Data", typeof(string));
            dtDados.Columns.Add("TamanhoBytes", typeof(string));

            cbIdentificador.Items.Clear();
            cbIdentificador.Items.Add("");
            foreach (DriveData dado in listaDados)
            {
                cbIdentificador.Items.Add(dado.Identificador);
                foreach (ChaveValorSer<string, string> arquivo in dado.File)
                {
                    FileInfo fileInfo = new FileInfo(arquivo.File);
                    DataRow dr = dtDados.NewRow();
                    dr["Identidicador"] = dado.Identificador;
                    dr["Data"] = dado.Data;
                    dr["NomeArquivo"] = fileInfo.Name;
                    dr["Diretorio"] = fileInfo.DirectoryName;
                    dr["Tamanho"] = ConverteBytes(long.Parse(arquivo.Size));
                    dr["TamanhoBytes"] = arquivo.Size;
                    dtDados.Rows.Add(dr);
                }
            }
            dgResultado.DataSource = dtDados;
            dgResultado.Columns["NomeArquivo"].Width = 200;
            dgResultado.Columns["Identidicador"].Width = 100;
            dgResultado.Columns["Diretorio"].Width = 300;
            dgResultado.Columns["TamanhoBytes"].Visible = false;
        }

        private string ConverteBytes(long byteCount)
        {
            string size = "0 Bytes";
            try
            {
                if (byteCount >= 1073741824.0)
                    size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
                else if (byteCount >= 1048576.0)
                    size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
                else if (byteCount >= 1024.0)
                    size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
                else if (byteCount > 0 && byteCount < 1024.0)
                    size = byteCount.ToString() + " Bytes";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao calcular tamanho do arquivo.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return size;
        }

        private void txtNomeArquivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dtDados.DefaultView;
                //dv.Sort = "NomeArquivo";
                dv.RowFilter = "Identidicador like '*" + cbIdentificador.Text + "*' and NomeArquivo like '*" + txtNomeArquivo.Text + "*' " +
                    "and Diretorio like '*" + tbPasta.Text + "*' "; 
                dgResultado.DataSource = dv;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocoreu um erro durante o filtro de arquivos.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeArquivo.Text = string.Empty;
            }
        }

        private void cbIdentificador_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dtDados.DefaultView;
                //dv.Sort = "NomeArquivo";
                dv.RowFilter = "NomeArquivo like '*" + txtNomeArquivo.Text + "*' and Identidicador like '*" + cbIdentificador.Text + "*'";
                dgResultado.DataSource = dv;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocoreu um erro durante o filtro de arquivos.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dtDados.DefaultView;
                //dv.Sort = "Diretorio, NomeArquivo";
                dv.RowFilter = "NomeArquivo like '*" +
                    txtNomeArquivo.Text +
                    "*' and Identidicador like '*" +
                    cbIdentificador.Text + "*'" +
                   " and Data like '*" + dtpData.Value.ToShortDateString() + "*'";
                dgResultado.DataSource = dv;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocoreu um erro durante o filtro de arquivos.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgResultado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbQuantidade.Text = dgResultado.RowCount.ToString();

            long tamanhoBytes = 0;
            foreach (DataGridViewRow row in dgResultado.Rows)
	        {
                long tamanho;
                if (long.TryParse(row.Cells["TamanhoBytes"].Value.ToString(), out tamanho))
                {
                    tamanhoBytes += tamanho;
                }
            }
            lbQuantidade.Text += "  - Tamanho: " + ConverteBytes(tamanhoBytes);
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbIdentificador.Text != string.Empty)
                {
                    string arquivo = cbIdentificador.Text + ".xml";
                    if (MessageBox.Show("Deseja realmente apagar o catálogo: " + arquivo + " ?", "Apagar Catálogo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (File.Exists(arquivo))
                        {
                            File.Delete(arquivo);
                            MessageBox.Show("Catálogo apagado com sucesso.");
                            frConsulta_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Catálogo não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum catálogo foi selecionado.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível apagar o arquivo. Verificar as permissões de acesso.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPasta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dtDados.DefaultView;
                //dv.Sort = "NomeArquivo";
                dv.RowFilter = "Identidicador like '*" + cbIdentificador.Text + "*' and NomeArquivo like '*" + txtNomeArquivo.Text + "*' " +
                    "and Diretorio like '*" + tbPasta.Text + "*' ";
                dgResultado.DataSource = dv;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocoreu um erro durante o filtro de arquivos.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeArquivo.Text = string.Empty;
            }
        }
    }
}