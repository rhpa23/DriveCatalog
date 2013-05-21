namespace DriveCatalog
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.fileListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.dirListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.driveListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.btCatalog = new System.Windows.Forms.Button();
            this.btSearchCatalog = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.txtIndentificador = new System.Windows.Forms.TextBox();
            this.btID_Aleatorio = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbData = new System.Windows.Forms.Label();
            this.cbTipoArquivos = new System.Windows.Forms.ComboBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbExtensao = new System.Windows.Forms.Label();
            this.cbExtensao = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileListBox1
            // 
            this.fileListBox1.FormattingEnabled = true;
            this.fileListBox1.Location = new System.Drawing.Point(254, 12);
            this.fileListBox1.Name = "fileListBox1";
            this.fileListBox1.Pattern = "*.*";
            this.fileListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.fileListBox1.Size = new System.Drawing.Size(221, 381);
            this.fileListBox1.TabIndex = 0;
            // 
            // dirListBox1
            // 
            this.dirListBox1.FormattingEnabled = true;
            this.dirListBox1.IntegralHeight = false;
            this.dirListBox1.Location = new System.Drawing.Point(10, 39);
            this.dirListBox1.Name = "dirListBox1";
            this.dirListBox1.Size = new System.Drawing.Size(238, 173);
            this.dirListBox1.TabIndex = 1;
            this.dirListBox1.SelectedIndexChanged += new System.EventHandler(this.dirListBox1_SelectedIndexChanged);
            // 
            // driveListBox1
            // 
            this.driveListBox1.FormattingEnabled = true;
            this.driveListBox1.Location = new System.Drawing.Point(10, 12);
            this.driveListBox1.Name = "driveListBox1";
            this.driveListBox1.Size = new System.Drawing.Size(238, 21);
            this.driveListBox1.TabIndex = 2;
            this.driveListBox1.SelectedIndexChanged += new System.EventHandler(this.driveListBox1_SelectedIndexChanged);
            // 
            // btCatalog
            // 
            this.btCatalog.Image = ((System.Drawing.Image)(resources.GetObject("btCatalog.Image")));
            this.btCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCatalog.Location = new System.Drawing.Point(10, 361);
            this.btCatalog.Name = "btCatalog";
            this.btCatalog.Size = new System.Drawing.Size(116, 30);
            this.btCatalog.TabIndex = 3;
            this.btCatalog.Text = "Gerar Catálogo";
            this.btCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCatalog.UseVisualStyleBackColor = true;
            this.btCatalog.Click += new System.EventHandler(this.btCatalog_Click);
            // 
            // btSearchCatalog
            // 
            this.btSearchCatalog.Image = ((System.Drawing.Image)(resources.GetObject("btSearchCatalog.Image")));
            this.btSearchCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearchCatalog.Location = new System.Drawing.Point(132, 361);
            this.btSearchCatalog.Name = "btSearchCatalog";
            this.btSearchCatalog.Size = new System.Drawing.Size(116, 30);
            this.btSearchCatalog.TabIndex = 4;
            this.btSearchCatalog.Text = "Procurar Catálogo";
            this.btSearchCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearchCatalog.UseVisualStyleBackColor = true;
            this.btSearchCatalog.Click += new System.EventHandler(this.btSearchCatalog_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(6, 23);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(125, 13);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "Identificador do Catálogo";
            // 
            // txtIndentificador
            // 
            this.txtIndentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndentificador.Location = new System.Drawing.Point(9, 39);
            this.txtIndentificador.Name = "txtIndentificador";
            this.txtIndentificador.Size = new System.Drawing.Size(122, 26);
            this.txtIndentificador.TabIndex = 6;
            // 
            // btID_Aleatorio
            // 
            this.btID_Aleatorio.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btID_Aleatorio.Location = new System.Drawing.Point(131, 39);
            this.btID_Aleatorio.Name = "btID_Aleatorio";
            this.btID_Aleatorio.Size = new System.Drawing.Size(17, 25);
            this.btID_Aleatorio.TabIndex = 7;
            this.btID_Aleatorio.Text = "~";
            this.btID_Aleatorio.UseVisualStyleBackColor = true;
            this.btID_Aleatorio.Click += new System.EventHandler(this.btID_Aleatorio_Click);
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(9, 94);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(95, 20);
            this.dtpData.TabIndex = 8;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(6, 78);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 9;
            this.lbData.Text = "Data";
            // 
            // cbTipoArquivos
            // 
            this.cbTipoArquivos.FormattingEnabled = true;
            this.cbTipoArquivos.Items.AddRange(new object[] {
            "Filmes",
            "Musicas",
            "Imagens",
            "Instaladores",
            "Backup",
            "Diversos"});
            this.cbTipoArquivos.Location = new System.Drawing.Point(116, 94);
            this.cbTipoArquivos.Name = "cbTipoArquivos";
            this.cbTipoArquivos.Size = new System.Drawing.Size(101, 21);
            this.cbTipoArquivos.TabIndex = 10;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(113, 78);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(87, 13);
            this.lbTipo.TabIndex = 11;
            this.lbTipo.Text = "Tipo de Arquivos";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-2, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(303, 28);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbExtensao);
            this.groupBox1.Controls.Add(this.cbExtensao);
            this.groupBox1.Controls.Add(this.cbTipoArquivos);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.lbTipo);
            this.groupBox1.Controls.Add(this.txtIndentificador);
            this.groupBox1.Controls.Add(this.btID_Aleatorio);
            this.groupBox1.Controls.Add(this.lbData);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Location = new System.Drawing.Point(10, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 124);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catálogo";
            // 
            // lbExtensao
            // 
            this.lbExtensao.AutoSize = true;
            this.lbExtensao.Location = new System.Drawing.Point(155, 23);
            this.lbExtensao.Name = "lbExtensao";
            this.lbExtensao.Size = new System.Drawing.Size(51, 13);
            this.lbExtensao.TabIndex = 16;
            this.lbExtensao.Text = "Extensao";
            // 
            // cbExtensao
            // 
            this.cbExtensao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExtensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtensao.FormattingEnabled = true;
            this.cbExtensao.Items.AddRange(new object[] {
            "*.*",
            "*.avi",
            "*.wmv",
            "*.flv",
            "*.mov",
            "*.mp3",
            "*.wav",
            "*.jpg",
            "*.gif",
            "*.png",
            "*.bmp",
            "*.doc",
            "*.xls",
            "*.pps",
            "*.pdf",
            "*.swf",
            "*.java",
            "*.cs",
            "*.xml",
            "*.cfg",
            "*.exe",
            "*.bat",
            "*.tmp",
            "*.txt"});
            this.cbExtensao.Location = new System.Drawing.Point(158, 39);
            this.cbExtensao.Name = "cbExtensao";
            this.cbExtensao.Size = new System.Drawing.Size(59, 23);
            this.cbExtensao.TabIndex = 16;
            // 
            // btSair
            // 
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(391, 1);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(82, 28);
            this.btSair.TabIndex = 14;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 34);
            this.panel1.TabIndex = 15;
            // 
            // btCancelar
            // 
            this.btCancelar.Enabled = false;
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(307, 1);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(82, 28);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSearchCatalog);
            this.Controls.Add(this.btCatalog);
            this.Controls.Add(this.driveListBox1);
            this.Controls.Add(this.dirListBox1);
            this.Controls.Add(this.fileListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drive Catalog v1.0";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox fileListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox dirListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox driveListBox1;
        private System.Windows.Forms.Button btCatalog;
        private System.Windows.Forms.Button btSearchCatalog;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtIndentificador;
        private System.Windows.Forms.Button btID_Aleatorio;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.ComboBox cbTipoArquivos;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbExtensao;
        private System.Windows.Forms.Label lbExtensao;
        private System.Windows.Forms.Button btCancelar;
    }
}

