namespace journal
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StudentsDataGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TermReportButton = new System.Windows.Forms.Button();
            this.AbsenceButton = new System.Windows.Forms.Button();
            this.CurriculumButton = new System.Windows.Forms.Button();
            this.RatingsButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.CharacteristicButton = new System.Windows.Forms.Button();
            this.EditStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TermDataGrid = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ShowedTableLabel = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SubjectsRadioButton = new System.Windows.Forms.RadioButton();
            this.TermsRadioButton = new System.Windows.Forms.RadioButton();
            this.AddTermButton = new System.Windows.Forms.Button();
            this.DeleteTermButton = new System.Windows.Forms.Button();
            this.EditTermButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TermDataGrid)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 613);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.FindButton);
            this.panel5.Controls.Add(this.FindTextBox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(539, 72);
            this.panel5.TabIndex = 5;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FindButton.Location = new System.Drawing.Point(325, 32);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 6;
            this.FindButton.Text = "Знайти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(11, 32);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(305, 20);
            this.FindTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список студентiв";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.StudentsDataGrid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 80, 10, 10);
            this.panel4.Size = new System.Drawing.Size(539, 611);
            this.panel4.TabIndex = 4;
            // 
            // StudentsDataGrid
            // 
            this.StudentsDataGrid.AllowUserToAddRows = false;
            this.StudentsDataGrid.AllowUserToDeleteRows = false;
            this.StudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsDataGrid.Location = new System.Drawing.Point(10, 80);
            this.StudentsDataGrid.Name = "StudentsDataGrid";
            this.StudentsDataGrid.RowHeadersVisible = false;
            this.StudentsDataGrid.RowHeadersWidth = 51;
            this.StudentsDataGrid.Size = new System.Drawing.Size(519, 521);
            this.StudentsDataGrid.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TermReportButton);
            this.panel2.Controls.Add(this.AbsenceButton);
            this.panel2.Controls.Add(this.CurriculumButton);
            this.panel2.Controls.Add(this.RatingsButton);
            this.panel2.Controls.Add(this.ReportButton);
            this.panel2.Controls.Add(this.CharacteristicButton);
            this.panel2.Controls.Add(this.EditStudentButton);
            this.panel2.Controls.Add(this.DeleteStudentButton);
            this.panel2.Controls.Add(this.AddStudentButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(541, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 613);
            this.panel2.TabIndex = 2;
            // 
            // TermReportButton
            // 
            this.TermReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TermReportButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermReportButton.ForeColor = System.Drawing.Color.Maroon;
            this.TermReportButton.Location = new System.Drawing.Point(94, 347);
            this.TermReportButton.Name = "TermReportButton";
            this.TermReportButton.Size = new System.Drawing.Size(162, 27);
            this.TermReportButton.TabIndex = 9;
            this.TermReportButton.Text = "Семестровий звiт";
            this.TermReportButton.UseVisualStyleBackColor = true;
            this.TermReportButton.Click += new System.EventHandler(this.TermReportButton_Click);
            // 
            // AbsenceButton
            // 
            this.AbsenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbsenceButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AbsenceButton.ForeColor = System.Drawing.Color.Maroon;
            this.AbsenceButton.Location = new System.Drawing.Point(40, 563);
            this.AbsenceButton.Name = "AbsenceButton";
            this.AbsenceButton.Size = new System.Drawing.Size(162, 32);
            this.AbsenceButton.TabIndex = 8;
            this.AbsenceButton.Text = "Вiдвiдуванiсть...";
            this.AbsenceButton.UseVisualStyleBackColor = true;
            this.AbsenceButton.Click += new System.EventHandler(this.AbsenceButton_Click);
            // 
            // CurriculumButton
            // 
            this.CurriculumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurriculumButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurriculumButton.ForeColor = System.Drawing.Color.Maroon;
            this.CurriculumButton.Location = new System.Drawing.Point(40, 486);
            this.CurriculumButton.Name = "CurriculumButton";
            this.CurriculumButton.Size = new System.Drawing.Size(162, 32);
            this.CurriculumButton.TabIndex = 7;
            this.CurriculumButton.Text = "Учбовий план...";
            this.CurriculumButton.UseVisualStyleBackColor = true;
            this.CurriculumButton.Click += new System.EventHandler(this.CurriculumButton_Click);
            // 
            // RatingsButton
            // 
            this.RatingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RatingsButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingsButton.ForeColor = System.Drawing.Color.Maroon;
            this.RatingsButton.Location = new System.Drawing.Point(40, 524);
            this.RatingsButton.Name = "RatingsButton";
            this.RatingsButton.Size = new System.Drawing.Size(162, 32);
            this.RatingsButton.TabIndex = 6;
            this.RatingsButton.Text = "Оцiнки...";
            this.RatingsButton.UseVisualStyleBackColor = true;
            this.RatingsButton.Click += new System.EventHandler(this.RatingsButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportButton.ForeColor = System.Drawing.Color.Maroon;
            this.ReportButton.Location = new System.Drawing.Point(16, 314);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(162, 27);
            this.ReportButton.TabIndex = 5;
            this.ReportButton.Text = "Виписка по студенту";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // CharacteristicButton
            // 
            this.CharacteristicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharacteristicButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharacteristicButton.ForeColor = System.Drawing.Color.Maroon;
            this.CharacteristicButton.Location = new System.Drawing.Point(16, 224);
            this.CharacteristicButton.Name = "CharacteristicButton";
            this.CharacteristicButton.Size = new System.Drawing.Size(162, 27);
            this.CharacteristicButton.TabIndex = 4;
            this.CharacteristicButton.Text = "Характеристика";
            this.CharacteristicButton.UseVisualStyleBackColor = true;
            this.CharacteristicButton.Click += new System.EventHandler(this.CharacteristicButton_Click);
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStudentButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditStudentButton.ForeColor = System.Drawing.Color.Maroon;
            this.EditStudentButton.Location = new System.Drawing.Point(16, 148);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(162, 27);
            this.EditStudentButton.TabIndex = 3;
            this.EditStudentButton.Text = "Редагувати студента";
            this.EditStudentButton.UseVisualStyleBackColor = true;
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteStudentButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudentButton.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteStudentButton.Location = new System.Drawing.Point(16, 104);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(162, 27);
            this.DeleteStudentButton.TabIndex = 2;
            this.DeleteStudentButton.Text = "Видалити студента";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentButton.ForeColor = System.Drawing.Color.Maroon;
            this.AddStudentButton.Location = new System.Drawing.Point(16, 61);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(162, 27);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Додати cтудента";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(804, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 613);
            this.panel3.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TermDataGrid);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 105);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.panel7.Size = new System.Drawing.Size(286, 508);
            this.panel7.TabIndex = 8;
            // 
            // TermDataGrid
            // 
            this.TermDataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TermDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TermDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TermDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TermDataGrid.Location = new System.Drawing.Point(10, 5);
            this.TermDataGrid.Name = "TermDataGrid";
            this.TermDataGrid.RowHeadersVisible = false;
            this.TermDataGrid.RowHeadersWidth = 51;
            this.TermDataGrid.Size = new System.Drawing.Size(266, 493);
            this.TermDataGrid.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ShowedTableLabel);
            this.panel6.Controls.Add(this.FilterButton);
            this.panel6.Controls.Add(this.FilterTextBox);
            this.panel6.Controls.Add(this.ShowButton);
            this.panel6.Controls.Add(this.SubjectsRadioButton);
            this.panel6.Controls.Add(this.TermsRadioButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(286, 105);
            this.panel6.TabIndex = 7;
            // 
            // ShowedTableLabel
            // 
            this.ShowedTableLabel.AutoSize = true;
            this.ShowedTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowedTableLabel.Location = new System.Drawing.Point(8, 85);
            this.ShowedTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowedTableLabel.Name = "ShowedTableLabel";
            this.ShowedTableLabel.Size = new System.Drawing.Size(64, 15);
            this.ShowedTableLabel.TabIndex = 15;
            this.ShowedTableLabel.Text = "Перелiк ";
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FilterButton.Location = new System.Drawing.Point(170, 62);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 14;
            this.FilterButton.Text = "Знайти";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(10, 64);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(154, 20);
            this.FilterTextBox.TabIndex = 13;
            // 
            // ShowButton
            // 
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ShowButton.Location = new System.Drawing.Point(169, 19);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(79, 32);
            this.ShowButton.TabIndex = 12;
            this.ShowButton.Text = "Вивести";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // SubjectsRadioButton
            // 
            this.SubjectsRadioButton.AutoSize = true;
            this.SubjectsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectsRadioButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SubjectsRadioButton.Location = new System.Drawing.Point(10, 32);
            this.SubjectsRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectsRadioButton.Name = "SubjectsRadioButton";
            this.SubjectsRadioButton.Size = new System.Drawing.Size(161, 21);
            this.SubjectsRadioButton.TabIndex = 11;
            this.SubjectsRadioButton.Text = "Навчальнi предмети";
            this.SubjectsRadioButton.UseVisualStyleBackColor = true;
            // 
            // TermsRadioButton
            // 
            this.TermsRadioButton.AutoSize = true;
            this.TermsRadioButton.Checked = true;
            this.TermsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermsRadioButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TermsRadioButton.Location = new System.Drawing.Point(10, 10);
            this.TermsRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.TermsRadioButton.Name = "TermsRadioButton";
            this.TermsRadioButton.Size = new System.Drawing.Size(159, 21);
            this.TermsRadioButton.TabIndex = 10;
            this.TermsRadioButton.TabStop = true;
            this.TermsRadioButton.Text = "Навчальнi семестри";
            this.TermsRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddTermButton
            // 
            this.AddTermButton.FlatAppearance.BorderSize = 0;
            this.AddTermButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTermButton.Image = ((System.Drawing.Image)(resources.GetObject("AddTermButton.Image")));
            this.AddTermButton.Location = new System.Drawing.Point(1092, 104);
            this.AddTermButton.Name = "AddTermButton";
            this.AddTermButton.Size = new System.Drawing.Size(28, 28);
            this.AddTermButton.TabIndex = 8;
            this.AddTermButton.UseVisualStyleBackColor = true;
            this.AddTermButton.Click += new System.EventHandler(this.AddTermButton_Click);
            // 
            // DeleteTermButton
            // 
            this.DeleteTermButton.FlatAppearance.BorderSize = 0;
            this.DeleteTermButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTermButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteTermButton.Image")));
            this.DeleteTermButton.Location = new System.Drawing.Point(1092, 138);
            this.DeleteTermButton.Name = "DeleteTermButton";
            this.DeleteTermButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteTermButton.TabIndex = 9;
            this.DeleteTermButton.UseVisualStyleBackColor = true;
            this.DeleteTermButton.Click += new System.EventHandler(this.DeleteTermButton_Click);
            // 
            // EditTermButton
            // 
            this.EditTermButton.FlatAppearance.BorderSize = 0;
            this.EditTermButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTermButton.Image = ((System.Drawing.Image)(resources.GetObject("EditTermButton.Image")));
            this.EditTermButton.Location = new System.Drawing.Point(1092, 172);
            this.EditTermButton.Name = "EditTermButton";
            this.EditTermButton.Size = new System.Drawing.Size(28, 28);
            this.EditTermButton.TabIndex = 10;
            this.EditTermButton.UseVisualStyleBackColor = true;
            this.EditTermButton.Click += new System.EventHandler(this.EditTermButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 613);
            this.Controls.Add(this.EditTermButton);
            this.Controls.Add(this.DeleteTermButton);
            this.Controls.Add(this.AddTermButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал облiку студентiв";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TermDataGrid)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RatingsButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button CharacteristicButton;
        private System.Windows.Forms.Button EditStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView StudentsDataGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView TermDataGrid;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.RadioButton SubjectsRadioButton;
        private System.Windows.Forms.RadioButton TermsRadioButton;
        private System.Windows.Forms.Button AddTermButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Button DeleteTermButton;
        private System.Windows.Forms.Button EditTermButton;
        private System.Windows.Forms.Label ShowedTableLabel;
        private System.Windows.Forms.Button CurriculumButton;
        private System.Windows.Forms.Button AbsenceButton;
        private System.Windows.Forms.Button TermReportButton;
    }
}

