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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void Txtusuari_TextChanged(object sender, EventArgs e)
        {

        }
        private void Txtusuari_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
                
            //Para obligar a que sólo se introduzcan letras
            
        }

        private void Txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {//Para obligar a que sólo se introduzcan números 
            Txtcontra.PasswordChar = '*';
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (char.IsControl(e.KeyChar))//permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            

           
        }

        private void Btnstar_Click(object sender, EventArgs e)
        {
            if (Txtusuari.Text == "Admin")
            {
                if (Txtcontra .Text == "2453")
                {

                    Form1 form = new Form1();
                    form.ShowDialog();
                    
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrectto");
            }


            
        }
    }
}
