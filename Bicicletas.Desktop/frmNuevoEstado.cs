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
    public partial class FrmNuevoEstado : Form
    {

        Estados _entity = new Estados();
        public FrmNuevoEstado()
        {
            InitializeComponent();
        }

        public FrmNuevoEstado(Estados entity)
        {
            InitializeComponent();
            _entity = entity;

            textBoxNombre.Text = entity.Nombre;

        }

        private void FrmNuevoEstado_Load(object sender, EventArgs e)
        {
           
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                errorProvider1.SetError(textBoxNombre, "Debe proporcionar un nombre al estado");
            }
            errorProvider1.Clear();

            Estados entity = new Estados() { Nombre = textBoxNombre.Text.Trim() };

            if (_entity.EstadoId > 0)
            {
                entity.EstadoId = _entity.EstadoId;
                if (EstadoBL.Instance.Update(entity))
                {
                    MessageBox.Show("El registro se Modifico correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (EstadoBL.Instance.Insert(entity))
                {
                    MessageBox.Show("El registro se agrego correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Close();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
