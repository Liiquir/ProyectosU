using LogicaTarea.Rutas;
using LogicaTarea;
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
using LogicaTarea.Autobuses;
using System.Data.SqlClient;

namespace Tarea_1
{
    
    public partial class frmRegistrarRuta : Form
    {
       
        AccesoDatosRuta accesoDatosRuta;
        AccesoDatosTerminal accesoDatosTerminal;
        
        public frmRegistrarRuta()
        {
            InitializeComponent();
            accesoDatosRuta = new AccesoDatosRuta();
            
            accesoDatosTerminal=new AccesoDatosTerminal();
        }
        private void AgregarRuta()//metodo para agregar la ruta al objeto ruta
        {
            Ruta nuevaRuta = new Ruta();
                       
            nuevaRuta.NUM_RUTA = int.Parse(txtIdRuta.Text);
            nuevaRuta.COD_TERMINAL_SALIDA = int.Parse(txtIdTerminalSalida.Text);            
            nuevaRuta.COD_TERMINAL_LLEGADA = int.Parse(txtIdTerminalLlegada.Text);
            nuevaRuta.NUM_TARIFA = double.Parse(txtTarifa.Text);
            nuevaRuta.DSC_RUTA = txtDescripcionRuta.Text;
            nuevaRuta.NUM_TIPO_RUTA=cbxTipoRuta.SelectedIndex;          
            string estados = cbxEstadoRuta.Text;
            nuevaRuta.BOL_ESTADO = estados.ToLower().Equals("activo") ? true : false;
            accesoDatosRuta.AgregarRuta(nuevaRuta);//aqui se le pasa todos los datos que se ingresaron en la interfaz y se agrega a la base de datos
            MessageBox.Show("La ruta se ha registrado correctamente", "Completado");                       
            txtTarifa.Clear();
            txtDescripcionRuta.Clear();//para limpiar los campos
            txtIdRuta.Text = accesoDatosRuta.ConsultarID().ToString();//aqui le asigno el numero de ruta a txt



        }
        private void btnRegistrarRuta_Click(object sender, EventArgs e)
        {
            //validaciones para no dejar campos vacios o en caso de algun otro error que el programa no se caiga
            try
            {
                if (!cbxTerminalSalida.Text.Equals("") && !cbxTerminalLlegada.Text.Equals("") && !txtTarifa.Text.Equals("") && !txtDescripcionRuta.Equals(""))
                {
                    if (!cbxTerminalSalida.SelectedIndex.Equals(cbxTerminalLlegada.SelectedIndex))
                    {
                        AgregarRuta();

                    }
                    else
                    {
                        MessageBox.Show("La terminal de salida y llegada no pueden ser las mismas", "Error");
                    }
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
       
        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {    //para evitar que escriba numero en las tarifas
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void frmRegistrarRuta_Load(object sender, EventArgs e)
        {
            try
            {//para que los combobox se carguen al entrar al formulario, el try catch es porque si no hay terminales registradas no se caiga ya que los combo box no tendria nada que cargar
                cbxTerminalLlegada.DataSource = accesoDatosTerminal.CargarTerminales();
                cbxTerminalSalida.DataSource = accesoDatosTerminal.CargarTerminales();
                txtIdRuta.Text = accesoDatosRuta.ConsultarID().ToString();
                cbxTerminalSalida.SelectedIndex = 0;
                cbxTerminalLlegada.SelectedIndex = 0;
                cbxTipoRuta.SelectedIndex = 0;
                cbxEstadoRuta.SelectedIndex=0;
            }
            catch (Exception)
            {

                
            }
            


        }
        
        private void cbxTerminalSalida_SelectedIndexChanged(object sender, EventArgs e)
        {   int idSalida = cbxTerminalSalida.SelectedIndex + 1; //esto es para asignarle el numero de terminal a las cajas de texto        
            txtIdTerminalSalida.Text = idSalida.ToString();     //como van en orden solamente se le asigna de manera ascendente
        }

        private void cbxTerminalLlegada_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idLlegada = cbxTerminalLlegada.SelectedIndex + 1;//esto es para asignarle el numero de terminal a las cajas de texto                                                                                                                                   
            txtIdTerminalLlegada.Text = idLlegada.ToString();    //como van en orden solamente se le asigna de manera ascendente 
        }

        private void txtTarifa_TextChanged(object sender, EventArgs e)
        {
            txtTarifa.MaxLength = 8;
        }
    }
}
