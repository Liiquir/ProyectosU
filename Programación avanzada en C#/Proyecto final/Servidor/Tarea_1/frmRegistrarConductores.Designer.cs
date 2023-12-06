namespace Tarea_1
{
    partial class frmRegistrarConductores
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
            this.dtaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbSupervisor = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtNombreConductor = new System.Windows.Forms.TextBox();
            this.txtIDConductor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.btnRegistrarConductor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtaNacimiento
            // 
            this.dtaNacimiento.Location = new System.Drawing.Point(378, 253);
            this.dtaNacimiento.Name = "dtaNacimiento";
            this.dtaNacimiento.Size = new System.Drawing.Size(203, 20);
            this.dtaNacimiento.TabIndex = 51;
            // 
            // cbSupervisor
            // 
            this.cbSupervisor.AutoSize = true;
            this.cbSupervisor.Location = new System.Drawing.Point(381, 326);
            this.cbSupervisor.Name = "cbSupervisor";
            this.cbSupervisor.Size = new System.Drawing.Size(15, 14);
            this.cbSupervisor.TabIndex = 50;
            this.cbSupervisor.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Conductor supervisor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Genero";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(216, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Fecha de nacimiento";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(378, 215);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(206, 20);
            this.txtSegundoApellido.TabIndex = 46;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(378, 178);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(206, 20);
            this.txtPrimerApellido.TabIndex = 44;
            // 
            // txtNombreConductor
            // 
            this.txtNombreConductor.Location = new System.Drawing.Point(378, 141);
            this.txtNombreConductor.Name = "txtNombreConductor";
            this.txtNombreConductor.Size = new System.Drawing.Size(206, 20);
            this.txtNombreConductor.TabIndex = 42;
            // 
            // txtIDConductor
            // 
            this.txtIDConductor.Location = new System.Drawing.Point(378, 103);
            this.txtIDConductor.Name = "txtIDConductor";
            this.txtIDConductor.Size = new System.Drawing.Size(206, 20);
            this.txtIDConductor.TabIndex = 40;
            this.txtIDConductor.TextChanged += new System.EventHandler(this.txtIDConductor_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(241, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Segundo apellido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(255, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Primer apellido";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(302, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "Nombre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(264, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 39;
            this.label15.Text = "Identificación";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(272, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(309, 31);
            this.label16.TabIndex = 38;
            this.label16.Text = "Registro de conductores";
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxGenero.Location = new System.Drawing.Point(378, 286);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(98, 21);
            this.cbxGenero.TabIndex = 37;
            this.cbxGenero.Tag = "M";
            // 
            // btnRegistrarConductor
            // 
            this.btnRegistrarConductor.Location = new System.Drawing.Point(354, 387);
            this.btnRegistrarConductor.Name = "btnRegistrarConductor";
            this.btnRegistrarConductor.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarConductor.TabIndex = 36;
            this.btnRegistrarConductor.Text = "Registrar";
            this.btnRegistrarConductor.UseVisualStyleBackColor = true;
            this.btnRegistrarConductor.Click += new System.EventHandler(this.btnRegistrarConductor_Click);
            // 
            // frmRegistrarConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtaNacimiento);
            this.Controls.Add(this.cbSupervisor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtNombreConductor);
            this.Controls.Add(this.txtIDConductor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.btnRegistrarConductor);
            this.Name = "frmRegistrarConductores";
            this.Text = "Conductores";
            this.Load += new System.EventHandler(this.frmRegistrarConductores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtaNacimiento;
        private System.Windows.Forms.CheckBox cbSupervisor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtNombreConductor;
        private System.Windows.Forms.TextBox txtIDConductor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Button btnRegistrarConductor;
    }
}