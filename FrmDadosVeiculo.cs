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
    public partial class FrmDadosVeiculo : Form
    {
        public FrmDadosVeiculo()
        {
            InitializeComponent();
        }

        private void FrmDadosVeiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            this.apolicesTableAdapter.Fill(this.seguradoraDataSet.Apolices);
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.seguradoraDataSet.Marcas);
            tabControl1.Dock = DockStyle.Fill;
        }

        private void marcasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seguradoraDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
