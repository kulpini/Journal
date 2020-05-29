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
    public partial class AcademicListForm : Form
    {
        public int termID;
        public AcademicListForm()
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

        private void ShowSubjectList()
        {
            MainForm form = new MainForm();
            string commandText = "SELECT * FROM subject WHERE ID NOT IN (SELECT subjectID FROM academic WHERE termID=" + Convert.ToString(termID) + ") ORDER BY SubjectName";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "subject"); // заполняем таблицу Books данными из базы данных
            SubjectListDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            SubjectListDataGrid.Columns["ID"].Visible = false; // 
            SubjectListDataGrid.Columns["SubjectName"].HeaderText = "Дисциплiна"; // задаём Наменование столбца
            SubjectListDataGrid.Columns["SubjectName"].Width = 200;  // ширина столбца 
        }

        private void ShowAcademic()
        {
            MainForm form = new MainForm();
            string commandText = "SELECT a.subjectID,s.SubjectName FROM academic a,subject s WHERE s.ID=a.subjectID and a.termID=" + Convert.ToString(termID) + " ORDER BY SubjectName";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "academic"); // заполняем таблицу Books данными из базы данных
            AcademicDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            AcademicDataGrid.Columns["subjectID"].Visible = false; // 
            AcademicDataGrid.Columns["SubjectName"].HeaderText = "Дисциплiна"; // задаём Наменование столбца
            AcademicDataGrid.Columns["SubjectName"].Width = 200;  // ширина столбца 
        }

        private void AcademicListForm_Load(object sender, EventArgs e)
        {
            ShowAcademic();
            ShowSubjectList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (SubjectListDataGrid.CurrentCell != null)
            {
                int index = SubjectListDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int subjectID = (int)SubjectListDataGrid[0, index].Value;
                string commandText = "INSERT INTO academic (subjectID,termID) VALUES ("+Convert.ToString(subjectID)+"," +Convert.ToString(termID)+")";
                ExecuteQuery(commandText);
                ShowAcademic();
                ShowSubjectList();
            }
            else MessageBox.Show("Не обрано дисциплiну зi списку!", "Помилка!", MessageBoxButtons.OK);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (AcademicDataGrid.CurrentCell != null)
            {
                int index = AcademicDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int subjectID = (int)AcademicDataGrid[0, index].Value;
                string commandText = "DELETE FROM academic WHERE subjectID="+Convert.ToString(subjectID);
                ExecuteQuery(commandText);
                ShowAcademic();
                ShowSubjectList();
            }
            else MessageBox.Show("Не обрано дисциплiну зi списку!", "Помилка!", MessageBoxButtons.OK);
        }
    }
}
