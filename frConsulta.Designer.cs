namespace DriveCatalog
{
    partial class frConsulta
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
            this.lbNomeArquivo = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.lbDrive = new System.Windows.Forms.Label();
            this.cbIdentificador = new System.Windows.Forms.ComboBox();
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbData = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.lbPasta = new System.Windows.Forms.Label();
            this.tbPasta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomeArquivo
            // 
            this.lbNomeArquivo.AutoSize = true;
            this.lbNomeArquivo.Location = new System.Drawing.Point(10, 20);
            this.lbNomeArquivo.Name = "lbNomeArquivo";
            this.lbNomeArquivo.Size = new System.Drawing.Size(88, 13);
            this.lbNomeArquivo.TabIndex = 1;
            this.lbNomeArquivo.Text = "Nome do arquivo";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeArquivo.Location = new System.Drawing.Point(13, 36);
            this.txtNomeArquivo.MaxLength = 30;
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(162, 20);
            this.txtNomeArquivo.TabIndex = 0;
            this.txtNomeArquivo.TextChanged += new System.EventHandler(this.txtNomeArquivo_TextChanged);
            // 
            // lbDrive
            // 
            this.lbDrive.AutoSize = true;
            this.lbDrive.Location = new System.Drawing.Point(10, 66);
            this.lbDrive.Name = "lbDrive";
            this.lbDrive.Size = new System.Drawing.Size(125, 13);
            this.lbDrive.TabIndex = 3;
            this.lbDrive.Text = "Identificador do Catálogo";
            // 
            // cbIdentificador
            // 
            this.cbIdentificador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdentificador.FormattingEnabled = true;
            this.cbIdentificador.Location = new System.Drawing.Point(13, 82);
            this.cbIdentificador.Name = "cbIdentificador";
            this.cbIdentificador.Size = new System.Drawing.Size(162, 21);
            this.cbIdentificador.TabIndex = 2;
            this.cbIdentificador.SelectedIndexChanged += new System.EventHandler(this.cbIdentificador_SelectedIndexChanged);
            // 
            // dgResultado
            // 
            this.dgResultado.AllowUserToAddRows = false;
            this.dgResultado.AllowUserToDeleteRows = false;
            this.dgResultado.AllowUserToResizeRows = false;
            this.dgResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgResultado.Location = new System.Drawing.Point(1, 139);
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.RowHeadersVisible = false;
            this.dgResultado.RowHeadersWidth = 39;
            this.dgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResultado.Size = new System.Drawing.Size(513, 234);
            this.dgResultado.TabIndex = 5;
            this.dgResultado.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgResultado_DataBindingComplete);
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(342, 82);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(165, 20);
            this.dtpData.TabIndex = 3;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // lbData
            // 
            this.lbData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(339, 66);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 8;
            this.lbData.Text = "Data";
            // 
            // lbResultado
            // 
            this.lbResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(10, 379);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(128, 13);
            this.lbResultado.TabIndex = 9;
            this.lbResultado.Text = "Arquivo(s) encontrado(s): ";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(144, 379);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(14, 13);
            this.lbQuantidade.TabIndex = 10;
            this.lbQuantidade.Text = "0";
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechar.Location = new System.Drawing.Point(439, 375);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 21);
            this.btFechar.TabIndex = 4;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(181, 80);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(98, 23);
            this.btApagar.TabIndex = 12;
            this.btApagar.Text = "Apagar Catálogo";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // lbPasta
            // 
            this.lbPasta.AutoSize = true;
            this.lbPasta.Location = new System.Drawing.Point(210, 17);
            this.lbPasta.Name = "lbPasta";
            this.lbPasta.Size = new System.Drawing.Size(34, 13);
            this.lbPasta.TabIndex = 13;
            this.lbPasta.Text = "Pasta";
            // 
            // tbPasta
            // 
            this.tbPasta.Location = new System.Drawing.Point(210, 36);
            this.tbPasta.MaxLength = 60;
            this.tbPasta.Name = "tbPasta";
            this.tbPasta.Size = new System.Drawing.Size(297, 20);
            this.tbPasta.TabIndex = 1;
            this.tbPasta.TextChanged += new System.EventHandler(this.tbPasta_TextChanged);
            // 
            // frConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 401);
            this.Controls.Add(this.tbPasta);
            this.Controls.Add(this.lbPasta);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.dgResultado);
            this.Controls.Add(this.cbIdentificador);
            this.Controls.Add(this.lbDrive);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.lbNomeArquivo);
            this.MinimumSize = new System.Drawing.Size(535, 437);
            this.Name = "frConsulta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de arquivos";
            this.Load += new System.EventHandler(this.frConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeArquivo;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label lbDrive;
        private System.Windows.Forms.ComboBox cbIdentificador;
        private System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Label lbPasta;
        private System.Windows.Forms.TextBox tbPasta;
    }
}