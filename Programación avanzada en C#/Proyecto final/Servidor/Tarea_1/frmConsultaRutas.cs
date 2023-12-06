using LogicaTarea.Conductores;
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
using LogicaTarea.Rutas;

namespace Tarea_1
{
    public partial class frmConsultaRutas : Form
    {
        AccesoDatosRuta accesoDatosRuta;
        public frmConsultaRutas()
        {
            InitializeComponent();
            accesoDatosRuta = new AccesoDatosRuta();
        }

        private void frmConsultaRutas_Load(object sender, EventArgs e)
        {
            
            List<ConsultaRutas> listaRutas = new List<ConsultaRutas>();
            listaRutas = accesoDatosRuta.ObtenerRuta();
            dtgvRutas.DataSource = listaRutas;
            
            FormatoTabla();
            

        }
        private void FormatoTabla()
        {
            dtgvRutas.Columns["NUM_RUTA_SALIDA"].HeaderText = "ID ruta";
            dtgvRutas.Columns["COD_TERMINAL_SALIDA"].HeaderText = "ID terminal salida";
            dtgvRutas.Columns["NOM_TERMINAL_SALIDA"].HeaderText = "Terminal de salida";
            dtgvRutas.Columns["DIR_TERMINAL_SALIDA"].HeaderText = "Dirección terminal salida";
            dtgvRutas.Columns["NUM_TELEFONO_SALIDA"].HeaderText = "Numero telefono salida";
            dtgvRutas.Columns["TIM_HORA_APERTURA_SALIDA"].HeaderText = "Hora de apertura";
            dtgvRutas.Columns["TIM_HORA_CIERRE_SALIDA"].HeaderText = "Hora de cierre";
            dtgvRutas.Columns["BOL_ESTADO_SALIDA"].HeaderText = "Estado";
            
            dtgvRutas.Columns["COD_TERMINAL_LLEGADA"].HeaderText = "ID terminal llegada";
            dtgvRutas.Columns["NOM_TERMINAL_LLEGADA"].HeaderText = "Terminal de llegada";
            dtgvRutas.Columns["DIR_TERMINAL_LLEGADA"].HeaderText = "Dirección terminal llegada";
            dtgvRutas.Columns["NUM_TELEFONO_LLEGADA"].HeaderText = "Numero telefono llegada";
            dtgvRutas.Columns["TIM_HORA_APERTURA_LLEGADA"].HeaderText = "Hora de apertura";
            dtgvRutas.Columns["TIM_HORA_CIERRE_LLEGADA"].HeaderText = "Hora de cierre";
            dtgvRutas.Columns["BOL_ESTADO_LLEGADA"].HeaderText = "Estado";
            
            dtgvRutas.Columns["NUM_TARIFA"].HeaderText = "Tarifa";
            dtgvRutas.Columns["DSC_RUTA"].HeaderText = "Descripción ruta";
            dtgvRutas.Columns["NUM_TIPO_RUTA"].HeaderText = "Tipo ruta";
            dtgvRutas.Columns["BOL_ESTADO"].HeaderText = "Estado";

            
            
            
        }
    }
}
