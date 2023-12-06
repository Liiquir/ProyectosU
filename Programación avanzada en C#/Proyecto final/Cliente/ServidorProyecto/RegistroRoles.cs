using ProyectoServidor.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorProyecto
{
    public partial class RegistroRoles : Form
    {
        public RegistroRoles()
        {
            InitializeComponent();
        }

        private void btnResgitrarRoles_Click(object sender, EventArgs e)
        {

        }
        //public void Actualizarcbx()
        //{
        //    cbxConductorRoles.Items.Clear();
        //    foreach (Conductor ct in metodosConductor.conductores)
        //    {
        //        if (ct != null)
        //        {
        //            if (ct.ConductorSupervisor)
        //            {

        //            }
        //            else
        //            {
        //                cbxConductorRoles.Items.Add(ct.Identificacion);
        //            }

        //        }
        //    }
        //    cbxIDAutobusRoles.Items.Clear();
        //    foreach (frmAutobus at in metodosAutobus.autobuses)
        //    {
        //        if (at != null)
        //        {
        //            cbxIDAutobusRoles.Items.Add(at.Identificacion);
        //        }
        //    }
        //    cbxIdRutaRoles.Items.Clear();//cada vez que se ejecute este metodo de agregarRuta(); se debe limpiar el combo box y volverlo a llenar nuevamente
        //                                 //ya que si no lo hacia este se acumulaban los datos viejos con los nuevo pero duplicando los viejos
        //    foreach (Ruta rt in metodosRuta.rutas)
        //    {
        //        if (rt != null)
        //        {
        //            cbxIdRutaRoles.Items.Add(rt.id);
        //        }
        //    }
        //}
        //private void AgregarRol()//metodo para agregar el rol
        //{
        //    DateTime fechaRol = dtpFechaRoles.Value;
        //    DateTime horaSalida = dtpHoraSalidaRoles.Value;
        //    frmRuta idRuta = metodosRuta.ExisteRuta(int.Parse(cbxIdRutaRoles.Text));
        //    frmAutobus idAutobus = metodosAutobus.ExisteAutobus(int.Parse(cbxIDAutobusRoles.Text));
        //    Conductor idConductor = metodosConductor.Conductor(cbxConductorRoles.Text);
        //    DateTime FechaActual = DateTime.Now;
        //    FechaActual = FechaActual.AddDays(+1);
        //    if (dtpFechaRoles.Value.CompareTo(FechaActual) > 0)
        //    {
        //        metodosRol.RegistrarRoles(fechaRol, horaSalida, idRuta, idAutobus, idConductor);
        //        MessageBox.Show("El rol se ha registrado correctamente", "Completado");
        //        dtgvRoles.Rows.Clear();
        //        foreach (Rol tabla in metodosRol.roles)
        //        {
        //            if (tabla != null)
        //            {
        //                dtgvRoles.Rows.Add(tabla.fecha.ToString("dd/MM/yyyy"), tabla.horaSalida.ToString("HH:mm"), tabla.idRuta, tabla.idRuta.tarifa, tabla.idRuta.descripcionRuta, tabla.idRuta.tipoRuta == 1 ? "Directo" : "Regular", tabla.idRuta.estado,
        //                    tabla.idRuta.Salida.NombreTerminal, tabla.idRuta.Salida.DireccionTerminal, tabla.idRuta.Salida.HoraApertura.ToString("HH:mm"), tabla.idRuta.Salida.HoraCierre.ToString("HH:mm"), tabla.idRuta.Llegada.NombreTerminal,
        //                    tabla.idRuta.Llegada.DireccionTerminal, tabla.idRuta.Llegada.HoraApertura.ToString("HH:mm"), tabla.idRuta.Llegada.HoraCierre.ToString("HH:mm"), tabla.conductor.Identificacion, tabla.conductor.Nombre, tabla.idAutoBus.IdPlaca,
        //                    tabla.idAutoBus.Marca, tabla.idAutoBus.Capacidad);


        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Para registrar un rol se debe hacer con al menos dos días de antelación", "Error");

        //    }

        //}

        //private void btnResgitrarRoles_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!cbxIdRutaRoles.Text.Equals("") && !cbxIDAutobusRoles.Text.Equals("") && !cbxConductorRoles.Text.Equals(""))
        //        {
        //            AgregarRol();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Debe seleccionar todos los datos", "Error");
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Ha ocurrido", "Error");
        //    }
        //}
    }
}
