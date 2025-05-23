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
    public partial class Modificar : Form
    {
        public Modificar(string id, string fname, string fndescripcion, string precio, string stock, string fechaing)
        {
            InitializeComponent();
            tbID.Text = id;
            tbnombre.Text = fname;
            tbdescripcion.Text = fndescripcion;
            tbprecio.Text = precio;
            tbstock.Text = stock;
            tbfechaing.Text = fechaing;


        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;
            string lname = tbnombre.Text;
            string fndescripcion = tbdescripcion.Text;
            string precio = tbprecio.Text;
            string stock = tbstock.Text;
            string fechaing = tbfechaing.Text;


            Datos datos = new Datos();
            System.Boolean f = datos.command("UPDATE employee SET " +
                "id='" + id + "', " +
                "lname='" + lname + "', " +
                "descripcion'" + fndescripcion + "', " +
                "precio'" + precio + "', " +
                "stock'" + stock + "', " +
                "fechaing'" + fechaing + "'; " 
            );

            if (f)
            {
                MessageBox.Show("Registro actualizado", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;

            DialogResult r = MessageBox.Show("Seguro que quieres eliminar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.command("delete from employee where  ID='" + id + "';");
                if (f)
                {
                    MessageBox.Show("Registro eliminado", "Sistema", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void Modificar_Load(object sender, EventArgs e)
        {

        }
    }
}
