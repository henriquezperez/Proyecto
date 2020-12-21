using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicicletas.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEstados frm = new frmEstados();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBicicletas frm = new frmBicicletas();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRegistroCliente frm = new FrmRegistroCliente();
            frm.ShowDialog();
        }
    }
}
