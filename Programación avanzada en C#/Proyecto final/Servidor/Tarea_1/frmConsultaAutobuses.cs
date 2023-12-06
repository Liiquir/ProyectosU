using LogicaTarea;
using LogicaTarea.Autobuses;
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
    public partial class frmConsultaAutobuses : Form
    { AccesoDatosAutobus accesoDatosAutobus;
        public frmConsultaAutobuses()
        {
            InitializeComponent();
            accesoDatosAutobus = new AccesoDatosAutobus();
        }

        private void frmConsultaAutobuses_Load(object sender, EventArgs e)
        {
            List<Autobus> listaConductores = new List<Autobus>();
            listaConductores = accesoDatosAutobus.ObtenerAutobus();
            dtgvAutobuses.DataSource = listaConductores;           
            dtgvAutobuses.Columns["NUM_IDENTIFICACION"].HeaderText = "Identificación";
            dtgvAutobuses.Columns["NUM_PLACA"].HeaderText = "ID placa";
            dtgvAutobuses.Columns["DSC_MARCA"].HeaderText = "Marca";
            dtgvAutobuses.Columns["NUM_MODELO"].HeaderText = "Número modelo";
            dtgvAutobuses.Columns["NUM_CAPACIDAD"].HeaderText = "Capacidad";
            dtgvAutobuses.Columns["BOL_ESTADO"].HeaderText = "Estado";
        }
    }
}
