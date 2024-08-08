using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidadd;
using CapaNegocioo;
using FontAwesome.Sharp;


namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio(Usuarios usuario = null)
        {
            if (usuario == null) 
            {
                _Usuario = new Usuarios() { nombreCompleto = "El Nulo", IdUsuarios = 1 };
            }
            else
            {
                _Usuario = usuario;

            }

            InitializeComponent();
        }

        private static Usuarios _Usuario;
        private static IconMenuItem _MenuActivo = null;
        private static Form _FormularioActivo = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Permiso> permisos = new CN_Permiso().Listar(_Usuario.IdUsuarios);

            foreach (IconMenuItem menuItem in menu.Items)
            {
                bool encontrado = permisos.Any(m => m.NombreMenu == menuItem.Name);
                if (encontrado == false)
                {
                     menuItem.Visible = false;
                }
            }


            lblNombreUsuario.Text = _Usuario.nombreCompleto.ToString(); 
        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormularios(IconMenuItem menu, Form formulario)
        {

            if (_MenuActivo != null)
            {
                _MenuActivo.BackColor = Color.White;

            }
            menu.BackColor = Color.Silver;
            _MenuActivo = menu;
            if (_FormularioActivo != null)
            {
                _FormularioActivo.Close();
            }

            _FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.BackColor = Color.SteelBlue;
            formulario.Dock = DockStyle.Fill;

            panelnicio.Controls.Add(formulario);
            formulario.Show();

        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularios((IconMenuItem)sender, new FR_Usuarios());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularios(menumantenedor, new FR_Categoria());
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormularios(menumantenedor, new FR_Producto());

        }
        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularios(menuventas, new FR_Ventas());


        }
        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularios(menuventas, new FR_DetalleVenta());
        }


        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormularios(menucompras, new FR_Compras());
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormularios(menucompras, new FR_DetalleCompra());

        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios((IconMenuItem)sender, new FR_Clientes());

        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularios(menucompras, new FR_Proveedores());

        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularios(menucompras, new FR_Reportes());

        }
    }
}
