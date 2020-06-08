using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journal
{
    public partial class CharacteristicForm : Form
    {
        public int studentId;
        public CharacteristicForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string fileName = StudentNameLabel.Text + " ID-" + Convert.ToString(studentId) + ".rtf";
            string savePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            CharacteristicRichText.SaveFile(savePath);
            MessageBox.Show("Данi збережено !", "", MessageBoxButtons.OK);
        }

        private void CharacteristicForm_Load(object sender, EventArgs e)
        {
            string fileName = StudentNameLabel.Text + " ID-" + Convert.ToString(studentId) + ".rtf";
            string loadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            if (File.Exists(loadPath))
                CharacteristicRichText.LoadFile(loadPath);
        }
    }
}
