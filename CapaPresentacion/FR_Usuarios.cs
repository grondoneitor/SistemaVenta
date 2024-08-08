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
    }
}
