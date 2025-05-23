using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen3
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void actualizarGrid()
        {
            Datos datos = new Datos();
            DataSet ds = datos.query("SELECT ProductoID AS 'ID', Nombre AS 'Nombre', Descripcion AS 'Descripción', Precio AS 'Precio ($)', Stock AS 'Stock Disponible', FechaIngreso AS 'Fecha de Ingreso' FROM Productos;");
            if (ds != null)
            {
                dgvInventario.DataSource = ds.Tables[0];
            }
        }
        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar modificar = new Modificar(
              dgvInventario[0, e.RowIndex].Value.ToString(),
              dgvInventario[1, e.RowIndex].Value.ToString(),
              dgvInventario[2, e.RowIndex].Value.ToString(),
              dgvInventario[3, e.RowIndex].Value.ToString(),
              dgvInventario[4, e.RowIndex].Value.ToString(),
              dgvInventario[5, e.RowIndex].Value.ToString()

          );
            modificar.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            Insertar insertar = new Insertar();
            insertar.ShowDialog();
        }

        private void Inventario_Activated(object sender, EventArgs e)
        {
            actualizarGrid();
        }
    }
   
}
