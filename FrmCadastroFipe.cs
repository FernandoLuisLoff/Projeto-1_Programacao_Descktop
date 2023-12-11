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
    public partial class FrmCadastroFipe : Form
    {
        String IdFipe;
       
        public FrmCadastroFipe(string IdFipe)
        {
            InitializeComponent();
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.seguradoraDataSet.Marcas);
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Modelos'. Você pode movê-la ou removê-la conforme necessário.
            this.modelosTableAdapter.Fill(this.seguradoraDataSet.Modelos);
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Modelos'. Você pode movê-la ou removê-la conforme necessário.
            this.modelosTableAdapter.Fill(this.seguradoraDataSet.Modelos);
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.TabelaFIPE'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaFIPETableAdapter.Fill(this.seguradoraDataSet.TabelaFIPE);
            cbbMarca.SelectedIndex = 0;
            this.IdFipe = IdFipe;
            if (IdFipe == null)
            {
                this.Text = "Cadastrar Fipe";
                this.tabelaFIPEBindingSource.AddNew();
            }
            else
            {
                this.Text = "Editar FIPE";
                cbbMarca.Enabled = false;
                cbbModelo.Enabled = false;
                txtAno.Enabled = false;
                this.tabelaFIPEBindingSource.Filter = "ModeloID = " + IdFipe;
            }
        }


        private void tabelaFIPEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            DataRowView currentRow = (DataRowView)tabelaFIPEBindingSource.Current;
            if (String.IsNullOrWhiteSpace(cbbModelo.Text) || String.IsNullOrWhiteSpace(txtValor.Text) || String.IsNullOrWhiteSpace(txtAno.Text))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            else
            {
               
                if (txtAno.Text.Length == 4 && int.TryParse(txtAno.Text, out int ano))
                {
                    int valor = int.Parse(txtValor.Text);
                    if (ano <= DateTime.Now.Year && ano > 0 && valor > 0) 
                    {
                        this.Validate();
                        this.tabelaFIPEBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.seguradoraDataSet);
                        MessageBox.Show(IdFipe != null ? "Fipe alterada com sucesso" : "Fipe cadastrada com sucesso");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Dados invalidos, verifique novamente");
                        return;
                    }
                }
                else
                {
                   
                    MessageBox.Show("O campo Ano deve conter 4 caracteres!");
                    return;
                    
                }
               
            }
        }

        private void FrmCadastroFipe_Load(object sender, EventArgs e)
        {
           
        }

        
        private void marcasBindingSource_PositionChanged(object sender, EventArgs e)
        {
            var row = ((DataRowView)marcasBindingSource.Current).Row as seguradoraDataSet.MarcasRow;
            modelosBindingSource.Filter = "MarcaID = " + row.Id;
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
