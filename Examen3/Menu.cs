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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1 cristal = new Form1();
            cristal.Show();
        }
    }
}
