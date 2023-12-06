using LogicaTarea.Terminales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1
{
    public partial class frmRegistrarTerminales : Form
    {
        
        AccesoDatosTerminal accesoDatosTerminal;
        public frmRegistrarTerminales()
        {
            InitializeComponent();
            
            accesoDatosTerminal = new AccesoDatosTerminal();
            
            
        }
        private void AgregarTerminal() //metodo para agregar las terminales
        {   Terminal nuevaTerminal=new Terminal();
            nuevaTerminal.COD_TERMINAL = int.Parse(txtIdTerminal.Text);
            nuevaTerminal.NOM_TERMINAL = txtNombreTerminal.Text;
            nuevaTerminal.DIR_TERMINAL = txtDireccionTerminal.Text;
            nuevaTerminal.NUM_TELEFONO = txtTelefonoTerminal.Text;
            string Apertura = DTAApertura.Text;
            nuevaTerminal.TIM_HORA_APERTURA = TimeSpan.Parse(Apertura);
            string Cierre = DTACierre.Text;
            nuevaTerminal.TIM_HORA_CIERRE = TimeSpan.Parse(Cierre);
            bool estado = true;
            string estados = cbxEstado.Text;
            nuevaTerminal.BOL_ESTADO = estados.ToLower().Equals("activo") ? true : false;
            accesoDatosTerminal.AgregarTerminal(nuevaTerminal);// este metodo es el que agrega las terminales a la base de datos
            MessageBox.Show("La terminal se ha registrado correctamente", "Completado");            
            txtNombreTerminal.Clear();
            txtDireccionTerminal.Clear();
            txtTelefonoTerminal.Clear();            
           
            



        }

        private void btnRegistrarTerminal_Click(object sender, EventArgs e)
        {
               //validaciones para no dejar los campos en blanco
            try
            {
                if (!txtNombreTerminal.Text.Equals("") && !txtDireccionTerminal.Text.Equals("") && !txtDireccionTerminal.Text.Equals("") && !txtTelefonoTerminal.Text.Equals(""))
                {
                    AgregarTerminal();
                    txtIdTerminal.Text = accesoDatosTerminal.ConsultarID().ToString();

                }
                else
                {
                    MessageBox.Show("No deben quedar espacios vacios", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");

            }
        }

        private void frmRegistrarTerminales_Load(object sender, EventArgs e)
        {
            txtIdTerminal.Text = accesoDatosTerminal.ConsultarID().ToString(); //para asignarle el numero de id a la terminal
            cbxEstado.SelectedIndex = 0;


            
        }

        private void txtTelefonoTerminal_TextChanged(object sender, EventArgs e)
        {
            txtTelefonoTerminal.MaxLength = 8;
        }

        private void txtNombreTerminal_TextChanged(object sender, EventArgs e)
        {
            txtNombreTerminal.MaxLength = 40;
        }

        private void txtDireccionTerminal_TextChanged(object sender, EventArgs e)
        {
            txtDireccionTerminal.MaxLength = 40;
        }
    }
}
