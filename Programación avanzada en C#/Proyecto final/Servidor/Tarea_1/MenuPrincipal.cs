using LogicaTarea;
using LogicaTarea.Roles;
using System;
using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Tarea_1
{
    public partial class MenuPrincipal : Form
    {
        EscribirEnTextboxDelegado modificarTextotxtBitacora;
        ModoficarListBoxDelegado modificarListBoxClientes;
        AccesoDatosRol accesoDatos;

        
        Thread subprocesoEscuchaClientes;
        TcpListener tcpListener;
        bool servidorIniciado;
        


        public MenuPrincipal()
        {
            
            InitializeComponent();
            modificarTextotxtBitacora = new EscribirEnTextboxDelegado(EscribirEnTextbox);
            modificarListBoxClientes = new ModoficarListBoxDelegado(ModificarListBox);
            accesoDatos= new AccesoDatosRol();
            



        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MenuPrincipal());

            
        }
        private delegate void EscribirEnTextboxDelegado(string texto);
        private delegate void ModoficarListBoxDelegado(string texto, bool agregar);
        private void EscribirEnTextbox(string texto)
        {
            txtBitacora.AppendText(DateTime.Now.ToString() + " - " + texto);
            txtBitacora.AppendText(Environment.NewLine);
        }
       



        private void ModificarListBox(string texto, bool agregar)
        {
            if (agregar)
            {
                lstClientesConectados.Items.Add(texto);
            }
            else
            {
                lstClientesConectados.Items.Remove(texto);
            }

        }



        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 14100);
            servidorIniciado = true;

            subprocesoEscuchaClientes = new Thread(new ThreadStart(EscucharClientes));
            subprocesoEscuchaClientes.Start();
            subprocesoEscuchaClientes.IsBackground = true;
            lblEstado.Text = "Escuchando clientes... en (127.0.0.1, 14100)";
            lblEstado.ForeColor = Color.Green;
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;

            txtBitacora.Text = "Servidor iniciado... en (127.0.0.1, 14100)";
            txtBitacora.AppendText(Environment.NewLine);
        }
        private void EscucharClientes()
        {
            tcpListener.Start();
            try
            {
                while (servidorIniciado)
                {
                    //Se bloquea hasta que un cliente se haya conectado al servidor 
                    TcpClient client = tcpListener.AcceptTcpClient();
                    /*Se crea un nuevo hilo para manejar la comunicación con los clientes que se conectan al servidor*/
                    Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    clientThread.Start(client);
                }
            }
            catch (Exception)
            {
                return;
            }

        }
        private void ComunicacionCliente(object cliente)
        {
            TcpClient tcCliente = (TcpClient)cliente;
            StreamReader reader = new StreamReader(tcCliente.GetStream());
            StreamWriter servidorStreamWriter = new StreamWriter(tcCliente.GetStream());//El StreamWriter debe ser único por subproceso y por cliente por eso se pasa por referencia

            while (servidorIniciado)
            {

                try
                {
                    /*Esta sección se bloquea hasta que el cliente envíe unmensaje*/
                    var mensaje = reader.ReadLine();
                    MensajeSocket<object> mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensaje);//Se deserializa el objeto recibido mediante json
                    SeleccionarMetodo(mensajeRecibido.Metodo, mensaje, ref servidorStreamWriter);
                }
                catch (Exception e)
                {
                    //Ocurrió un error en el socket 
                    break;
                }
            }

            tcCliente.Close();
        }
        public void SeleccionarMetodo(string pMetodo, string pMensaje, ref StreamWriter servidorStreamWriter)
        {
            switch (pMetodo)      //esto es tambien para cuado se presiona un boton en el cliente
                                  //aqui deberia ir tambien los casos de los registros de roles y consulta de roles
                                  //que no llegue a completar
            {
                case "Conectar":
                    MensajeSocket<string> mensajeConectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    Conectar(mensajeConectar.Entidad);
                    break;
                
                case "Desconectar":
                    MensajeSocket<string> mensajeDesconectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    Desconectar(mensajeDesconectar.Entidad);
                    break;
                default:
                    break;
            }


        }
        private void Conectar(string pIdentificadorCliente)  //el metodo para conectar que tambien modifica el texto
        {
            //obtenido de los ejempplos de las tutorias
            txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { pIdentificadorCliente + " se ha conectado..." });
            lstClientesConectados.Invoke(modificarListBoxClientes, new object[] { pIdentificadorCliente, true });

        }
        private void Desconectar(string pIdentificadorCliente)
        {     //el metodo para conectar que tambien modifica el texto           
                //obtenido de los ejempplos de las tutorias
                txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { pIdentificadorCliente + " se ha desconectado!" });
            lstClientesConectados.Invoke(modificarListBoxClientes, new object[] { pIdentificadorCliente, false });
        }
        private void btnDetener_Click(object sender, EventArgs e)
        {   //la accion que hace el boton detener del servidor
            servidorIniciado = false;
            tcpListener.Stop();
            btnDetener.Enabled = false;
            lblEstado.ForeColor = Color.Red;
            lblEstado.Text = "Sin iniciar";
            btnIniciar.Enabled = true;
            
            txtBitacora.Text = "Servidor detenido...";
        }

        // los metodos de abajo son para abrir los formularios cuando se presiona el boton correspondiente
        private void btnRegistrarTerminales_Click(object sender, EventArgs e)
        {
            frmRegistrarTerminales formularioRegistrarTerminal = new frmRegistrarTerminales();
            formularioRegistrarTerminal.StartPosition = FormStartPosition.CenterScreen;
            formularioRegistrarTerminal.ShowDialog();
        }

        private void btnRegistrarConductores_Click(object sender, EventArgs e)
        {
            frmRegistrarConductores formularioRegistrarConductor = new frmRegistrarConductores();
            formularioRegistrarConductor.StartPosition = FormStartPosition.CenterScreen;
            formularioRegistrarConductor.ShowDialog();
        }

        private void btnRegistrarAutobus_Click(object sender, EventArgs e)
        {
            frmRegistrarAutobus formularioRegistrarAutobus = new frmRegistrarAutobus();
            formularioRegistrarAutobus.StartPosition = FormStartPosition.CenterScreen;
            formularioRegistrarAutobus.ShowDialog();
        }

        private void btnRegistrarRuta_Click(object sender, EventArgs e)
        {
            frmRegistrarRuta formularioRegistrarRuta = new frmRegistrarRuta();
            formularioRegistrarRuta.StartPosition = FormStartPosition.CenterScreen;
            formularioRegistrarRuta.ShowDialog();
        }

        private void btnConsultaTerminales_Click(object sender, EventArgs e)
        {
            frmConsultaTerminales formularioConsultaTerminales = new frmConsultaTerminales();
            formularioConsultaTerminales.StartPosition = FormStartPosition.CenterScreen;
            formularioConsultaTerminales.ShowDialog();
        }

        private void btnConsultaConductores_Click(object sender, EventArgs e)
        {
            frmConsultaConductores formularioConsultaConductores = new frmConsultaConductores();
            formularioConsultaConductores.StartPosition = FormStartPosition.CenterScreen;
            formularioConsultaConductores.ShowDialog();
            
        }

        private void btnConsultaAutobuses_Click(object sender, EventArgs e)
        {
            frmConsultaAutobuses formularioConsultaAutobuses = new frmConsultaAutobuses();
            formularioConsultaAutobuses.StartPosition = FormStartPosition.CenterScreen;
            formularioConsultaAutobuses.ShowDialog();
        }

        private void btnConsultaRutas_Click(object sender, EventArgs e)
        {
            frmConsultaRutas formularioConsultaRutas = new frmConsultaRutas();
            formularioConsultaRutas.StartPosition = FormStartPosition.CenterScreen;
            formularioConsultaRutas.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            btnDetener.Enabled = false;
        }
    }
}
