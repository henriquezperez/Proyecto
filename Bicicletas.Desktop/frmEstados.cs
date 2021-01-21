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
    public partial class frmEstados : Form
    {
        List<Estados> _listado;
        public frmEstados()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmNuevoEstado frm = new FrmNuevoEstado();
            frm.ShowDialog();
            UpdateGrid();
        }

        private void FrmEstados_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            _listado = EstadoBL.Instance.SelectAll();
            DataGridView1.DataSource = _listado;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            var query = _listado.Where(x => x.NombreEstado.ToLower().Contains(TextBox1.Text.Trim().ToLower())).ToList();
            DataGridView1.DataSource = query;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                int id = (int)DataGridView1.Rows[e.RowIndex].Cells[2].Value;
                string nombre = DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                Estados entity = new Estados()
                {
                    EstadoId = id,
                    NombreEstado = nombre
                };

                FrmNuevoEstado frm = new FrmNuevoEstado(entity);
                frm.ShowDialog();
               // MessageBox.Show("El registro se Modifico correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (DataGridView1.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = (int)DataGridView1.Rows[e.RowIndex].Cells[2].Value;

                DialogResult dr = MessageBox.Show("Realmente desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    EstadoBL.Instance.Delete(id);
                }
            }

            UpdateGrid();
        }
    }
}
