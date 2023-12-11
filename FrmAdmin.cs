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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void Cad_Marcas_Click(object sender, EventArgs e)
        {
            FrmMarcas frm = new FrmMarcas();
            frm.ShowDialog();
        }

        private void Cad_Modelo_Click(object sender, EventArgs e)
        {
            FrmModelos frmModelo = new FrmModelos();
            frmModelo.ShowDialog();
        }

        private void Cad_Fipe_Click(object sender, EventArgs e)
        {
            FrmFipe frmFipe = new FrmFipe();
            frmFipe.ShowDialog();
        }
    }
}
