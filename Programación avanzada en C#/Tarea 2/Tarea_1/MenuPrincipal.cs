using LogicaTarea;
using LogicaTarea.Autobuses;
using LogicaTarea.Conductores;
using LogicaTarea.Roles;
using LogicaTarea.Rutas;
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
    public partial class MenuPrincipal : Form
    {
        static MetodosTerminal metodosTerminal;
        static MetodosConductor metodosConductor;
        static MetodosAutobus metodosAutobus;
        static MetodosRuta metodosRuta;
        static MetodosRol metodosRol;
        
        private int idTerminal { get; set; }
        private int idAutobus { get; set; }
        private int idRuta { get; set; }
        public MenuPrincipal()
        {
            
            InitializeComponent();
            
            metodosTerminal = new MetodosTerminal();
            metodosConductor = new MetodosConductor();
            metodosAutobus = new MetodosAutobus();
            metodosRuta = new MetodosRuta(metodosTerminal);
            metodosRol=new MetodosRol(metodosRuta,metodosAutobus,metodosConductor);
            
            Formatos();
            
            

        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MenuPrincipal());

            
        }
        private void AgregarTerminal()
        {
            string Nombre = txtNombreTerminal.Text;
            string Direccion = txtDireccionTerminal.Text;
            string Telefono = txtTelefonoTerminal.Text;
            string Apertura = DTAApertura.Text;
            DateTime HoraApertura = DateTime.ParseExact(Apertura,"HH:mm",null);
            string Cierre=DTACierre.Text;
            DateTime HoraCierre = DateTime.ParseExact(Cierre, "HH:mm", null);
            bool estado=true;
            string estados = cbxEstado.Text;
            estado = estados.ToLower().Equals("activo") ? true : false;
            metodosTerminal.RegistrarTerminal(idTerminal, Nombre, Direccion, Telefono, HoraApertura, HoraCierre, estado);
            MessageBox.Show("La terminal se ha registrado correctamente", "Completado");
            cbxTerminalSalida.Items.Clear();
            cbxTerminalLlegada.Items.Clear();
            txtNombreTerminal.Clear();
            txtDireccionTerminal.Clear();
            txtTelefonoTerminal.Clear();
            foreach (Terminal tc in metodosTerminal.terminales)
            {
                if (tc != null)
                {


                    cbxTerminalSalida.Items.Add(tc.NombreTerminal);
                    cbxTerminalLlegada.Items.Add(tc.NombreTerminal);
                }
            }
            idTerminal++;
            txtIDTerminal.Text = idTerminal.ToString();
            


        }
        private void AgregarConductor()//metodo para agregar el conductor
        {
            string identificacion = txtIDConductor.Text;
            string nombre = txtNombreConductor.Text;
            string primerApellido = txtPrimerApellido.Text;
            string segundoApellido = txtSegundoApellido.Text;
            DateTime Nacimiento = dtaNacimiento.Value;
            char genero = char.Parse(cbxGenero.Text);
            bool ConductorSupervisor = cbSupervisor.Checked;
            
            if (dtaNacimiento.Value.AddYears(18)<DateTime.Today)
            {
                if (metodosConductor.ExisteConductor(identificacion))
                {
                    metodosConductor.RegistrarConductor(identificacion, nombre, primerApellido, segundoApellido, Nacimiento, genero, ConductorSupervisor);
                    MessageBox.Show("El conductor se ha registrado correctamente", "Completado");
                    cbxConductorRoles.Items.Clear();
                    foreach (Conductor ct in metodosConductor.conductores)
                    {
                        if (ct != null)
                        {
                            if (ct.ConductorSupervisor)
                            {

                            }
                            else
                            {
                                cbxConductorRoles.Items.Add(ct.Identificacion);
                            }

                        }
                    }
                    txtIDConductor.Clear();
                    txtNombreConductor.Clear();
                    txtPrimerApellido.Clear();
                    txtSegundoApellido.Clear();
                }


                else
                {
                    MessageBox.Show("La identificación ingresa ya ha sido registrada previamente", "Error");

                }
            }
            else
            {
                MessageBox.Show("El conductor debe ser mayor de edad", "Error");
            }
            
            
        }
       
        private void AgregarAutobus()//metodo para agregar el autobus
        {
            string idPlaca=txtIdPlaca.Text;
            string Marca = txtMarca.Text;
            string Modelo = txtModelo.Text;
            int capacidad = int.Parse(txtCapacidad.Text);
            bool estado;
            string estados = cbxEstadoAutobus.Text;
            estado= estados.ToLower().Equals("activo") ? true : false;
            
            if (metodosAutobus.ExistePlaca(idPlaca))
            {
                metodosAutobus.RegistrarAutobus(idAutobus, idPlaca, Marca, Modelo, capacidad, estado);
                //metodos para cargar los combo box
                //idea obtenida de https://stackoverflow.com/questions/20344378/populate-combobox-from-a-list
                MessageBox.Show("El autobus se ha registrado correctamente", "Completado");
                cbxIDAutobusRoles.Items.Clear();
                txtIdPlaca.Clear();
                txtMarca.Clear();
                txtModelo.Clear();
                txtCapacidad.Clear();
                foreach (Autobus at in metodosAutobus.autobuses)
                {
                    if (at != null)
                    {
                        cbxIDAutobusRoles.Items.Add(at.Identificacion);
                    }
                }
                idAutobus++;
                txtIdAutobus.Text = idAutobus.ToString();
                
            }
            else
            {
                MessageBox.Show("La placa ingresa ya ha sido registrada previamente", "Error");
            }
            
        }
        private void AgregarRuta()//metodo para agregar el rol
        {
            Terminal terminalSalida = metodosTerminal.ExisteTerminal(int.Parse(txtIdTerminalSalida.Text));
            Terminal terminalLlegada = metodosTerminal.ExisteTerminal(int.Parse(txtIdTerminalLlegada.Text));

            Double tarifa = double.Parse(txtTarifa.Text);
            string descripcion = txtDescripcionRuta.Text;
            int tipoRuta;
            string ruta=cbxTipoRuta.Text;
            tipoRuta = ruta.ToLower().Equals("directo") ? 1 : 2;
            bool estado;
            string estados = cbxEstadoRuta.Text;
            estado = estados.ToLower().Equals("activo") ? true : false;
            metodosRuta.RegistrarRutas(idRuta, terminalSalida, terminalLlegada, tarifa, descripcion, tipoRuta, estado);
            MessageBox.Show("La ruta se ha registrado correctamente", "Completado");
            idRuta++;
            txtIdRuta.Text = idRuta.ToString();
            cbxIdRutaRoles.Items.Clear();//cada vez que se ejecute este metodo de agregarRuta(); se debe limpiar el combo box y volverlo a llenar nuevamente
                                         //ya que si no lo hacia este se acumulaban los datos viejos con los nuevo pero duplicando los viejos
            txtTarifa.Clear();
            txtDescripcionRuta.Clear();
            foreach (Ruta rt in metodosRuta.rutas)
            {
                if (rt != null)
                {
                    cbxIdRutaRoles.Items.Add(rt.id);
                }
            }
            

        }
        private void AgregarRol()//metodo para agregar el rol
        {
            DateTime fechaRol = dtpFechaRoles.Value;
            DateTime horaSalida = dtpHoraSalidaRoles.Value;
            Ruta idRuta = metodosRuta.ExisteRuta(int.Parse(cbxIdRutaRoles.Text));
            Autobus idAutobus = metodosAutobus.ExisteAutobus(int.Parse(cbxIDAutobusRoles.Text));
            Conductor idConductor=metodosConductor.Conductor(cbxConductorRoles.Text);
            DateTime FechaActual = DateTime.Now;
            FechaActual = FechaActual.AddDays(+1);
            if (dtpFechaRoles.Value.CompareTo(FechaActual) > 0)
            {
                metodosRol.RegistrarRoles(fechaRol, horaSalida, idRuta, idAutobus, idConductor);
                MessageBox.Show("El rol se ha registrado correctamente", "Completado");
                dtgvRoles.Rows.Clear();
                foreach (Rol tabla in metodosRol.roles)
                {
                    if (tabla!=null)
                    {   
                        dtgvRoles.Rows.Add(tabla.fecha.ToString("dd/MM/yyyy"), tabla.horaSalida.ToString("HH:mm"), tabla.idRuta, tabla.idRuta.tarifa, tabla.idRuta.descripcionRuta, tabla.idRuta.tipoRuta == 1 ? "Directo" : "Regular", tabla.idRuta.estado,
                            tabla.idRuta.Salida.NombreTerminal, tabla.idRuta.Salida.DireccionTerminal, tabla.idRuta.Salida.HoraApertura.ToString("HH:mm"), tabla.idRuta.Salida.HoraCierre.ToString("HH:mm"), tabla.idRuta.Llegada.NombreTerminal,
                            tabla.idRuta.Llegada.DireccionTerminal, tabla.idRuta.Llegada.HoraApertura.ToString("HH:mm"), tabla.idRuta.Llegada.HoraCierre.ToString("HH:mm"), tabla.conductor.Identificacion, tabla.conductor.Nombre, tabla.idAutoBus.IdPlaca,
                            tabla.idAutoBus.Marca, tabla.idAutoBus.Capacidad);
                        
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Para registrar un rol se debe hacer con al menos dos días de antelación", "Error");

            }

        }
      
         //metodos de los botones
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNombreTerminal.Text.Equals("") && !txtDireccionTerminal.Text.Equals("") && !txtDireccionTerminal.Text.Equals("") && !txtTelefonoTerminal.Text.Equals(""))
                {
                    AgregarTerminal();
                    dtgvTerminales.DataSource = metodosTerminal.terminales;
                    
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
        

        private void btnRegistrarConductor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtIDConductor.Text.Equals("")&&!txtNombreConductor.Text.Equals("")&&!txtPrimerApellido.Text.Equals("")&&!txtSegundoApellido.Text.Equals(""))
                {
                    AgregarConductor();
                    dtgvConductores.DataSource = metodosConductor.conductores;
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
        private void btnRegistrarAutobus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtIdPlaca.Text.Equals("")&&!txtMarca.Text.Equals("")&&!txtModelo.Text.Equals("")&&!txtCapacidad.Text.Equals(""))
                {
                    AgregarAutobus();
                    dtgvAutobuses.DataSource = metodosAutobus.autobuses;
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cbxTerminalSalida.Text.Equals("") && !cbxTerminalLlegada.Text.Equals("") && !txtTarifa.Text.Equals("") && !txtDescripcionRuta.Equals(""))
                {
                    if (!cbxTerminalSalida.SelectedIndex.Equals(cbxTerminalLlegada.SelectedIndex))
                    {
                        AgregarRuta();
                        dtgvRutas.DataSource = metodosRuta.rutas;
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
        private void btnResgitrarRoles_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cbxIdRutaRoles.Text.Equals("")&&!cbxIDAutobusRoles.Text.Equals("")&&!cbxConductorRoles.Text.Equals(""))
                {
                    AgregarRol();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar todos los datos", "Error");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido", "Error");
            }
            
            
        }
        private void Formatos()//metodo para darle formato a las tablas ya que sin esto me escribia el nombre de las variables que no estaban mal pero las escribia pegadas
            // tal y como fueron escritas
        {   //formato Tablas terminal
            dtgvTerminales.DataSource = metodosTerminal.terminales;            
            dtgvTerminales.Columns["HoraApertura"].DefaultCellStyle.Format = "HH:mm";// esto es para que en la parte de la fecha me escribiera solamente la hora ya que en un 
            dtgvTerminales.Columns["HoraCierre"].DefaultCellStyle.Format = "HH:mm";  //principio me escribia todo con fecha entera y ademas en am y pm con esto ya no
            dtgvTerminales.Columns["IdTerminal"].HeaderText = "ID terminal";
            dtgvTerminales.Columns["NombreTerminal"].HeaderText = "Nombre terminal";
            dtgvTerminales.Columns["DireccionTerminal"].HeaderText = "Dirección terminal";
            dtgvTerminales.Columns["TelefonoTerminal"].HeaderText = "Teléfono terminal";
            dtgvTerminales.Columns["HoraApertura"].HeaderText = "Hora apertura";
            dtgvTerminales.Columns["HoraCierre"].HeaderText = "Hora cierre";
            //formato tabla conductores
            dtgvConductores.DataSource = metodosConductor.conductores;            
            dtgvConductores.Columns["FechaNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvConductores.Columns["Identificacion"].HeaderText = "Identificación";
            dtgvConductores.Columns["PrimerApellido"].HeaderText = "Primer apellido";
            dtgvConductores.Columns["SegundoApellido"].HeaderText = "Segundo apellido";
            dtgvConductores.Columns["FechaNacimiento"].HeaderText = "Fecha nacimiento";
            dtgvConductores.Columns["ConductorSupervisor"].HeaderText = "Conductor supervisor";
            //formato tabla Autobuses
            dtgvAutobuses.DataSource = metodosAutobus.autobuses;
            dtgvAutobuses.Columns["Identificacion"].HeaderText = "Identificación";
            dtgvAutobuses.Columns["IdPlaca"].HeaderText = "ID placa";
            //formato tabla rutas
            dtgvRutas.DataSource=metodosRuta.rutas;
            dtgvRutas.Columns["id"].HeaderText = "ID ruta";
            dtgvRutas.Columns["Salida"].HeaderText = "Terminal de salida";
            dtgvRutas.Columns["Llegada"].HeaderText = "Terminal de llegada";
            dtgvRutas.Columns["tarifa"].HeaderText = "Tarifa";
            dtgvRutas.Columns["descripcionRuta"].HeaderText = "Descripción ruta";
            dtgvRutas.Columns["tipoRuta"].HeaderText = "Tipo ruta";
            dtgvRutas.Columns["estado"].HeaderText = "Estado";
            //formato tabla roles
            dtgvRoles.Columns.Add("Fecha", "Fecha");
            dtgvRoles.Columns.Add("Hora Salida", "Hora Salida");
            dtgvRoles.Columns.Add("Id", "Id");
            dtgvRoles.Columns.Add("Tarifa", "Tarifa");
            dtgvRoles.Columns.Add("Descripción", "Descripción");
            dtgvRoles.Columns.Add("Tipo", "Tipo");
            dtgvRoles.Columns.Add("Estado", "Estado");
            dtgvRoles.Columns.Add("Terminal Salida", "Terminal Salida");
            dtgvRoles.Columns.Add("Dirección", "Dirección");
            dtgvRoles.Columns.Add("Hora Apertura", "Hora Apertura");
            dtgvRoles.Columns.Add("Hora Cierre", "Hora Cierre");
            dtgvRoles.Columns.Add("Terminal Llegada", "Terminal Llegada");
            dtgvRoles.Columns.Add("Dirección", "Dirección");
            dtgvRoles.Columns.Add("Hora Apertura", "Hora Apertura");
            dtgvRoles.Columns.Add("Hora Cierre", "Hora Cierre");
            dtgvRoles.Columns.Add("Identificación", "Identificación");
            dtgvRoles.Columns.Add("Nombre", "Nombre");
            dtgvRoles.Columns.Add("Placa", "Placa");
            dtgvRoles.Columns.Add("Marca", "Marca");
            dtgvRoles.Columns.Add("Capacidad", "Capacidad");
            //formato txt
            idTerminal = metodosTerminal.posicion + 1;
            idAutobus = metodosAutobus.posicion + 1;
            idRuta = metodosRuta.posicion + 1;
            txtIdRuta.Text = idRuta.ToString();
            txtIdAutobus.Text = idAutobus.ToString();
            txtIDTerminal.Text = idTerminal.ToString();
            //formato combo box
            cbxEstado.SelectedIndex = 0;
            cbxEstadoAutobus.SelectedIndex = 0;
            cbxGenero.SelectedIndex = 0;
            cbxEstadoRuta.SelectedIndex=0;
            cbxTipoRuta.SelectedIndex=0;
            
        }      

        private void cbxTerminalSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdTerminalSalida.Text = metodosTerminal.IDterminal(cbxTerminalSalida.Text).ToString();
            

        }

        private void cbxTerminalLlegada_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdTerminalLlegada.Text = metodosTerminal.IDterminal(cbxTerminalLlegada.Text).ToString();
            
            
        }
        private void cbxIdRutaRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTerminalOrigenRoles.Text = metodosRuta.TerminalOrigen(cbxIdRutaRoles.Text).ToString();
            txtTerminalDestinoRoles.Text = metodosRuta.TerminalDestino(cbxIdRutaRoles.Text).ToString();
            txtTarifaRoles.Text=metodosRuta.Tarifa(cbxIdRutaRoles.Text).ToString();
            if (metodosRuta.Tipo(cbxIdRutaRoles.Text)==1)
            {
                txtTipoRoles.Text = "Directo";
            }
            else
            {
                txtTipoRoles.Text = "Regular";
            }

        }
        private void cbxIDAutobusRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                txtPlacaRoles.Text = metodosAutobus.Placa(cbxIDAutobusRoles.Text).ToString();
                txtMarcaRoles.Text = metodosAutobus.Marca(cbxIDAutobusRoles.Text).ToString();
                txtCapacidadRoles.Text = metodosAutobus.Capacidad(cbxIDAutobusRoles.Text).ToString();
            
            
        }
        //metodo para mostrar los mensajes de advertencia al entrar en la seccion de registro de roles
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {   //idea de los eventos del tab page obtenida de  https://stackoverflow.com/questions/9684221/tabpage-click-events
            
            if (e.TabPage==tabPage5)
            {
                if (metodosRuta.rutas[0] == null)
                {
                    MessageBox.Show("Se debe al menos registrar una ruta para incluir los Roles.","Error");
                    if (metodosAutobus.autobuses[0] == null)
                    {
                        MessageBox.Show(" se debe al menos registrar un autobús para incluir los Roles","Error");
                        if (metodosConductor.conductores[0] == null)
                        {
                            MessageBox.Show("Se debe al menos registrar un conductor no supervisor para incluir los Roles.","Error");
                            return;
                        }
                    }
                }
                else
                {
                    if (metodosAutobus.autobuses[0] == null)
                    {
                        MessageBox.Show("Se debe al menos registrar un autobús para incluir los Roles","Error");
                        if (metodosConductor.conductores[0] == null)
                        {
                            MessageBox.Show("Se debe al menos registrar un conductor para incluir los Roles.","Error");
                            
                            return;
                        }
                        //es cierto que esto quedo un poco confuso y feo pero no encontre otra manera de hacerlo que probablemente si hay
                        //pero que en el momento o no se me ocurria o sencillamente no encontraba, al menos esto me funciono
                    }
                    else
                    {
                        if (metodosConductor.conductores[0] == null)
                        {
                            MessageBox.Show("Se debe al menos registrar un conductor para incluir los Roles.","Error");
                        }
                        

                    }
                }
            }
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
