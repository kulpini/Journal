namespace journal
{
    partial class StudentReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentReportForm));
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StudentNameLabel.Location = new System.Drawing.Point(9, 15);
            this.StudentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(778, 19);
            this.StudentNameLabel.TabIndex = 1;
            this.StudentNameLabel.Text = "label1";
            this.StudentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrintButton
            // 
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.ForeColor = System.Drawing.Color.Maroon;
            this.PrintButton.Location = new System.Drawing.Point(884, 10);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(129, 29);
            this.PrintButton.TabIndex = 3;
            this.PrintButton.Text = "Роздрукувати";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGrid.Location = new System.Drawing.Point(14, 49);
            this.ReportDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.RowHeadersVisible = false;
            this.ReportDataGrid.RowHeadersWidth = 51;
            this.ReportDataGrid.RowTemplate.Height = 24;
            this.ReportDataGrid.Size = new System.Drawing.Size(999, 364);
            this.ReportDataGrid.TabIndex = 4;
            this.ReportDataGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ReportDataGrid_CellPainting);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // StudentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 424);
            this.Controls.Add(this.ReportDataGrid);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.StudentNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виписка по обраному студенту";
            this.Load += new System.EventHandler(this.StudentReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.DataGridView ReportDataGrid;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}