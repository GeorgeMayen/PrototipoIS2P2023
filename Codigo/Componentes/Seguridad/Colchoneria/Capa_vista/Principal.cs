using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_Seguridad
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Operacion Op = new Operacion();
            Op.Show();
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            Operacion Op = new Operacion();
            Op.Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            Operacion Op = new Operacion();
            Op.Show();
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            Operacion Op = new Operacion();
            Op.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Operacion Op = new Operacion();
            Op.Show();
        }
    }
}
