using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;

namespace capaPresentacion
{
    public partial class frmRecuperarContrasenia : Form
    {
        public frmRecuperarContrasenia()
        {
            InitializeComponent();
        }
        clsLogin clsLogin = new clsLogin();

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = clsLogin.recuperarContrasenia(txtCorreo.Text);
        }
    }
}
