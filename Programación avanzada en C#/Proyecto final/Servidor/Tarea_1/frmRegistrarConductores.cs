using LogicaTarea;
using LogicaTarea.Conductores;
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
    public partial class frmRegistrarConductores : Form
    {
        
        AccesoDatosConductor accesoDatosConductor;
        public frmRegistrarConductores()
        {
            InitializeComponent();
            accesoDatosConductor = new AccesoDatosConductor();
        }
        private void AgregarConductor() //metodo para agregar el conductor
        {
            



            if (dtaNacimiento.Value.AddYears(18) < DateTime.Today)//para evitar que se agregue un conductor menor de edad
            {
                Conductor nuevoConductor = new Conductor();
                nuevoConductor.NUM_CEDULA = txtIDConductor.Text;
                nuevoConductor.NOM_NOMBRE = txtNombreConductor.Text;
                nuevoConductor.NOM_APELLIDO_1 = txtPrimerApellido.Text;
                nuevoConductor.NOM_APELLIDO_2 = txtSegundoApellido.Text;
                string fechaNacimiento = dtaNacimiento.Text;
                nuevoConductor.FEC_NACIMIENTO = DateTime.Parse(fechaNacimiento);
                nuevoConductor.TIP_GENERO = char.Parse(cbxGenero.Text);
                nuevoConductor.BIT_SUPERVISOR = cbSupervisor.Checked;
                
                    accesoDatosConductor.AgregarConductor(nuevoConductor); //metodo que agrega el conductor a la base de datos, se le pasa por parametro el objeto que se creo con los campos
                    txtIDConductor.Clear();                                // de texto
                    txtNombreConductor.Clear();
                    txtPrimerApellido.Clear();
                    txtSegundoApellido.Clear();
                MessageBox.Show("El conductor se ha registrado correctamente", "Completado");

            }
            else
            {
                MessageBox.Show("El conductor debe ser mayor de edad", "Error");
            }
        }

        private void btnRegistrarConductor_Click(object sender, EventArgs e)
        {

              //validacion para envitar que deje campos vacios o que se produzca una exepción
            try
            {
                if (!txtIDConductor.Text.Equals("") && !txtNombreConductor.Text.Equals("") && !txtPrimerApellido.Text.Equals("") && !txtSegundoApellido.Text.Equals("")&&!cbxGenero.SelectedIndex.Equals(""))
                {
                    AgregarConductor();
                    

                }
                else
                {
                    MessageBox.Show("No deben quedar espacios vacios", "Error");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, verifique si la identificación ha sido registrada previamente");
            }
        }

        private void frmRegistrarConductores_Load(object sender, EventArgs e)
        {
            cbxGenero.SelectedIndex=0;
        }

        private void txtIDConductor_TextChanged(object sender, EventArgs e)
        {
            txtIDConductor.MaxLength = 15;
        }
    }
}
