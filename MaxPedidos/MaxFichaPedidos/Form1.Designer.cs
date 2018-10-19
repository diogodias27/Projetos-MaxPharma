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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboBusca
            // 
            this.cboBusca.FormattingEnabled = true;
            this.cboBusca.Location = new System.Drawing.Point(169, 19);
            this.cboBusca.Name = "cboBusca";
            this.cboBusca.Size = new System.Drawing.Size(189, 21);
            this.cboBusca.TabIndex = 0;
            // 
            // LABELp
            // 
            this.LABELp.AutoSize = true;
            this.LABELp.BackColor = System.Drawing.Color.Transparent;
            this.LABELp.Location = new System.Drawing.Point(28, 22);
            this.LABELp.Name = "LABELp";
            this.LABELp.Size = new System.Drawing.Size(51, 13);
            this.LABELp.TabIndex = 1;
            this.LABELp.Text = "COLUNA";
            // 
            // txtCriterio
            // 
            this.txtCriterio.AcceptsReturn = true;
            this.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCriterio.Location = new System.Drawing.Point(169, 46);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(189, 20);
            this.txtCriterio.TabIndex = 2;
            this.txtCriterio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCriterio_KeyDown);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(283, 82);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(413, 204);
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
            this.dgvDados.Location = new System.Drawing.Point(12, 130);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(385, 340);
            this.dgvDados.TabIndex = 5;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Location = new System.Drawing.Point(12, 22);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(150, 20);
            this.txtArquivoExcel.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(168, 19);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(110, 23);
            this.btnLocalizar.TabIndex = 7;
            this.btnLocalizar.Text = "Buscar Excel";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnImportarExcel
            // 
            this.btnImportarExcel.Location = new System.Drawing.Point(168, 55);
            this.btnImportarExcel.Name = "btnImportarExcel";
            this.btnImportarExcel.Size = new System.Drawing.Size(110, 22);
            this.btnImportarExcel.TabIndex = 8;
            this.btnImportarExcel.Text = "Importar Excel";
            this.btnImportarExcel.UseVisualStyleBackColor = true;
            this.btnImportarExcel.Click += new System.EventHandler(this.btnImportarExcel_Click);
            // 
            // labelRegistros
            // 
            this.labelRegistros.AutoSize = true;
            this.labelRegistros.BackColor = System.Drawing.Color.Transparent;
            this.labelRegistros.Location = new System.Drawing.Point(93, 473);
            this.labelRegistros.Name = "labelRegistros";
            this.labelRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelRegistros.TabIndex = 9;
            this.labelRegistros.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(88, 68);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(161, 20);
            this.txtMedicamento.TabIndex = 12;
            // 
            // txtBarras
            // 
            this.txtBarras.Location = new System.Drawing.Point(88, 114);
            this.txtBarras.Name = "txtBarras";
            this.txtBarras.Size = new System.Drawing.Size(161, 20);
            this.txtBarras.TabIndex = 13;
            // 
            // btn_addFalta
            // 
            this.btn_addFalta.Location = new System.Drawing.Point(159, 182);
            this.btn_addFalta.Name = "btn_addFalta";
            this.btn_addFalta.Size = new System.Drawing.Size(75, 23);
            this.btn_addFalta.TabIndex = 14;
            this.btn_addFalta.Text = "Add A Falta";
            this.btn_addFalta.UseVisualStyleBackColor = true;
            this.btn_addFalta.Click += new System.EventHandler(this.btn_addFalta_Click);
            // 
            // txtQuant
            // 
            this.txtQuant.AcceptsTab = true;
            this.txtQuant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuant.Location = new System.Drawing.Point(88, 152);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(161, 20);
            this.txtQuant.TabIndex = 15;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(184, 71);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(159, 28);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(100, 20);
            this.txtDiretorio.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "DESTINO DO ARQUIVO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMedicamento);
            this.groupBox1.Controls.Add(this.txtBarras);
            this.groupBox1.Controls.Add(this.txtQuant);
            this.groupBox1.Controls.Add(this.btn_addFalta);
            this.groupBox1.Location = new System.Drawing.Point(528, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 211);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUTOS A INCLUIR NO .txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "PRODUTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "COD.BARRAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(7, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "QUANTIDADE:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtDiretorio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnGravar);
            this.groupBox2.Location = new System.Drawing.Point(528, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DESTINO";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnLocalizar);
            this.groupBox3.Controls.Add(this.txtArquivoExcel);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btnImportarExcel);
            this.groupBox3.Location = new System.Drawing.Point(16, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 130);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cboBusca);
            this.groupBox4.Controls.Add(this.txtCriterio);
            this.groupBox4.Controls.Add(this.btnProcurar);
            this.groupBox4.Controls.Add(this.LABELp);
            this.groupBox4.Location = new System.Drawing.Point(12, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 111);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FILTROS PARA BUSCA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(28, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PROCURAR POR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(859, 653);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRegistros);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnExibir);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Montagem falteiro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
    }
}

