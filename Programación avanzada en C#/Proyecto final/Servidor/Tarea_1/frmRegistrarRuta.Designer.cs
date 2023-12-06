namespace Tarea_1
{
    partial class frmRegistrarRuta
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
            this.label33 = new System.Windows.Forms.Label();
            this.cbxTipoRuta = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbxTerminalLlegada = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cbxTerminalSalida = new System.Windows.Forms.ComboBox();
            this.btnRegistrarRuta = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.cbxEstadoRuta = new System.Windows.Forms.ComboBox();
            this.txtDescripcionRuta = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txtIdTerminalLlegada = new System.Windows.Forms.TextBox();
            this.txtIdTerminalSalida = new System.Windows.Forms.TextBox();
            this.txtIdRuta = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(99, 328);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(93, 20);
            this.label33.TabIndex = 82;
            this.label33.Text = "Tipo de ruta";
            // 
            // cbxTipoRuta
            // 
            this.cbxTipoRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoRuta.FormattingEnabled = true;
            this.cbxTipoRuta.Items.AddRange(new object[] {
            "Directo",
            "Regular"});
            this.cbxTipoRuta.Location = new System.Drawing.Point(207, 330);
            this.cbxTipoRuta.Name = "cbxTipoRuta";
            this.cbxTipoRuta.Size = new System.Drawing.Size(98, 21);
            this.cbxTipoRuta.TabIndex = 81;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(47, 181);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(146, 20);
            this.label32.TabIndex = 80;
            this.label32.Text = "Terminal de llegada";
            // 
            // cbxTerminalLlegada
            // 
            this.cbxTerminalLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTerminalLlegada.FormattingEnabled = true;
            this.cbxTerminalLlegada.Location = new System.Drawing.Point(207, 183);
            this.cbxTerminalLlegada.Name = "cbxTerminalLlegada";
            this.cbxTerminalLlegada.Size = new System.Drawing.Size(206, 21);
            this.cbxTerminalLlegada.TabIndex = 79;
            this.cbxTerminalLlegada.SelectedIndexChanged += new System.EventHandler(this.cbxTerminalLlegada_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(57, 107);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(136, 20);
            this.label31.TabIndex = 78;
            this.label31.Text = "Terminal de salida";
            // 
            // cbxTerminalSalida
            // 
            this.cbxTerminalSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTerminalSalida.FormattingEnabled = true;
            this.cbxTerminalSalida.Location = new System.Drawing.Point(207, 109);
            this.cbxTerminalSalida.Name = "cbxTerminalSalida";
            this.cbxTerminalSalida.Size = new System.Drawing.Size(206, 21);
            this.cbxTerminalSalida.TabIndex = 77;
            this.cbxTerminalSalida.SelectedIndexChanged += new System.EventHandler(this.cbxTerminalSalida_SelectedIndexChanged);
            // 
            // btnRegistrarRuta
            // 
            this.btnRegistrarRuta.Location = new System.Drawing.Point(207, 402);
            this.btnRegistrarRuta.Name = "btnRegistrarRuta";
            this.btnRegistrarRuta.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarRuta.TabIndex = 76;
            this.btnRegistrarRuta.Text = "Registrar";
            this.btnRegistrarRuta.UseVisualStyleBackColor = true;
            this.btnRegistrarRuta.Click += new System.EventHandler(this.btnRegistrarRuta_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(140, 364);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 20);
            this.label24.TabIndex = 75;
            this.label24.Text = "Estado";
            // 
            // cbxEstadoRuta
            // 
            this.cbxEstadoRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoRuta.FormattingEnabled = true;
            this.cbxEstadoRuta.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstadoRuta.Location = new System.Drawing.Point(207, 366);
            this.cbxEstadoRuta.Name = "cbxEstadoRuta";
            this.cbxEstadoRuta.Size = new System.Drawing.Size(98, 21);
            this.cbxEstadoRuta.TabIndex = 74;
            // 
            // txtDescripcionRuta
            // 
            this.txtDescripcionRuta.Location = new System.Drawing.Point(207, 295);
            this.txtDescripcionRuta.Name = "txtDescripcionRuta";
            this.txtDescripcionRuta.Size = new System.Drawing.Size(206, 20);
            this.txtDescripcionRuta.TabIndex = 73;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(207, 259);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(206, 20);
            this.txtTarifa.TabIndex = 71;
            this.txtTarifa.TextChanged += new System.EventHandler(this.txtTarifa_TextChanged);
            this.txtTarifa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarifa_KeyPress);
            // 
            // txtIdTerminalLlegada
            // 
            this.txtIdTerminalLlegada.Location = new System.Drawing.Point(207, 221);
            this.txtIdTerminalLlegada.Name = "txtIdTerminalLlegada";
            this.txtIdTerminalLlegada.ReadOnly = true;
            this.txtIdTerminalLlegada.Size = new System.Drawing.Size(206, 20);
            this.txtIdTerminalLlegada.TabIndex = 69;
            // 
            // txtIdTerminalSalida
            // 
            this.txtIdTerminalSalida.Location = new System.Drawing.Point(207, 145);
            this.txtIdTerminalSalida.Name = "txtIdTerminalSalida";
            this.txtIdTerminalSalida.ReadOnly = true;
            this.txtIdTerminalSalida.Size = new System.Drawing.Size(206, 20);
            this.txtIdTerminalSalida.TabIndex = 67;
            // 
            // txtIdRuta
            // 
            this.txtIdRuta.Location = new System.Drawing.Point(207, 72);
            this.txtIdRuta.Name = "txtIdRuta";
            this.txtIdRuta.ReadOnly = true;
            this.txtIdRuta.Size = new System.Drawing.Size(206, 20);
            this.txtIdRuta.TabIndex = 65;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(30, 293);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(162, 20);
            this.label25.TabIndex = 72;
            this.label25.Text = "Descripcion de la ruta";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(144, 257);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 20);
            this.label26.TabIndex = 70;
            this.label26.Text = "Tarifa";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(30, 221);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(163, 20);
            this.label27.TabIndex = 68;
            this.label27.Text = "ID terminal de llegada";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(43, 145);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(153, 20);
            this.label28.TabIndex = 66;
            this.label28.Text = "ID terminal de salida";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(135, 70);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(58, 20);
            this.label29.TabIndex = 64;
            this.label29.Text = "ID ruta";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(160, 28);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(207, 31);
            this.label30.TabIndex = 63;
            this.label30.Text = "Registro de ruta";
            // 
            // frmRegistrarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.cbxTipoRuta);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.cbxTerminalLlegada);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.cbxTerminalSalida);
            this.Controls.Add(this.btnRegistrarRuta);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cbxEstadoRuta);
            this.Controls.Add(this.txtDescripcionRuta);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.txtIdTerminalLlegada);
            this.Controls.Add(this.txtIdTerminalSalida);
            this.Controls.Add(this.txtIdRuta);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Name = "frmRegistrarRuta";
            this.Text = "Ruta";
            this.Load += new System.EventHandler(this.frmRegistrarRuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cbxTipoRuta;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cbxTerminalLlegada;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cbxTerminalSalida;
        private System.Windows.Forms.Button btnRegistrarRuta;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbxEstadoRuta;
        private System.Windows.Forms.TextBox txtDescripcionRuta;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtIdTerminalLlegada;
        private System.Windows.Forms.TextBox txtIdTerminalSalida;
        private System.Windows.Forms.TextBox txtIdRuta;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
    }
}