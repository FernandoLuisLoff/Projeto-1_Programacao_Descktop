using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSeguradora
{
    public partial class FrmCadastroModelo : Form
    {
        String idModelo;
        public FrmCadastroModelo(string idModelo)
        {
            InitializeComponent();
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.seguradoraDataSet.Marcas);
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Modelos'. Você pode movê-la ou removê-la conforme necessário.
            this.modelosTableAdapter.Fill(this.seguradoraDataSet.Modelos);
            this.idModelo = idModelo;
            if (idModelo == null )
            {
                this.Text = "Cadastrar modelo";
                this.modelosBindingSource.AddNew();
            }
            else
            {
                this.Text = "Editar Modelo";
                this.modelosBindingSource.Filter = "ModeloID = " + idModelo; 
            }
        }

        private void modelosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            DataRowView currentRow = (DataRowView)modelosBindingSource.Current;
            if (String.IsNullOrWhiteSpace(txtModelo.Text) || String.IsNullOrWhiteSpace(marcaComboBox.Text))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            this.Validate();
            this.modelosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seguradoraDataSet);
            MessageBox.Show(idModelo != null ? "Modelo alterado com sucesso" : "Modelo cadastrado com sucesso");
            this.Close();



        }
    }
}
