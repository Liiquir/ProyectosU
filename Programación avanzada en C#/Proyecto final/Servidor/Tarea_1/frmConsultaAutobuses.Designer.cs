namespace Tarea_1
{
    partial class frmConsultaAutobuses
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
            this.dtgvAutobuses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAutobuses)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAutobuses
            // 
            this.dtgvAutobuses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAutobuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAutobuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAutobuses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvAutobuses.Location = new System.Drawing.Point(0, 0);
            this.dtgvAutobuses.Name = "dtgvAutobuses";
            this.dtgvAutobuses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvAutobuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAutobuses.Size = new System.Drawing.Size(800, 450);
            this.dtgvAutobuses.TabIndex = 2;
            // 
            // frmConsultaAutobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvAutobuses);
            this.Name = "frmConsultaAutobuses";
            this.Text = "TablaAutobuses";
            this.Load += new System.EventHandler(this.frmConsultaAutobuses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAutobuses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAutobuses;
    }
}