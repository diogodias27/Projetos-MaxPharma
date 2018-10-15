namespace MaxFichaPedidos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboBusca = new System.Windows.Forms.ComboBox();
            this.LABELp = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnImportarExcel = new System.Windows.Forms.Button();
            this.labelRegistros = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.txtBarras = new System.Windows.Forms.TextBox();
            this.btn_addFalta = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportarDGV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboBusca
            // 
            this.cboBusca.FormattingEnabled = true;
            this.cboBusca.Location = new System.Drawing.Point(126, 13);
            this.cboBusca.Name = "cboBusca";
            this.cboBusca.Size = new System.Drawing.Size(121, 21);
            this.cboBusca.TabIndex = 6;
            // 
            // LABELp
            // 
            this.LABELp.AutoSize = true;
            this.LABELp.Location = new System.Drawing.Point(13, 16);
            this.LABELp.Name = "LABELp";
            this.LABELp.Size = new System.Drawing.Size(97, 13);
            this.LABELp.TabIndex = 1;
            this.LABELp.Text = "PROCURAR POR:";
            // 
            // txtCriterio
            // 
            this.txtCriterio.AcceptsReturn = true;
            this.txtCriterio.AcceptsTab = true;
            this.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCriterio.Location = new System.Drawing.Point(338, 12);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(129, 20);
            this.txtCriterio.TabIndex = 2;
            this.txtCriterio.Enter += new System.EventHandler(this.btnProcurar_Click);
            this.txtCriterio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCriterio_KeyPress);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(487, 9);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(591, 9);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 4;
            this.btnExibir.Text = "Exibir Todos";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(16, 52);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(321, 328);
            this.dgvDados.TabIndex = 5;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.AcceptsTab = true;
            this.txtArquivoExcel.Location = new System.Drawing.Point(16, 413);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(150, 20);
            this.txtArquivoExcel.TabIndex = 0;
            this.txtArquivoExcel.Enter += new System.EventHandler(this.btnImportarExcel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = ".";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(172, 411);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(122, 23);
            this.btnLocalizar.TabIndex = 7;
            this.btnLocalizar.Text = "BUSCAR PLANILHA";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnImportarExcel
            // 
            this.btnImportarExcel.Location = new System.Drawing.Point(300, 411);
            this.btnImportarExcel.Name = "btnImportarExcel";
            this.btnImportarExcel.Size = new System.Drawing.Size(99, 23);
            this.btnImportarExcel.TabIndex = 8;
            this.btnImportarExcel.Text = "Importar Excel";
            this.btnImportarExcel.UseVisualStyleBackColor = true;
            this.btnImportarExcel.Click += new System.EventHandler(this.btnImportarExcel_Click);
            // 
            // labelRegistros
            // 
            this.labelRegistros.AutoSize = true;
            this.labelRegistros.Location = new System.Drawing.Point(13, 478);
            this.labelRegistros.Name = "labelRegistros";
            this.labelRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelRegistros.TabIndex = 9;
            this.labelRegistros.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedicamento.Location = new System.Drawing.Point(0, 94);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(196, 20);
            this.txtMedicamento.TabIndex = 12;
            // 
            // txtBarras
            // 
            this.txtBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBarras.Location = new System.Drawing.Point(4, 45);
            this.txtBarras.Name = "txtBarras";
            this.txtBarras.Size = new System.Drawing.Size(196, 20);
            this.txtBarras.TabIndex = 13;
            // 
            // btn_addFalta
            // 
            this.btn_addFalta.Location = new System.Drawing.Point(54, 119);
            this.btn_addFalta.Name = "btn_addFalta";
            this.btn_addFalta.Size = new System.Drawing.Size(75, 23);
            this.btn_addFalta.TabIndex = 14;
            this.btn_addFalta.Text = "Add A Falta";
            this.btn_addFalta.UseVisualStyleBackColor = true;
            this.btn_addFalta.Click += new System.EventHandler(this.btn_addFalta_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV.Location = new System.Drawing.Point(591, 52);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(332, 328);
            this.DGV.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PRODUTO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "COD.BARRAS";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // btnExportarDGV
            // 
            this.btnExportarDGV.Location = new System.Drawing.Point(591, 392);
            this.btnExportarDGV.Name = "btnExportarDGV";
            this.btnExportarDGV.Size = new System.Drawing.Size(173, 23);
            this.btnExportarDGV.TabIndex = 16;
            this.btnExportarDGV.Text = "EXPORTAR PARA EXCEL";
            this.btnExportarDGV.UseVisualStyleBackColor = true;
            this.btnExportarDGV.Click += new System.EventHandler(this.btnExportarDGV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "DESCRIÇÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "PLANILHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "PRODUTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "CODIGO BARRAS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(864, 478);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(810, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "SOBRE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMedicamento);
            this.groupBox1.Controls.Add(this.txtBarras);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_addFalta);
            this.groupBox1.Location = new System.Drawing.Point(362, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportarDGV);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelRegistros);
            this.Controls.Add(this.btnImportarExcel);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.LABELp);
            this.Controls.Add(this.cboBusca);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DROGARIAS MAX PHARMA...";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBusca;
        private System.Windows.Forms.Label LABELp;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnImportarExcel;
        private System.Windows.Forms.Label labelRegistros;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.TextBox txtBarras;
        private System.Windows.Forms.Button btn_addFalta;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnExportarDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

