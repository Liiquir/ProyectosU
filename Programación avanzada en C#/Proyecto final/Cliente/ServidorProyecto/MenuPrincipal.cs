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
    public partial class MenuPrincipal : Form
    {
        bool clienteConectado=false;
        public MenuPrincipal()
        {
            InitializeComponent();
            lblEstado.ForeColor = Color.Red;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;
        }
                   
        private void btnConectar_Click(object sender, EventArgs e) 
        {     //el codigo de este boton fue obtenido de los ejemplos de las tutorias
            //solamente se adapto para hacerlo funcional a mi proyecto
            if (!(txtIdentificador.Text.Equals(string.Empty)))
            {
                if (ClienteTCP.Conectar(txtIdentificador.Text))
                {
                    lblEstado.Text = "Conectado al servidor... en (127.0.0.1, 14100)";
                    lblEstado.ForeColor = Color.Green;
                    clienteConectado = true;
                    btnConectar.Enabled = false;
                    btnDesconectar.Enabled = true;
                    txtIdentificador.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Verifique que el servidor esté escuchando clientes...", "No es posible conectarse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el identificador del cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            ClienteTCP.Desconectar(txtIdentificador.Text);

            lblEstado.Text = "Desconectado";
            lblEstado.ForeColor = Color.Red;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;
            clienteConectado = false;
            txtIdentificador.ReadOnly = false;
        }

        private void btnRegistrarRol_Click(object sender, EventArgs e)
        {
            if (clienteConectado)
            {
                RegistroRoles formularioAgregarAutor = new RegistroRoles();
                formularioAgregarAutor.StartPosition = FormStartPosition.CenterScreen;
                formularioAgregarAutor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe conectarse primero con el servidor", "No es posible realizar la acción solicitada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConsultarRol_Click(object sender, EventArgs e)
        {
            if (clienteConectado)
            {
                ConsultaRoles formularioConsultarLibros = new ConsultaRoles();
                formularioConsultarLibros.StartPosition = FormStartPosition.CenterScreen;
                formularioConsultarLibros.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe conectarse primero con el servidor", "No es posible realizar la acción solicitada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
