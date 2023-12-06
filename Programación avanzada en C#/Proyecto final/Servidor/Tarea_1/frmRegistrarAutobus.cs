using LogicaTarea.Autobuses;
using LogicaTarea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaTarea.Conductores;

namespace Tarea_1
{
    
    public partial class frmRegistrarAutobus : Form
    {
        
        AccesoDatosAutobus accesoDatosAutobus;
        public frmRegistrarAutobus()
        {
            InitializeComponent();
            
            accesoDatosAutobus = new AccesoDatosAutobus();


        }
        private void AgregarAutobus()//metodo para agregar el autobus
        {
            Autobus nuevoAutobus = new Autobus();
            nuevoAutobus.NUM_IDENTIFICACION = int.Parse(txtIdAutobus.Text);
            nuevoAutobus.NUM_PLACA = txtIdPlaca.Text;
            nuevoAutobus.DSC_MARCA = txtMarca.Text;
            nuevoAutobus.NUM_MODELO = int.Parse(txtModelo.Text);
            nuevoAutobus.NUM_CAPACIDAD = int.Parse(txtCapacidad.Text);

            string estados = cbxEstadoAutobus.Text;
            nuevoAutobus.BOL_ESTADO = estados.ToLower().Equals("activo") ? true : false;
            if (accesoDatosAutobus.validarPlaca(txtIdPlaca.Text) == true) //condicional para validar si la placa existe
            {
                accesoDatosAutobus.AgregarAutobus(nuevoAutobus);
                txtIdAutobus.Text = accesoDatosAutobus.ConsultarID().ToString();
            }
            else
            {
                MessageBox.Show("El numero de placa ya se encuentra registrado", "Error");
            }
            
           



        }

        private void btnRegistrarAutobus_Click(object sender, EventArgs e)
        {    //para evitar que deje espacios vacios y que el programa se caiga
            
                if (!txtIdPlaca.Text.Equals("") && !txtMarca.Text.Equals("") && !txtModelo.Text.Equals("") && !txtCapacidad.Text.Equals(""))
                {
                    AgregarAutobus();
                    
                }
                else
                {
                    MessageBox.Show("No deben quedar espacios vacios", "Error");
                }

            
            
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {    //evitar que escriba numero en la capacidad
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmRegistrarAutobus_Load(object sender, EventArgs e)
        {
            cbxEstadoAutobus.SelectedIndex = 0;
            txtIdAutobus.Text = accesoDatosAutobus.ConsultarID().ToString();
        }

        private void txtIdPlaca_TextChanged(object sender, EventArgs e)
        {
            txtIdPlaca.MaxLength = 10;
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            txtMarca.MaxLength = 30;
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            txtModelo.MaxLength = 4;
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCapacidad_TextChanged(object sender, EventArgs e)
        {
            txtCapacidad.MaxLength = 3;
        }
    }
}
