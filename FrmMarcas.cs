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
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void atualizaGRID()
        {
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.seguradoraDataSet.Marcas);
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.seguradoraDataSet.Marcas);
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
           
            atualizaGRID();

        }

        private void buscarMarcas()
        {
            String buscaMarca = txtBuscarMarca.Text.Trim();

            if (!String.IsNullOrEmpty(buscaMarca))
            {
               marcasBindingSource.Filter = "Marca LIKE '%" + buscaMarca + "%'";
            }
            else
            {
                marcasBindingSource.Filter = "";
                return;

            }
        }

        private void marcasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView currentRow = (DataRowView)marcasBindingSource.Current;
            FrmCadastroMarcas frmCadastroMarcas = new FrmCadastroMarcas(currentRow.Row["Id"].ToString());
            frmCadastroMarcas.ShowDialog();
            atualizaGRID();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroMarcas frmCadastroMarcas = new FrmCadastroMarcas(null);
            frmCadastroMarcas.ShowDialog();
            atualizaGRID();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtBuscarMarca.Text == "")
            {
                MessageBox.Show("digite um valor para o campo se quiser buscar uma marca");
            }
            else
            {
                buscarMarcas();
            }
        }

        private void txtBuscarMarca_TextChanged_1(object sender, EventArgs e)
        {
            buscarMarcas();
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (marcasDataGridView.Rows.Count > 0)
                    {
                        DataGridViewRow linha = marcasDataGridView.SelectedRows[0];
                        int id = Convert.ToInt32(linha.Cells["Id"].Value);

                        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\guilh\\Desktop\\Projeto-Seguradora-master\\seguradora.mdf;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM Marcas WHERE Id = @id";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Id", id);
                            command.ExecuteNonQuery();
                        }

                        marcasDataGridView.Rows.RemoveAt(marcasDataGridView.SelectedRows[0].Index);
                        MessageBox.Show("Marca removida com sucesso!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não é possivel remover uma Marca que esta vinculada a um Modelo de veiculo!");
                return;
            }

        }
    }
}
