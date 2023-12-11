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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(abreFormAdmin);
        }

        private void abreFormAdmin(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F5)
            {
                FrmAdmin formAdmin = new FrmAdmin();
                formAdmin.ShowDialog();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmApolice frmDadosVeiculo = new FrmApolice();
            frmDadosVeiculo.ShowDialog();
        }
    }
}
