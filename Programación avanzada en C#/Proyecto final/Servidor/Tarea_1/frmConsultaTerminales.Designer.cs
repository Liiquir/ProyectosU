namespace Tarea_1
{
    partial class frmConsultaTerminales
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
            this.dtgvTerminales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTerminales)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTerminales
            // 
            this.dtgvTerminales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTerminales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTerminales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTerminales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvTerminales.Location = new System.Drawing.Point(0, 0);
            this.dtgvTerminales.Name = "dtgvTerminales";
            this.dtgvTerminales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvTerminales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTerminales.Size = new System.Drawing.Size(818, 450);
            this.dtgvTerminales.TabIndex = 1;
            // 
            // frmConsultaTerminales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.dtgvTerminales);
            this.Name = "frmConsultaTerminales";
            this.Text = "TablaTerminales";
            this.Load += new System.EventHandler(this.frmConsultaTerminales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTerminales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTerminales;
    }
}