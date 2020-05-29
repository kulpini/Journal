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
    public partial class GradesForm : Form
    {
        public int studentID;
        private int termID;
        public GradesForm()
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

        private void ShowScores()
        {
            MainForm form = new MainForm();
            string commandText = "SELECT e.ID,s.SubjectName,e.score FROM examination e,subject s WHERE s.ID=e.subjectID AND e.termID=" + Convert.ToString(termID) + " AND e.studentID="+ Convert.ToString(studentID) +" ORDER BY SubjectName";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "examination"); // заполняем таблицу Books данными из базы данных 
            ScoreDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            ScoreDataGrid.Columns["ID"].Visible = false; // 
            ScoreDataGrid.Columns["SubjectName"].HeaderText = "Дисциплiна"; // задаём Наменование столбца
            ScoreDataGrid.Columns["SubjectName"].Width = 200;  // ширина столбца  
            ScoreDataGrid.Columns["score"].HeaderText = "Оцiнка"; // задаём Наменование столбца
            ScoreDataGrid.Columns["score"].Width = 60;  // ширина столбца
        }

        private void ShowSubjects(int termId)
        {
            MainForm form = new MainForm();
            string commandText = "SELECT a.ID,s.SubjectName,a.exam FROM academic a,subject s WHERE s.ID=a.subjectID AND a.termID=" + Convert.ToString(termId) + " ORDER BY SubjectName";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "academic"); // заполняем таблицу Books данными из базы данных 
            SubjectsDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            SubjectsDataGrid.Columns["ID"].Visible = false; // 
            SubjectsDataGrid.Columns["SubjectName"].HeaderText = "Дисциплiна"; // задаём Наменование столбца
            SubjectsDataGrid.Columns["SubjectName"].Width = 200;  // ширина столбца  
            SubjectsDataGrid.Columns["exam"].HeaderText = "Екзамен"; // задаём Наменование столбца
            SubjectsDataGrid.Columns["exam"].Width = 60;  // ширина столбца
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            string commandText = "SELECT * FROM term";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "term"); // заполняем таблицу Books данными из базы данных 
            TermDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            TermDataGrid.Columns["ID"].Visible = false; // 
            TermDataGrid.Columns["TermName"].HeaderText = "Семестри"; // задаём Наменование столбца
            TermDataGrid.Columns["TermName"].Width = 120;  // ширина столбца
        }

        private void TermDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = TermDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
            termID = (int)TermDataGrid[0, index].Value;
            ShowSubjects(termID);
            ShowScores();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (SubjectsDataGrid.CurrentCell != null)
            {
                int score = Convert.ToInt32(GradeTextBox.Text);
                int index = SubjectsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int subjectID = (int)SubjectsDataGrid[0, index].Value;
                string commandText = "INSERT INTO examination (studentID, termID, subjectID, score) VALUES ("+studentID+","+termID+","+ subjectID + ","+score+")";
                ExecuteQuery(commandText);
                ShowSubjects(termID);
                ShowScores();
            }
            else MessageBox.Show("Не обрана дисциплiна!", "Помилка!", MessageBoxButtons.OK);
        }
    }
}
