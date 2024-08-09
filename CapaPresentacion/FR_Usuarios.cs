using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaNegocioo;
using CapaEntidadd;
using System.Windows.Controls;

namespace CapaPresentacion
{
    public partial class FR_Usuarios : Form
    {
        public FR_Usuarios()
        {
            InitializeComponent();
        }


        private void FR_Usuarios_Load(object sender, EventArgs e)
        {

            cbxEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbxEstado.Items.Add(new OpcionCombo() { Valor = 2, Texto = "No Activo" });
            cbxEstado.DisplayMember = "Texto";
            cbxEstado.ValueMember = "Valor";
            cbxEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().listarRol();

            foreach (Rol item in listaRol)
            {
                cbxRol.Items.Add(new OpcionCombo() { Valor= item.IdRol, Texto= item.Descripcion });
                
            }
            cbxRol.DisplayMember = "Texto";
            cbxRol.ValueMember = "Valor";
            cbxRol.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cbxBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbxBusqueda.DisplayMember = "Texto";
            cbxBusqueda.ValueMember = "Valor";
            cbxBusqueda.SelectedIndex = 0;


            List<Usuarios> listaUsuarios = new CN_Usuario().Listar();

            foreach (Usuarios usuario in listaUsuarios)
            {
                dgvData.Rows.Add(new object[] {"",usuario.IdUsuarios,usuario.Documento, usuario.nombreCompleto, usuario.Correo,usuario.Clave,
                     usuario.oRol.IdRol ,usuario.oRol.Descripcion, usuario.Estado == true ? 1 : 0, usuario.Estado == true ? "Activo": "No activo" });

            }

        } 

        private void LlenandoDGV()
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Add(new object[] {"",txtIdUsurario.Text,txtDocumento.Text,txtNombreCompleto.Text, txtCorreo.Text, txtClave.Text,
            ((OpcionCombo)cbxRol.SelectedItem).Valor.ToString(),((OpcionCombo)cbxRol.SelectedItem).Texto.ToString(),
            ((OpcionCombo)cbxEstado.SelectedItem).Valor.ToString(),((OpcionCombo)cbxEstado.SelectedItem).Texto.ToString()
            });

            Limpiar();
        }

        private void Limpiar()
        {
            txtIdUsurario.Text = "0";
            txtDocumento.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            cbxRol.SelectedIndex = 0;   
            cbxEstado.SelectedIndex = 0;    
        }
    }
}
