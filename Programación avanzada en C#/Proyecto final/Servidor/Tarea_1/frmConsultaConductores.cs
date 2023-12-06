using LogicaTarea;
using LogicaTarea.Conductores;
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
    public partial class frmConsultaConductores : Form
    {
        AccesoDatosConductor accesoDatosConductor;
        public frmConsultaConductores()
        {
            InitializeComponent();
            accesoDatosConductor=new AccesoDatosConductor();
        }

        private void frmConsultaConductores_Load(object sender, EventArgs e)
        {
            List<Conductor> listaConductores = new List<Conductor>();
            listaConductores = accesoDatosConductor.ObtenerConductores();
            dtgvConductores.DataSource = listaConductores;
            //formato Tablas terminal                      
           dtgvConductores.Columns["NUM_CEDULA"].HeaderText = "Número cedula";
           dtgvConductores.Columns["NOM_NOMBRE"].HeaderText = "Nombre";
           dtgvConductores.Columns["NOM_APELLIDO_1"].HeaderText = "Primer apellido";
           dtgvConductores.Columns["NOM_APELLIDO_2"].HeaderText = "Segunda apellido";
           dtgvConductores.Columns["FEC_NACIMIENTO"].HeaderText = "Fecha nacimiento";
           dtgvConductores.Columns["TIP_GENERO"].HeaderText = "Genero";
            dtgvConductores.Columns["BIT_SUPERVISOR"].HeaderText = "Supervisor";
        }
    }
}
