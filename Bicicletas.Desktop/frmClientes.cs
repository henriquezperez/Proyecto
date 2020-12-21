using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bicicletas.Entities;
using Bicicletas.BusinessLogic;

namespace Bicicletas.Desktop
{
    public partial class frmClientes : Form
    {
        Cliente _entity = new Cliente();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmClientes(Cliente entity)
        {
            InitializeComponent();
            _entity = entity;

           
            textBoxNombre.Text = entity.Nombres;
            textBoxApellido.Text = entity.Apellidos;
            textBoxTelefono.Text = entity.Telefono.ToString();
            textBoxDirecion.Text = entity.Direccion;
            textBoxDUI.Text = entity.DUI.ToString();
            textBoxCorreo.Text = entity.Correo;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cliente entity = new Cliente()
            {
                
                Nombres = textBoxNombre.Text.Trim(),
                Apellidos = textBoxApellido.Text.Trim(),
                DUI = textBoxDUI.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                Direccion = textBoxDirecion.Text.Trim(),
                Correo = textBoxCorreo.Text.Trim(),
            };

            

            this.Close();

            

            

        }
        public bool vacio;
        private void validar(Form formulario)
        {
            foreach (Control oControls in formulario.Controls)
            {
                if (oControls is TextBox & oControls.Text == String.Empty)
                {
                    vacio = true;
                }
            }
            if (vacio == true)
            {
                MessageBox.Show("Favor de llenar todos los campos.");
            }
            else
            {

            }

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
