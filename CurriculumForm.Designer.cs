namespace journal
{
    partial class CurriculumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurriculumForm));
            this.TermDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectDataGrid = new System.Windows.Forms.DataGridView();
            this.EditSubjectButton = new System.Windows.Forms.Button();
            this.CheckSubjectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TermDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TermDataGrid
            // 
            this.TermDataGrid.AllowUserToAddRows = false;
            this.TermDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TermDataGrid.Location = new System.Drawing.Point(21, 30);
            this.TermDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TermDataGrid.Name = "TermDataGrid";
            this.TermDataGrid.RowHeadersVisible = false;
            this.TermDataGrid.RowHeadersWidth = 51;
            this.TermDataGrid.RowTemplate.Height = 24;
            this.TermDataGrid.Size = new System.Drawing.Size(192, 511);
            this.TermDataGrid.TabIndex = 0;
            this.TermDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TermDataGrid_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Перелiк семестрiв";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Перелiк дiсциплiн";
            // 
            // SubjectDataGrid
            // 
            this.SubjectDataGrid.AllowUserToAddRows = false;
            this.SubjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGrid.Location = new System.Drawing.Point(253, 30);
            this.SubjectDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectDataGrid.Name = "SubjectDataGrid";
            this.SubjectDataGrid.RowHeadersVisible = false;
            this.SubjectDataGrid.RowHeadersWidth = 51;
            this.SubjectDataGrid.RowTemplate.Height = 24;
            this.SubjectDataGrid.Size = new System.Drawing.Size(439, 511);
            this.SubjectDataGrid.TabIndex = 3;
            // 
            // EditSubjectButton
            // 
            this.EditSubjectButton.FlatAppearance.BorderSize = 0;
            this.EditSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSubjectButton.Image = ((System.Drawing.Image)(resources.GetObject("EditSubjectButton.Image")));
            this.EditSubjectButton.Location = new System.Drawing.Point(699, 30);
            this.EditSubjectButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditSubjectButton.Name = "EditSubjectButton";
            this.EditSubjectButton.Size = new System.Drawing.Size(37, 34);
            this.EditSubjectButton.TabIndex = 13;
            this.EditSubjectButton.UseVisualStyleBackColor = true;
            this.EditSubjectButton.Click += new System.EventHandler(this.EditSubjectButton_Click);
            // 
            // CheckSubjectButton
            // 
            this.CheckSubjectButton.FlatAppearance.BorderSize = 0;
            this.CheckSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckSubjectButton.Image = ((System.Drawing.Image)(resources.GetObject("CheckSubjectButton.Image")));
            this.CheckSubjectButton.Location = new System.Drawing.Point(699, 84);
            this.CheckSubjectButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckSubjectButton.Name = "CheckSubjectButton";
            this.CheckSubjectButton.Size = new System.Drawing.Size(37, 34);
            this.CheckSubjectButton.TabIndex = 11;
            this.CheckSubjectButton.UseVisualStyleBackColor = true;
            this.CheckSubjectButton.Click += new System.EventHandler(this.CheckSubjectButton_Click);
            // 
            // CurriculumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 554);
            this.Controls.Add(this.EditSubjectButton);
            this.Controls.Add(this.CheckSubjectButton);
            this.Controls.Add(this.SubjectDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TermDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurriculumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учбовий план на поточний рiк";
            this.Load += new System.EventHandler(this.CurriculumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TermDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TermDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView SubjectDataGrid;
        private System.Windows.Forms.Button EditSubjectButton;
        private System.Windows.Forms.Button CheckSubjectButton;
    }
}