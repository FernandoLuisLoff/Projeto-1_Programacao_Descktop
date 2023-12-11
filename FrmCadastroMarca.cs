using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSeguradora
{
    public partial class FrmCadastroMarcas : Form
    {
        string idMarca;
        public FrmCadastroMarcas(string idMarca)
        {
            InitializeComponent();
            this.idMarca = idMarca;
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.seguradoraDataSet.Marcas);
            if(idMarca == null)
            {
                this.Text = "Cadastrar marca.";
                this.marcasBindingSource.AddNew();
            }
            else
            {
                this.Text = "Alterar marca.";
                marcasBindingSource.Filter = "Id = " + idMarca;
            }
        }

        private void marcasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DataRowView currentRow = (DataRowView)marcasBindingSource.Current;
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Por favor, digite a marca antes de salvar.");
                return; 
            }

            this.Validate();
            this.marcasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seguradoraDataSet);
            MessageBox.Show(idMarca != null ? "Marca alterada com sucesso" : "Marca cadastrada com sucesso");
            this.Close();

        }


    }
}
