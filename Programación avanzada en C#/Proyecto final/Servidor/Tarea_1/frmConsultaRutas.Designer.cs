namespace Tarea_1
{
    partial class frmConsultaRutas
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
            this.dtgvRutas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRutas
            // 
            this.dtgvRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvRutas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvRutas.Location = new System.Drawing.Point(0, 0);
            this.dtgvRutas.Name = "dtgvRutas";
            this.dtgvRutas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvRutas.Size = new System.Drawing.Size(1874, 450);
            this.dtgvRutas.TabIndex = 3;
            // 
            // frmConsultaRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 450);
            this.Controls.Add(this.dtgvRutas);
            this.Name = "frmConsultaRutas";
            this.Text = "TablaRutas";
            this.Load += new System.EventHandler(this.frmConsultaRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvRutas;
    }
}