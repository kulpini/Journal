namespace journal
{
    partial class CharacteristicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacteristicForm));
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.CharacteristicRichText = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StudentNameLabel.Location = new System.Drawing.Point(15, 11);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(788, 23);
            this.StudentNameLabel.TabIndex = 2;
            this.StudentNameLabel.Text = "label1";
            this.StudentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharacteristicRichText
            // 
            this.CharacteristicRichText.Location = new System.Drawing.Point(20, 54);
            this.CharacteristicRichText.Name = "CharacteristicRichText";
            this.CharacteristicRichText.Size = new System.Drawing.Size(801, 438);
            this.CharacteristicRichText.TabIndex = 3;
            this.CharacteristicRichText.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.Maroon;
            this.SaveButton.Location = new System.Drawing.Point(286, 508);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(216, 33);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Зберегти";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CharacteristicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 554);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CharacteristicRichText);
            this.Controls.Add(this.StudentNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacteristicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Характеристика студента";
            this.Load += new System.EventHandler(this.CharacteristicForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.RichTextBox CharacteristicRichText;
        private System.Windows.Forms.Button SaveButton;
    }
}