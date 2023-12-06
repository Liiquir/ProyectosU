namespace Tarea_1
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstClientesConectados = new System.Windows.Forms.ListBox();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarConductores = new System.Windows.Forms.Button();
            this.btnRegistrarAutobus = new System.Windows.Forms.Button();
            this.btnRegistrarRuta = new System.Windows.Forms.Button();
            this.btnConsultaTerminales = new System.Windows.Forms.Button();
            this.btnConsultaConductores = new System.Windows.Forms.Button();
            this.btnConsultaAutobuses = new System.Windows.Forms.Button();
            this.btnConsultaRutas = new System.Windows.Forms.Button();
            this.btnRegistrarTerminales = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnDetener);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del servidor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBitacora);
            this.groupBox3.Location = new System.Drawing.Point(450, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 173);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bítacora";
            // 
            // txtBitacora
            // 
            this.txtBitacora.Location = new System.Drawing.Point(6, 19);
            this.txtBitacora.Multiline = true;
            this.txtBitacora.Name = "txtBitacora";
            this.txtBitacora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBitacora.Size = new System.Drawing.Size(137, 147);
            this.txtBitacora.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstClientesConectados);
            this.groupBox2.Location = new System.Drawing.Point(239, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 173);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes conectados";
            // 
            // lstClientesConectados
            // 
            this.lstClientesConectados.FormattingEnabled = true;
            this.lstClientesConectados.Location = new System.Drawing.Point(6, 19);
            this.lstClientesConectados.Name = "lstClientesConectados";
            this.lstClientesConectados.Size = new System.Drawing.Size(151, 147);
            this.lstClientesConectados.TabIndex = 0;
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(114, 85);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(90, 23);
            this.btnDetener.TabIndex = 3;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(10, 85);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(84, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(7, 54);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 13);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Sin iniciar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado:";
            // 
            // btnRegistrarConductores
            // 
            this.btnRegistrarConductores.Location = new System.Drawing.Point(251, 275);
            this.btnRegistrarConductores.Name = "btnRegistrarConductores";
            this.btnRegistrarConductores.Size = new System.Drawing.Size(175, 82);
            this.btnRegistrarConductores.TabIndex = 14;
            this.btnRegistrarConductores.Text = "Registrar Conductores";
            this.btnRegistrarConductores.UseVisualStyleBackColor = true;
            this.btnRegistrarConductores.Click += new System.EventHandler(this.btnRegistrarConductores_Click);
            // 
            // btnRegistrarAutobus
            // 
            this.btnRegistrarAutobus.Location = new System.Drawing.Point(436, 275);
            this.btnRegistrarAutobus.Name = "btnRegistrarAutobus";
            this.btnRegistrarAutobus.Size = new System.Drawing.Size(175, 82);
            this.btnRegistrarAutobus.TabIndex = 15;
            this.btnRegistrarAutobus.Text = "Registrar Autobuses";
            this.btnRegistrarAutobus.UseVisualStyleBackColor = true;
            this.btnRegistrarAutobus.Click += new System.EventHandler(this.btnRegistrarAutobus_Click);
            // 
            // btnRegistrarRuta
            // 
            this.btnRegistrarRuta.Location = new System.Drawing.Point(50, 363);
            this.btnRegistrarRuta.Name = "btnRegistrarRuta";
            this.btnRegistrarRuta.Size = new System.Drawing.Size(175, 82);
            this.btnRegistrarRuta.TabIndex = 16;
            this.btnRegistrarRuta.Text = "Registrar Rutas";
            this.btnRegistrarRuta.UseVisualStyleBackColor = true;
            this.btnRegistrarRuta.Click += new System.EventHandler(this.btnRegistrarRuta_Click);
            // 
            // btnConsultaTerminales
            // 
            this.btnConsultaTerminales.Location = new System.Drawing.Point(251, 363);
            this.btnConsultaTerminales.Name = "btnConsultaTerminales";
            this.btnConsultaTerminales.Size = new System.Drawing.Size(175, 82);
            this.btnConsultaTerminales.TabIndex = 17;
            this.btnConsultaTerminales.Text = "Consultar Terminales";
            this.btnConsultaTerminales.UseVisualStyleBackColor = true;
            this.btnConsultaTerminales.Click += new System.EventHandler(this.btnConsultaTerminales_Click);
            // 
            // btnConsultaConductores
            // 
            this.btnConsultaConductores.Location = new System.Drawing.Point(436, 363);
            this.btnConsultaConductores.Name = "btnConsultaConductores";
            this.btnConsultaConductores.Size = new System.Drawing.Size(175, 82);
            this.btnConsultaConductores.TabIndex = 18;
            this.btnConsultaConductores.Text = "Consultar Conductores";
            this.btnConsultaConductores.UseVisualStyleBackColor = true;
            this.btnConsultaConductores.Click += new System.EventHandler(this.btnConsultaConductores_Click);
            // 
            // btnConsultaAutobuses
            // 
            this.btnConsultaAutobuses.Location = new System.Drawing.Point(50, 451);
            this.btnConsultaAutobuses.Name = "btnConsultaAutobuses";
            this.btnConsultaAutobuses.Size = new System.Drawing.Size(175, 82);
            this.btnConsultaAutobuses.TabIndex = 19;
            this.btnConsultaAutobuses.Text = "Consultar Autobuses";
            this.btnConsultaAutobuses.UseVisualStyleBackColor = true;
            this.btnConsultaAutobuses.Click += new System.EventHandler(this.btnConsultaAutobuses_Click);
            // 
            // btnConsultaRutas
            // 
            this.btnConsultaRutas.Location = new System.Drawing.Point(251, 451);
            this.btnConsultaRutas.Name = "btnConsultaRutas";
            this.btnConsultaRutas.Size = new System.Drawing.Size(175, 82);
            this.btnConsultaRutas.TabIndex = 20;
            this.btnConsultaRutas.Text = "Consultar Rutas";
            this.btnConsultaRutas.UseVisualStyleBackColor = true;
            this.btnConsultaRutas.Click += new System.EventHandler(this.btnConsultaRutas_Click);
            // 
            // btnRegistrarTerminales
            // 
            this.btnRegistrarTerminales.Location = new System.Drawing.Point(50, 275);
            this.btnRegistrarTerminales.Name = "btnRegistrarTerminales";
            this.btnRegistrarTerminales.Size = new System.Drawing.Size(175, 82);
            this.btnRegistrarTerminales.TabIndex = 21;
            this.btnRegistrarTerminales.Text = "Registrar Terminales";
            this.btnRegistrarTerminales.UseVisualStyleBackColor = true;
            this.btnRegistrarTerminales.Click += new System.EventHandler(this.btnRegistrarTerminales_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 574);
            this.Controls.Add(this.btnRegistrarTerminales);
            this.Controls.Add(this.btnConsultaRutas);
            this.Controls.Add(this.btnConsultaAutobuses);
            this.Controls.Add(this.btnConsultaConductores);
            this.Controls.Add(this.btnConsultaTerminales);
            this.Controls.Add(this.btnRegistrarRuta);
            this.Controls.Add(this.btnRegistrarAutobus);
            this.Controls.Add(this.btnRegistrarConductores);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarConductores;
        private System.Windows.Forms.Button btnRegistrarAutobus;
        private System.Windows.Forms.Button btnRegistrarRuta;
        private System.Windows.Forms.Button btnConsultaTerminales;
        private System.Windows.Forms.Button btnConsultaConductores;
        private System.Windows.Forms.Button btnConsultaAutobuses;
        private System.Windows.Forms.Button btnConsultaRutas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstClientesConectados;
        private System.Windows.Forms.Button btnRegistrarTerminales;
    }
}