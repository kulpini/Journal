namespace journal
{
    partial class GradesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesForm));
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.TermDataGrid = new System.Windows.Forms.DataGridView();
            this.SubjectsDataGrid = new System.Windows.Forms.DataGridView();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ScoreDataGrid = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EditGradeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TermDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.StudentNameLabel.Location = new System.Drawing.Point(29, 11);
            this.StudentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(62, 21);
            this.StudentNameLabel.TabIndex = 0;
            this.StudentNameLabel.Text = "label1";
            // 
            // TermDataGrid
            // 
            this.TermDataGrid.AllowUserToAddRows = false;
            this.TermDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TermDataGrid.Location = new System.Drawing.Point(16, 48);
            this.TermDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.TermDataGrid.Name = "TermDataGrid";
            this.TermDataGrid.RowHeadersVisible = false;
            this.TermDataGrid.RowHeadersWidth = 51;
            this.TermDataGrid.Size = new System.Drawing.Size(212, 491);
            this.TermDataGrid.TabIndex = 1;
            this.TermDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TermDataGrid_CellEnter);
            // 
            // SubjectsDataGrid
            // 
            this.SubjectsDataGrid.AllowUserToAddRows = false;
            this.SubjectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsDataGrid.Location = new System.Drawing.Point(249, 48);
            this.SubjectsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.SubjectsDataGrid.Name = "SubjectsDataGrid";
            this.SubjectsDataGrid.RowHeadersVisible = false;
            this.SubjectsDataGrid.RowHeadersWidth = 51;
            this.SubjectsDataGrid.Size = new System.Drawing.Size(363, 491);
            this.SubjectsDataGrid.TabIndex = 2;
            // 
            // GradeTextBox
            // 
            this.GradeTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GradeTextBox.Location = new System.Drawing.Point(705, 44);
            this.GradeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.Size = new System.Drawing.Size(59, 27);
            this.GradeTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(620, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Оцiнка:";
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.Maroon;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(624, 80);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.AddButton.Size = new System.Drawing.Size(141, 33);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Внести";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ScoreDataGrid
            // 
            this.ScoreDataGrid.AllowUserToAddRows = false;
            this.ScoreDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreDataGrid.Location = new System.Drawing.Point(795, 44);
            this.ScoreDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ScoreDataGrid.Name = "ScoreDataGrid";
            this.ScoreDataGrid.RowHeadersVisible = false;
            this.ScoreDataGrid.RowHeadersWidth = 51;
            this.ScoreDataGrid.Size = new System.Drawing.Size(401, 491);
            this.ScoreDataGrid.TabIndex = 6;
            this.ScoreDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScoreDataGrid_CellEnter);
            // 
            // EditButton
            // 
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.ForeColor = System.Drawing.Color.Maroon;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(624, 298);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditButton.Size = new System.Drawing.Size(155, 33);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Корегувати";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(620, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оцiнка:";
            // 
            // EditGradeTextBox
            // 
            this.EditGradeTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditGradeTextBox.Location = new System.Drawing.Point(705, 262);
            this.EditGradeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EditGradeTextBox.Name = "EditGradeTextBox";
            this.EditGradeTextBox.Size = new System.Drawing.Size(59, 27);
            this.EditGradeTextBox.TabIndex = 7;
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 554);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditGradeTextBox);
            this.Controls.Add(this.ScoreDataGrid);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GradeTextBox);
            this.Controls.Add(this.SubjectsDataGrid);
            this.Controls.Add(this.TermDataGrid);
            this.Controls.Add(this.StudentNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GradesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал оцiнок";
            this.Load += new System.EventHandler(this.GradesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TermDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.DataGridView TermDataGrid;
        private System.Windows.Forms.DataGridView SubjectsDataGrid;
        private System.Windows.Forms.TextBox GradeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView ScoreDataGrid;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditGradeTextBox;
    }
}