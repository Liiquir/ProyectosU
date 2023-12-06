using LogicaTarea.Autobuses;
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

namespace Tarea_1
{
    public partial class frmConsultaTerminales : Form
    {
        AccesoDatosTerminal accesoDatosTerminal;
        public frmConsultaTerminales()
        {
            InitializeComponent();
            accesoDatosTerminal = new AccesoDatosTerminal();
        }

        private void frmConsultaTerminales_Load(object sender, EventArgs e)
        {
            List<Terminal> listaTerminales = new List<Terminal>();
            listaTerminales = accesoDatosTerminal.ObtenerTerminales();
            dtgvTerminales.DataSource = listaTerminales; //para cargar la lista de los datos
            //para darle formato a la                       
            dtgvTerminales.Columns["COD_TERMINAL"].HeaderText = "ID terminal";
            dtgvTerminales.Columns["NOM_TERMINAL"].HeaderText = "Nombre terminal";
            dtgvTerminales.Columns["DIR_TERMINAL"].HeaderText = "Dirección terminal";
            dtgvTerminales.Columns["NUM_TELEFONO"].HeaderText = "Teléfono terminal";
            dtgvTerminales.Columns["TIM_HORA_APERTURA"].HeaderText = "Hora apertura";
            dtgvTerminales.Columns["TIM_HORA_CIERRE"].HeaderText = "Hora cierre";
            dtgvTerminales.Columns["BOL_ESTADO"].HeaderText = "Estado";
        }
    }
}
