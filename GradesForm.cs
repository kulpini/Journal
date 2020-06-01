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
        private int examinationID;
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
            string commandText = "SELECT e.ID,s.SubjectName,e.score FROM examination e,subject s WHERE s.ID=e.subjectID AND e.termID=" + Convert.ToString(termID) + " AND e.studentID=" + Convert.ToString(studentID) + " ORDER BY SubjectName";
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
            string scoresString = "SELECT subjectId FROM examination WHERE termID = " + Convert.ToString(termId) + " AND studentID=" + Convert.ToString(studentID);
            string commandText = "SELECT a.subjectID,s.SubjectName,a.exam FROM academic a,subject s ";
            commandText += "WHERE s.ID=a.subjectID AND a.termID=" + Convert.ToString(termId);
            commandText += " AND a.subjectID NOT IN (" + scoresString + ")";
            commandText += " ORDER BY SubjectName";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "academic"); // заполняем таблицу Books данными из базы данных 
            SubjectsDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            SubjectsDataGrid.Columns["subjectID"].Visible = false;
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
                string score = GradeTextBox.Text;
                int index = SubjectsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int subjectID = (int)SubjectsDataGrid[0, index].Value;
                string commandText = "INSERT INTO examination (studentID, termID, subjectID, score) VALUES (" + Convert.ToString(studentID) + "," + Convert.ToString(termID) + "," + Convert.ToString(subjectID) + "," + score + ")";
                ExecuteQuery(commandText);
                ShowSubjects(termID);
                ShowScores();
                GradeTextBox.Clear();
            }
            else MessageBox.Show("Не обрана дисциплiна!", "Помилка!", MessageBoxButtons.OK);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ScoreDataGrid.CurrentCell != null)
            {
                if (EditGradeTextBox.Text !="")
                {
                    string score = EditGradeTextBox.Text;
                    string commandText = "UPDATE examination SET score=" + score+" WHERE ID="+Convert.ToString(examinationID);
                    ExecuteQuery(commandText);
                    ShowScores();
                    EditGradeTextBox.Clear();
                }
                else MessageBox.Show("Не задана оцiнка для редагування!", "Помилка!", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Не обрана дисциплiна для редагування оцiнки!", "Помилка!", MessageBoxButtons.OK);
        }

        private void ScoreDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = ScoreDataGrid.CurrentCell.RowIndex;
            string score = Convert.ToString(ScoreDataGrid[2, index].Value);
            examinationID = (int)ScoreDataGrid[0, index].Value;
            EditGradeTextBox.Text = score;
        }
    }
}
