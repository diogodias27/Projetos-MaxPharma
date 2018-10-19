using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace MaxFichaPedidos
{


    public partial class Form1 : Form
    {
        public string diretorio;
        public TextWriter arquivo;
        string arquivoExcel = @"Produtos.xlsx";
        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            try
            {
                cboBusca.Items.Clear();

                DataTable dt = GetTabelaExcel(arquivoExcel);

                dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDados.DataSource = dt;

                labelRegistros.Text = (dgvDados.Rows.Count - 1).ToString();
                string[] listaNomeColunas = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();

                cboBusca.Items.AddRange(listaNomeColunas);
                if (cboBusca.Items.Count > 0)
                    cboBusca.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }

        private DataTable GetTabelaExcel(string arquivoExcel)
        {
            DataTable dt = new DataTable();

            try
            {
                string Ext = Path.GetExtension(arquivoExcel);
                string connectionString = "";

                if (Ext == ".xls")
                {
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                {
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();

                conn.Open();
                cmd.CommandText = "SELECT * FROM[" + nomePlanilha + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DialogResult drResult = openFileDialog1.ShowDialog();

            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtArquivoExcel.Text = openFileDialog1.FileName;
        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArquivoExcel.Text) && File.Exists(txtArquivoExcel.Text))
            {
                arquivoExcel = txtArquivoExcel.Text;
                CarregarDados();
            }
            else
            {
                CarregarDados();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dgvDados.DataSource).DefaultView.RowFilter = string.Format("" + cboBusca.Text + " like '%{0}%'", txtCriterio.Text.Trim().Replace("'", "''"));
                labelRegistros.Text = (dgvDados.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRo:" + ex.Message);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int coluna = e.ColumnIndex;
            int linha = e.RowIndex;

            DataGridViewRow row = this.dgvDados.Rows[linha];

            this.txtMedicamento.Text = row.Cells[0].Value.ToString();
            this.txtBarras.Text = row.Cells[1].Value.ToString();

        }

        private void btn_addFalta_Click(object sender, EventArgs e)
        {

            criarArquivo();

        }
        public void interfaceUsuario()
        {
            folderBrowserDialog.Description = "Selecione o Local do arquivo";

            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            folderBrowserDialog.ShowNewFolderButton = false;

            if (folderBrowserDialog.ShowDialog(this) != DialogResult.Cancel)
            {
                diretorio = folderBrowserDialog.SelectedPath;
            }
        }

        public void criarArquivo()
        {
            try
            {
                string nome_arquivo = diretorio + "\\textBox.txt";

                if (!File.Exists(nome_arquivo))
                    File.Create(nome_arquivo).Close();
                arquivo = File.AppendText(nome_arquivo);
               
                arquivo.WriteLine(txtBarras.Text +";" + txtQuant.Text +";"+txtBarras.Text+ ";"+ txtMedicamento.Text);

                MessageBox.Show("Dados salvos com sucesso!!!");

                txtBarras.Clear();
                txtMedicamento.Clear();
                txtQuant.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO" + ex.Message);
            }
            finally
            {
                //Fecho o arquivo
                arquivo.Close();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            interfaceUsuario();
            txtDiretorio.Text = diretorio;
        }

        private void txtCriterio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnProcurar.Focus();
            }
        }




    }
}
