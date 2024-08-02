using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocioo;
using CapaEntidadd;
namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
             List<Usuarios> listado = new CN_Usuario().Listar();

            Usuarios usuarios = new CN_Usuario().Listar().Where(u => u.Documento == txtDocumento.Text && u.Clave == txtContraseña.Text).FirstOrDefault();

            if (usuarios != null)
            {
                Inicio inicio = new Inicio();

                inicio.Show();



                this.Hide();

                inicio.FormClosing += frm_Closing;
            }
            else
            {
                MessageBox.Show("No existe pelotudo","Mensaje", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }



        }


        private void frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtContraseña.Text = "";
            this.Show();

        }

    }
}
