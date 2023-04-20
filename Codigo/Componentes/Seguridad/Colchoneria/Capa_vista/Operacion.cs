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
    public partial class Operacion : Form
    {
        public Operacion()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1003";
            navegador1.actual = this;
            navegador1.tabla = dgv;
            TextBox[] Grupotextbox = { txt, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6};
            TextBox[] Idtextbox = { txt, textBox1 };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dgv, Grupotextbox, "colchoneria");
        }
    }
}
