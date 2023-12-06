namespace Tarea_1
{
    partial class frmRegistrarAutobus
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
            this.btnRegistrarAutobus = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.cbxEstadoAutobus = new System.Windows.Forms.ComboBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtIdPlaca = new System.Windows.Forms.TextBox();
            this.txtIdAutobus = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarAutobus
            // 
            this.btnRegistrarAutobus.Location = new System.Drawing.Point(181, 364);
            this.btnRegistrarAutobus.Name = "btnRegistrarAutobus";
            this.btnRegistrarAutobus.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarAutobus.TabIndex = 56;
            this.btnRegistrarAutobus.Text = "Registrar";
            this.btnRegistrarAutobus.UseVisualStyleBackColor = true;
            this.btnRegistrarAutobus.Click += new System.EventHandler(this.btnRegistrarAutobus_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(114, 305);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 20);
            this.label23.TabIndex = 55;
            this.label23.Text = "Estado";
            // 
            // cbxEstadoAutobus
            // 
            this.cbxEstadoAutobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoAutobus.FormattingEnabled = true;
            this.cbxEstadoAutobus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstadoAutobus.Location = new System.Drawing.Point(181, 307);
            this.cbxEstadoAutobus.Name = "cbxEstadoAutobus";
            this.cbxEstadoAutobus.Size = new System.Drawing.Size(98, 21);
            this.cbxEstadoAutobus.TabIndex = 54;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(181, 267);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(206, 20);
            this.txtCapacidad.TabIndex = 53;
            this.txtCapacidad.TextChanged += new System.EventHandler(this.txtCapacidad_TextChanged);
            this.txtCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacidad_KeyPress);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(181, 231);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(206, 20);
            this.txtModelo.TabIndex = 51;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(181, 194);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(206, 20);
            this.txtMarca.TabIndex = 49;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtIdPlaca
            // 
            this.txtIdPlaca.Location = new System.Drawing.Point(181, 155);
            this.txtIdPlaca.Name = "txtIdPlaca";
            this.txtIdPlaca.Size = new System.Drawing.Size(206, 20);
            this.txtIdPlaca.TabIndex = 47;
            this.txtIdPlaca.TextChanged += new System.EventHandler(this.txtIdPlaca_TextChanged);
            // 
            // txtIdAutobus
            // 
            this.txtIdAutobus.Location = new System.Drawing.Point(181, 113);
            this.txtIdAutobus.Name = "txtIdAutobus";
            this.txtIdAutobus.ReadOnly = true;
            this.txtIdAutobus.Size = new System.Drawing.Size(206, 20);
            this.txtIdAutobus.TabIndex = 45;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(89, 267);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 20);
            this.label22.TabIndex = 52;
            this.label22.Text = "Capacidad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(109, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 20);
            this.label17.TabIndex = 50;
            this.label17.Text = "Modelo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(117, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 20);
            this.label18.TabIndex = 48;
            this.label18.Text = "Marca";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(105, 153);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 20);
            this.label19.TabIndex = 46;
            this.label19.Text = "ID placa";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(67, 113);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 20);
            this.label20.TabIndex = 44;
            this.label20.Text = "Identificación";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(135, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(257, 31);
            this.label21.TabIndex = 43;
            this.label21.Text = "Registro de autobus";
            // 
            // frmRegistrarAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.btnRegistrarAutobus);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cbxEstadoAutobus);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtIdPlaca);
            this.Controls.Add(this.txtIdAutobus);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Name = "frmRegistrarAutobus";
            this.Text = "Autobus";
            this.Load += new System.EventHandler(this.frmRegistrarAutobus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarAutobus;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbxEstadoAutobus;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtIdPlaca;
        private System.Windows.Forms.TextBox txtIdAutobus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}