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
    public partial class FrmCadastroUsuario : Form
    {
        public string idCliente;
        public FrmCadastroUsuario(FrmApolice formulario)
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seguradoraDataSet);

        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.seguradoraDataSet.Clientes);
            this.clientesBindingSource.AddNew();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seguradoraDataSet);
            this.idCliente = clienteIDTextBox.Text;
            Close();
        }
    }
}
