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

        string arquivoExcel = @"Produtos.xlsx";
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtArquivoExcel;
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
            buscarProduto();
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
            DGV.Rows.Add(txtMedicamento.Text, txtBarras.Text);

            txtMedicamento.Clear();
            txtBarras.Clear();
        }

        private void btnExportarDGV_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

            if (DGV.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < DGV.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = DGV.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < DGV.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < DGV.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = DGV.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO" + ex.Message);
                    XcelApp.Quit();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ficha de pedidos versão 1.0");

            //foram utilizados diversos sites para pesquisa até chegar a versão final
            //Diogo Dias 

        }

        private void buscarProduto()
        {
            try
            {
                ((DataTable)dgvDados.DataSource).DefaultView.RowFilter = string.Format("" + cboBusca.Text + " like '%{0}%'", txtCriterio.Text.Trim().Replace("'", "''"));
                labelRegistros.Text = (dgvDados.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO:" + ex.Message);
            }
        }

        private void txtCriterio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            buscarProduto();
        }
     

    }
}
