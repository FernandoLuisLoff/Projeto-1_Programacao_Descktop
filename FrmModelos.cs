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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appSeguradora
{
    public partial class FrmModelos : Form
    {
        public FrmModelos()
        {
            InitializeComponent();
            CombBusca.SelectedIndex = 0;
        }

        private void atualizaGRID()
        {
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.ViewModelo'. Você pode movê-la ou removê-la conforme necessário.
            this.viewModeloTableAdapter.Fill(this.seguradoraDataSet.ViewModelo);

        }

        private void FrmModelos_Load(object sender, EventArgs e)
        {
            atualizaGRID();
        }

        private void btnNovoModelo_Click(object sender, EventArgs e)
        {
            FrmCadastroModelo frmCadastroModelo = new FrmCadastroModelo(null);
            frmCadastroModelo.ShowDialog();
            atualizaGRID();
        }

        //precisa ver pq nao funciona
        
        private void buscarMarcas()
        {
            String buscaMarca = txtBusca.Text.Trim();

            if (!String.IsNullOrEmpty(buscaMarca))
            {
                viewModeloBindingSource.Filter = "Marcas LIKE '%" + buscaMarca + "%'";
            }
            else
            {
                viewModeloBindingSource.Filter = "";
                return;

            }
        }

        private void buscaModelo()
        {
            String buscaModelo = txtBusca.Text.Trim();

            if(!String.IsNullOrEmpty(buscaModelo))
            {
                viewModeloBindingSource.Filter = "Modelo LIKE '%" + buscaModelo + "%'";
            }
            else
            {
                viewModeloBindingSource.Filter = "";
                return;
            }
        }

        private void txtBuscaMarca_TextChanged(object sender, EventArgs e)
        {
            if (CombBusca.Text.Equals("Marca"))
            {
                buscarMarcas();
            }else
            {
                buscaModelo();
            }
        }

        

        private void viewModeloDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView currentRow = (DataRowView)viewModeloBindingSource.Current;
            FrmCadastroModelo frmCadastroModelo = new FrmCadastroModelo(currentRow.Row["ModeloID"].ToString());
            frmCadastroModelo.ShowDialog();
            atualizaGRID();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(viewModeloDataGridView.Rows.Count > 0){
                        DataGridViewRow linha = viewModeloDataGridView.SelectedRows[0];
                        int idModelo = Convert.ToInt32(linha.Cells["ModeloID"].Value);
                        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\guilh\\Desktop\\Projeto-Seguradora-master\\seguradora.mdf;Integrated Security=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM Modelos WHERE ModeloID = @ID";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID", idModelo);
                            command.ExecuteNonQuery();
                        }
                        viewModeloDataGridView.Rows.RemoveAt(viewModeloDataGridView.SelectedRows[0].Index);
                        MessageBox.Show("Modelos removido com sucesso!");
                    }  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possivel remover um Modelo que Contenha um Valor de Fipe Cadastrado!");
                return;
            }
        }
    }
}
