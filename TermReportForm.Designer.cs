namespace journal
{
    partial class TermReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermReportForm));
            this.TermNameLabel = new System.Windows.Forms.Label();
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            this.PrintButton = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TermNameLabel
            // 
            this.TermNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TermNameLabel.Location = new System.Drawing.Point(17, 16);
            this.TermNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TermNameLabel.Name = "TermNameLabel";
            this.TermNameLabel.Size = new System.Drawing.Size(786, 19);
            this.TermNameLabel.TabIndex = 0;
            this.TermNameLabel.Text = "label1";
            this.TermNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReportDataGrid.ColumnHeadersHeight = 4;
            this.ReportDataGrid.Location = new System.Drawing.Point(12, 47);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.RowHeadersVisible = false;
            this.ReportDataGrid.RowHeadersWidth = 51;
            this.ReportDataGrid.Size = new System.Drawing.Size(922, 471);
            this.ReportDataGrid.TabIndex = 1;
            this.ReportDataGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ReportDataGrid_CellPainting);
            // 
            // PrintButton
            // 
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.ForeColor = System.Drawing.Color.Maroon;
            this.PrintButton.Location = new System.Drawing.Point(808, 10);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(129, 29);
            this.PrintButton.TabIndex = 2;
            this.PrintButton.Text = "Роздрукувати";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // TermReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 530);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ReportDataGrid);
            this.Controls.Add(this.TermNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TermReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виписка по обраному семестру";
            this.Load += new System.EventHandler(this.TermReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label TermNameLabel;
        private System.Windows.Forms.DataGridView ReportDataGrid;
        private System.Windows.Forms.Button PrintButton;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}