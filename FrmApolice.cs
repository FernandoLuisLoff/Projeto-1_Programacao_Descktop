using appSeguradora.seguradoraDataSetTableAdapters;
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
    public partial class FrmApolice : Form
    {
        public FrmApolice()
        {
            InitializeComponent();

        }

        private void FrmDadosVeiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Modelos'. Você pode movê-la ou removê-la conforme necessário.
            this.modelosTableAdapter.Fill(this.seguradoraDataSet.Modelos);
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            this.apolicesTableAdapter.Fill(this.seguradoraDataSet.Apolices);
            // TODO: esta linha de código carrega dados na tabela 'seguradoraDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.seguradoraDataSet.Marcas);
            tabControl1.Dock = DockStyle.Fill;
            this.apolicesBindingSource.AddNew();
            this.cbbCombustivel.SelectedIndex = 0;
        }

        private void marcasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seguradoraDataSet);

        }

        private void btnProximo1_Click(object sender, EventArgs e)
        {
            if (validaTab1())
            {
                tabControl1.SelectTab(1);
            }
        }

        private void btnProximo2_Click(object sender, EventArgs e)
        {
            if (validaTab2())
            {
                tabControl1.SelectTab(2);
            }
        }

        private void btnProximo3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnVoltar3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }

        private void btnContratar_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario(this);
            frmCadastroUsuario.ShowDialog();
            String idCliente = frmCadastroUsuario.idCliente;
            if (idCliente != null &&
                idCliente != "-1")
            {
                DataRowView apoliceRow = (DataRowView)apolicesBindingSource.Current;
                apoliceRow.Row["ClienteId"] = Convert.ToInt32(idCliente);
                apoliceRow.Row["Combustivel"] = cbbCombustivel.SelectedIndex;
                this.Validate();
                this.apolicesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.seguradoraDataSet);
                MessageBox.Show("Apolice gerada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("É necessário informar um cliente!");
            }
        }

        private void marcasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var row = ((DataRowView)marcasBindingSource.Current).Row as seguradoraDataSet.MarcasRow;
            modelosBindingSource.Filter = "MarcaID = " + row.Id;
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {

            double valorCarro = double.Parse(valorDoBemTextBox.Text);

            // Cauculo valor apolice
            double valorApolice = valorCarro + (valorCarro * 0.1);

            // Cauculo valor premio
            double valorInicialPremio = valorApolice * 0.015;

            double valorPremio = 0;
            bool peloMenosUmSelecionado = false;

            if (rouboCheckBox.Checked) // Roubo
            {
                valorPremio = valorInicialPremio + (valorInicialPremio * 0.12);
                peloMenosUmSelecionado = true;
            }

            if (vidrosCheckBox.Checked) // Vidros
            {
                valorPremio = valorPremio + (valorInicialPremio * 0.02);
                peloMenosUmSelecionado = true;
            }

            if (acidentesCheckBox.Checked) // Acidentes
            {
                valorPremio = valorPremio + (valorInicialPremio * 0.04);
                peloMenosUmSelecionado = true;
            }

            if (danosTerceirosCheckBox.Checked) // Danos contra terceiros
            {
                valorPremio = valorPremio + (valorInicialPremio * 0.05);
                peloMenosUmSelecionado = true;
            }

            if (franquiaRedCheckBox.Checked) // Franquia reduzida
            {
                valorPremio = valorPremio + (valorInicialPremio * 0.03);
                peloMenosUmSelecionado = true;
            }
            if (!peloMenosUmSelecionado)
            {
                MessageBox.Show("Selecione Pelo menos uma cobertura");
                tabControl1.SelectTab(2);
            }

            int experienciaMotorista = CalculaExperiencia(txtAnoHabilitacao.Text);

            if (experienciaMotorista > 2 && experienciaMotorista <= 5)
            {
                valorPremio = valorPremio - (valorPremio * 0.03);
            }

            if (experienciaMotorista > 5 && experienciaMotorista <= 10)
            {
                valorPremio = valorPremio - (valorPremio * 0.05);
            }

            if (experienciaMotorista > 10 && experienciaMotorista <= 20)
            {
                valorPremio = valorPremio - (valorPremio * 0.06);
            }

            if (experienciaMotorista > 20)
            {
                valorPremio = valorPremio - (valorPremio * 0.01);
            }

            // Cauculo da Franquia
            double valorFranquia = valorCarro * 0.06;

            if (franquiaRedCheckBox.Checked)
            {
                valorFranquia = valorFranquia / 2;
            }

            // Seta os valores nos campos
            lbValApolice.Text = string.Format("{0:F2}", valorApolice);
            lbValPremio.Text = string.Format("{0:F2}", valorPremio);
            lbValFranquia.Text = string.Format("{0:F2}", valorFranquia);
            DataRowView apoliceRow = (DataRowView)apolicesBindingSource.Current;
            apoliceRow.Row["ValorApolice"] = Convert.ToDecimal(valorApolice);
            apoliceRow.Row["ValorPremio"] = Convert.ToDecimal(valorPremio);
            apoliceRow.Row["ValorFranquia"] = Convert.ToDecimal(valorFranquia);
        }

        private bool validaTab1()
        {

            if (marcaComboBox.Items.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma marca antes de avançar.");
                tabControl1.SelectTab(0);
                return false;
            }
            else if (modeloComboBox1.Items.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um modelo antes de avançar.");
                tabControl1.SelectTab(0);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(valorDoBemTextBox.Text))
            {
                MessageBox.Show("Por favor, preencha o campo valor do carro antes de avançar.");
                tabControl1.SelectTab(0);
                return false;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(anoFabricacaoTextBox.Text) || String.IsNullOrWhiteSpace(anoModeloTextBox.Text))
                {
                    MessageBox.Show("Por favor, Preencha todos os campos");
                    return false;
                }
                else
                {
                    int anoFabricacao = int.Parse(anoFabricacaoTextBox.Text);
                    int anoModelo = int.Parse(anoModeloTextBox.Text);
                    if (string.IsNullOrWhiteSpace(anoFabricacaoTextBox.Text) || anoFabricacaoTextBox.Text.Length != 4 || anoFabricacao > DateTime.Now.Year && anoFabricacao > 0)
                    {
                        MessageBox.Show("Por favor, Verifique o Ano de Fabricação antes de avançar.");
                        tabControl1.SelectTab(0);
                        return false;
                    }
                    else if (string.IsNullOrWhiteSpace(anoModeloTextBox.Text) || anoModeloTextBox.Text.Length != 4 || anoModelo > DateTime.Now.Year && anoModelo < 0)
                    {
                        MessageBox.Show("Por favor, Verifique o Ano Modelo antes de avançar.");
                        tabControl1.SelectTab(0);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        private bool validaTab2()
        {
            if (string.IsNullOrWhiteSpace(chassiTextBox.Text))
            {
                MessageBox.Show("Por favor, preencha o campo chassi antes de avançar.");
                tabControl1.SelectTab(1);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(placaTextBox.Text))
            {
                MessageBox.Show("Por favor, preencha o campo placa antes de avançar.");
                tabControl1.SelectTab(1);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cbbCombustivel.Text))
            {
                MessageBox.Show("Por favor, preencha o campo combustível antes de avançar.");
                tabControl1.SelectTab(1);
                return false;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txtAnoHabilitacao.Text))
                {
                    MessageBox.Show("Insira o Ano da Primeira Habilitação");
                    return false;
                }
                else
                {
                    int anoCarta = int.Parse(txtAnoHabilitacao.Text);
                    if (string.IsNullOrWhiteSpace(txtAnoHabilitacao.Text) || txtAnoHabilitacao.Text.Length != 4 || anoCarta > DateTime.Now.Year && anoCarta > 0)
                    {
                        MessageBox.Show("Por favor, verifique o Ano da primeira habilitação.");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        private void anoFabricacaoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void anoModeloTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void valorDoBemTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int CalculaExperiencia(String anoCarta)
        {
            int ano = int.Parse(anoCarta);
            int exp = (DateTime.Now.Year) - ano;
            return exp;
        }
        
        

        
    }
}
