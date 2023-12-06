namespace Tarea_1
{
    partial class frmRegistrarTerminales
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
            this.DTACierre = new System.Windows.Forms.DateTimePicker();
            this.DTAApertura = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonoTerminal = new System.Windows.Forms.TextBox();
            this.txtDireccionTerminal = new System.Windows.Forms.TextBox();
            this.txtNombreTerminal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.btnRegistrarTerminal = new System.Windows.Forms.Button();
            this.txtIdTerminal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DTACierre
            // 
            this.DTACierre.CustomFormat = "HH:mm";
            this.DTACierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTACierre.Location = new System.Drawing.Point(378, 284);
            this.DTACierre.Name = "DTACierre";
            this.DTACierre.Size = new System.Drawing.Size(206, 20);
            this.DTACierre.TabIndex = 35;
            this.DTACierre.Value = new System.DateTime(2022, 10, 27, 6, 0, 0, 0);
            // 
            // DTAApertura
            // 
            this.DTAApertura.CustomFormat = "HH:mm";
            this.DTAApertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTAApertura.Location = new System.Drawing.Point(379, 247);
            this.DTAApertura.Name = "DTAApertura";
            this.DTAApertura.Size = new System.Drawing.Size(206, 20);
            this.DTAApertura.TabIndex = 34;
            this.DTAApertura.Value = new System.DateTime(2022, 10, 26, 6, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Hora de cierre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hora de apertura";
            // 
            // txtTelefonoTerminal
            // 
            this.txtTelefonoTerminal.Location = new System.Drawing.Point(379, 212);
            this.txtTelefonoTerminal.Name = "txtTelefonoTerminal";
            this.txtTelefonoTerminal.Size = new System.Drawing.Size(206, 20);
            this.txtTelefonoTerminal.TabIndex = 30;
            this.txtTelefonoTerminal.TextChanged += new System.EventHandler(this.txtTelefonoTerminal_TextChanged);
            // 
            // txtDireccionTerminal
            // 
            this.txtDireccionTerminal.Location = new System.Drawing.Point(379, 175);
            this.txtDireccionTerminal.Name = "txtDireccionTerminal";
            this.txtDireccionTerminal.Size = new System.Drawing.Size(206, 20);
            this.txtDireccionTerminal.TabIndex = 28;
            this.txtDireccionTerminal.TextChanged += new System.EventHandler(this.txtDireccionTerminal_TextChanged);
            // 
            // txtNombreTerminal
            // 
            this.txtNombreTerminal.Location = new System.Drawing.Point(379, 138);
            this.txtNombreTerminal.Name = "txtNombreTerminal";
            this.txtNombreTerminal.Size = new System.Drawing.Size(206, 20);
            this.txtNombreTerminal.TabIndex = 26;
            this.txtNombreTerminal.TextChanged += new System.EventHandler(this.txtNombreTerminal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Teléfono terminal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Dirección de terminal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nombre de terminal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID de terminal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Registro de terminales";
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstado.Location = new System.Drawing.Point(379, 325);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(98, 21);
            this.cbxEstado.TabIndex = 21;
            // 
            // btnRegistrarTerminal
            // 
            this.btnRegistrarTerminal.Location = new System.Drawing.Point(355, 384);
            this.btnRegistrarTerminal.Name = "btnRegistrarTerminal";
            this.btnRegistrarTerminal.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarTerminal.TabIndex = 20;
            this.btnRegistrarTerminal.Text = "Registrar";
            this.btnRegistrarTerminal.UseVisualStyleBackColor = true;
            this.btnRegistrarTerminal.Click += new System.EventHandler(this.btnRegistrarTerminal_Click);
            // 
            // txtIdTerminal
            // 
            this.txtIdTerminal.Location = new System.Drawing.Point(379, 102);
            this.txtIdTerminal.Name = "txtIdTerminal";
            this.txtIdTerminal.ReadOnly = true;
            this.txtIdTerminal.Size = new System.Drawing.Size(206, 20);
            this.txtIdTerminal.TabIndex = 66;
            // 
            // frmRegistrarTerminales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdTerminal);
            this.Controls.Add(this.DTACierre);
            this.Controls.Add(this.DTAApertura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefonoTerminal);
            this.Controls.Add(this.txtDireccionTerminal);
            this.Controls.Add(this.txtNombreTerminal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.btnRegistrarTerminal);
            this.Name = "frmRegistrarTerminales";
            this.Text = "Terminales";
            this.Load += new System.EventHandler(this.frmRegistrarTerminales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTACierre;
        private System.Windows.Forms.DateTimePicker DTAApertura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonoTerminal;
        private System.Windows.Forms.TextBox txtDireccionTerminal;
        private System.Windows.Forms.TextBox txtNombreTerminal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Button btnRegistrarTerminal;
        private System.Windows.Forms.TextBox txtIdTerminal;
    }
}