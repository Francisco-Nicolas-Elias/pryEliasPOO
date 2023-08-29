using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEliasPOO
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearPersonaje_Click(object sender, EventArgs e)
        {
            //llamamos clase
            //objeto seria el personaje

            ClassPersonaje objeto = new ClassPersonaje();

            objeto.nombre = txtNombre.Text;
            objeto.fuerza = Convert.ToInt32(txtFuerza.Text);
            objeto.destreza = Convert.ToInt32(txtDestreza.Text);

            lblMostrarDatos.Text = objeto.nombre + "\n" + objeto.fuerza + "\n" + objeto.destreza + "\n";

            txtNombre.Clear();
            txtFuerza.Clear();
            txtDestreza.Clear();
            
        }
    }
}
