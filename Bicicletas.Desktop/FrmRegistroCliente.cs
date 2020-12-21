using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bicicletas.BusinessLogic;
using Bicicletas.Entities;

namespace Bicicletas.Desktop
{
    public partial class FrmRegistroCliente : Form
    {
        List<Cliente> _clientes;
        public FrmRegistroCliente()
        {
            InitializeComponent();
        }

        private void ButtonNCliente_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.ShowDialog();
        }
        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            _clientes = ClienteBL.Instance.SelectAll();
            dataGridView1.DataSource = _clientes;
        }
        private void TextBoxCliente_TextChanged(object sender, EventArgs e)
        {

            var query = _clientes.Where(x => x.Nombres.ToLower().Contains(TextBoxCliente.Text.Trim().ToLower())).ToList();
            dataGridView1.DataSource = query;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                
                string nombre = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string apellido = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string dui = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                string telefono = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                string direccion = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                string correo= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

                Cliente entity = new Cliente() 
                { 
                    
                    Nombres = nombre,
                    Apellidos = apellido,
                    DUI = dui,
                    Telefono = telefono,
                    Direccion = direccion,
                    Correo = correo,
                };


                frmClientes frm = new frmClientes(entity);
                frm.ShowDialog();

            }

            if (dataGridView1.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value;

                DialogResult dr = MessageBox.Show("Realmente desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    EstadoBL.Instance.Delete(id);
                }
            }

            UpdateGrid();
        }

        private void FrmRegistroCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
