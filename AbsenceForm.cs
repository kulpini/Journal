using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journal
{
    public partial class AbsenceForm : Form
    {
        public int studentID;
        public AbsenceForm()
        {
            InitializeComponent();
        }

        private void ExecuteQuery(string CommandText)
        {
            MainForm form = new MainForm();
            OleDbConnection QueryConnection = new OleDbConnection(form.ConnectionString);   //создаём подключение
            QueryConnection.Open();    // открываем подключение
            OleDbCommand myCommand = QueryConnection.CreateCommand();   // создаём команду
            myCommand.CommandText = CommandText;    // текст команды
            myCommand.ExecuteNonQuery();        // выполняем команду
            QueryConnection.Close();        // закрываем соединение
        }

        private void ShowAbsence()
        {
            string commandText = "SELECT a.ID, t.TermName, a.hours FROM absence a,term t WHERE t.ID=a.termID AND a.studentID="+Convert.ToString(studentID);
            MainForm form = new MainForm();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, form.ConnectionString);   
            DataSet ds = new DataSet();  
            dataAdapter.Fill(ds, "absence"); 
            AbsenceDataGrid.DataSource = ds.Tables[0].DefaultView;
            AbsenceDataGrid.Columns["ID"].Visible = false; // 
            AbsenceDataGrid.Columns["TermName"].HeaderText = "Семестр";
            AbsenceDataGrid.Columns["TermName"].Width = 120;
            AbsenceDataGrid.Columns["hours"].HeaderText = "Пропущено год.";
            AbsenceDataGrid.Columns["hours"].Width = 80;  
        }

        private void AbsenceForm_Load(object sender, EventArgs e)
        {
            string commandText = "SELECT count(ID) FROM absence WHERE studentId=" + Convert.ToString(studentID);
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.ConnectionString);
            OleDbCommand command = new OleDbCommand(commandText,connection);
            connection.Open();
            int rowCount;
            rowCount = Convert.ToInt32(command.ExecuteScalar());
            if (rowCount == 0)
            {
                commandText = "INSERT INTO absence(studentID,termId,hours) SELECT "+Convert.ToString(studentID) +",ID,0 FROM term";
                ExecuteQuery(commandText);
            }
            ShowAbsence();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AbsenceDataGrid.CurrentCell != null)
            {
                int index = AbsenceDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int ID = (int)AbsenceDataGrid[0, index].Value;
                string commandText = "UPDATE absence SET hours="+HoursTextBox.Text+" WHERE ID="+Convert.ToString(ID);
                ExecuteQuery(commandText);
                HoursTextBox.Clear();
                ShowAbsence();
            }
            else MessageBox.Show("Не обран навчальний семестр!", "Помилка!", MessageBoxButtons.OK);
        }
    }
}
