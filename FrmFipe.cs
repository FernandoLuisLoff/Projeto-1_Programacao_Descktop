using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSeguradora
{
    public partial class FrmFipe : Form
    {
        public FrmFipe()
        {
            InitializeComponent();
            cbbBusca.SelectedIndex = 0;
        }

        private void atualizaGRID()
        {
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.ViewFipe'. Você pode movê-la ou removê-la conforme necessário.
            this.viewFipeTableAdapter.Fill(this.seguradoraDataSet.ViewFipe);
        }

        private void FrmFipe_Load(object sender, EventArgs e)
        {
            atualizaGRID();
        }

        private void btnNovaFipe_Click(object sender, EventArgs e)
        {
            FrmCadastroFipe frmCadastroFipe = new FrmCadastroFipe(null);
            frmCadastroFipe.ShowDialog();
            atualizaGRID();

        }

        private void buscarMarcas()
        {
            String buscaMarca = txtBusca.Text.Trim();

            if (!String.IsNullOrEmpty(buscaMarca))
            {
                viewFipeBindingSource.Filter = "Marca LIKE '%" + buscaMarca + "%'";
            }
            else
            {
                viewFipeBindingSource.Filter = "";
                return;

            }
        }

        private void buscaModelo()
        {
            String buscaModelo = txtBusca.Text.Trim();

            if (!String.IsNullOrEmpty(buscaModelo))
            {
                viewFipeBindingSource.Filter = "Modelo LIKE '%" + buscaModelo + "%'";
            }
            else
            {
                viewFipeBindingSource.Filter = "";
                return;
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbbBusca.Text.Equals("Marcas"))
            {
                buscarMarcas();
            }
            else
            {
                buscaModelo();
            }
        }

        private void viewFipeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView currentRow = (DataRowView)viewFipeBindingSource.Current;
            FrmCadastroFipe frmCadastroFipe = new FrmCadastroFipe(currentRow.Row["ModeloID"].ToString());
            frmCadastroFipe.ShowDialog();
            atualizaGRID();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (viewFipeDataGridView.Rows.Count > 0)
                    {
                        DataGridViewRow linha = viewFipeDataGridView.SelectedRows[0];
                        int idModelo = Convert.ToInt32(linha.Cells["ModeloID"].Value);
                        int anoModelo = Convert.ToInt32(linha.Cells["Ano"].Value);
                        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\guilh\\Desktop\\Projeto-Seguradora-master\\seguradora.mdf;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM TabelaFipe WHERE ModeloID = @ID AND Ano = @Ano";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID", idModelo);
                            command.Parameters.AddWithValue("@Ano", anoModelo);
                            command.ExecuteNonQuery();
                        }
                        viewFipeDataGridView.Rows.RemoveAt(viewFipeDataGridView.SelectedRows[0].Index);
                        MessageBox.Show("Tabela FIPE removida com sucesso!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não Foi possivel remover o valor da tabela Fipe!");
                return;
            }
        }
    }
}
