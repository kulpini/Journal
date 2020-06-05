namespace journal
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StudentNameLabel.Location = new System.Drawing.Point(17, 16);
            this.StudentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(574, 19);
            this.StudentNameLabel.TabIndex = 0;
            this.StudentNameLabel.Text = "label1";
            this.StudentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGrid.Location = new System.Drawing.Point(12, 47);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.Size = new System.Drawing.Size(576, 277);
            this.ReportDataGrid.TabIndex = 1;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 479);
            this.Controls.Add(this.ReportDataGrid);
            this.Controls.Add(this.StudentNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.Text = "Виписка по обраному студенту";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.DataGridView ReportDataGrid;
    }
}