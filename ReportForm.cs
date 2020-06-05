using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journal
{
    public partial class ReportForm : Form
    {
        public int termId;
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            string commandText = "SELECT st.Surname,ab.hours,s.SubjectName FROM student st,absence ab,subject s";
            commandText += " WHERE ab.termID=" + Convert.ToString(termId) + " AND st.ID=ab.studentID";
            //commandText += " AND ac.subjectID=s.ID";
            MainForm form = new MainForm();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "student"); // заполняем таблицу Books данными из базы данных 
            ReportDataGrid.DataSource = ds.Tables[0].DefaultView;

        }
    }
}
