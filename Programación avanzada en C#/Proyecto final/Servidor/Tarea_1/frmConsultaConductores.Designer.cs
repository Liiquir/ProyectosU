namespace Tarea_1
{
    partial class frmConsultaConductores
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
            this.dtgvConductores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConductores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvConductores
            // 
            this.dtgvConductores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConductores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvConductores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvConductores.Location = new System.Drawing.Point(0, 0);
            this.dtgvConductores.Name = "dtgvConductores";
            this.dtgvConductores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvConductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvConductores.Size = new System.Drawing.Size(800, 450);
            this.dtgvConductores.TabIndex = 1;
            // 
            // frmConsultaConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvConductores);
            this.Name = "frmConsultaConductores";
            this.Text = "TablaConductores";
            this.Load += new System.EventHandler(this.frmConsultaConductores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConductores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvConductores;
    }
}