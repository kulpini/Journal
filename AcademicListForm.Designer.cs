namespace journal
{
    partial class AcademicListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcademicListForm));
            this.AcademicTermLabel = new System.Windows.Forms.Label();
            this.AcademicDataGrid = new System.Windows.Forms.DataGridView();
            this.SubjectListDataGrid = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AcademicDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AcademicTermLabel
            // 
            this.AcademicTermLabel.AutoSize = true;
            this.AcademicTermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcademicTermLabel.ForeColor = System.Drawing.Color.Maroon;
            this.AcademicTermLabel.Location = new System.Drawing.Point(9, 7);
            this.AcademicTermLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AcademicTermLabel.Name = "AcademicTermLabel";
            this.AcademicTermLabel.Size = new System.Drawing.Size(100, 17);
            this.AcademicTermLabel.TabIndex = 0;
            this.AcademicTermLabel.Text = "Дисциплiни ";
            // 
            // AcademicDataGrid
            // 
            this.AcademicDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcademicDataGrid.Location = new System.Drawing.Point(9, 33);
            this.AcademicDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AcademicDataGrid.Name = "AcademicDataGrid";
            this.AcademicDataGrid.RowHeadersVisible = false;
            this.AcademicDataGrid.RowHeadersWidth = 51;
            this.AcademicDataGrid.RowTemplate.Height = 24;
            this.AcademicDataGrid.Size = new System.Drawing.Size(243, 435);
            this.AcademicDataGrid.TabIndex = 1;
            // 
            // SubjectListDataGrid
            // 
            this.SubjectListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectListDataGrid.Location = new System.Drawing.Point(312, 33);
            this.SubjectListDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubjectListDataGrid.Name = "SubjectListDataGrid";
            this.SubjectListDataGrid.RowHeadersVisible = false;
            this.SubjectListDataGrid.RowHeadersWidth = 51;
            this.SubjectListDataGrid.RowTemplate.Height = 24;
            this.SubjectListDataGrid.Size = new System.Drawing.Size(241, 435);
            this.SubjectListDataGrid.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(266, 80);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(28, 31);
            this.AddButton.TabIndex = 3;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(266, 133);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(28, 31);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AcademicListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 478);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SubjectListDataGrid);
            this.Controls.Add(this.AcademicDataGrid);
            this.Controls.Add(this.AcademicTermLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcademicListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перелiк дисциплiн в обраному семестрi";
            this.Load += new System.EventHandler(this.AcademicListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AcademicDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectListDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label AcademicTermLabel;
        private System.Windows.Forms.DataGridView AcademicDataGrid;
        private System.Windows.Forms.DataGridView SubjectListDataGrid;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}