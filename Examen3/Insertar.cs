using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Examen3
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
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
            bool f = datos.command("insert into Productos(ProductoID,Nombre,Descripcion,Precio,Stock,FechaIngreso)"
            + "values ('" + id + "','" + lname + "','" + fndescripcion + "','" + precio + "','" + stock + "','" + fechaing + "');");

            if (f)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
