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
    public partial class CurriculumForm : Form
    {
        private int termId;
        public CurriculumForm()
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

        private void ShowSubjects(int termId)
        {
            MainForm form = new MainForm();
            string commandText = "SELECT a.ID,s.SubjectName,a.exam FROM academic a,subject s WHERE s.ID=a.subjectID AND a.termID=" + Convert.ToString(termId) + " ORDER BY SubjectName";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, form.ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "academic"); // заполняем таблицу Books данными из базы данных 
            SubjectDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            SubjectDataGrid.Columns["ID"].Visible = false; // 
            SubjectDataGrid.Columns["SubjectName"].HeaderText = "Дисциплiна"; // задаём Наменование столбца
            SubjectDataGrid.Columns["SubjectName"].Width = 200;  // ширина столбца  
            SubjectDataGrid.Columns["exam"].HeaderText = "Екзамен"; // задаём Наменование столбца
            SubjectDataGrid.Columns["exam"].Width = 60;  // ширина столбца
        }

        private void CurriculumForm_Load(object sender, EventArgs e)
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
            termId = (int)TermDataGrid[0, index].Value;
            ShowSubjects(termId);
        }

        private void CheckSubjectButton_Click(object sender, EventArgs e)
        {
            if (SubjectDataGrid.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Встановити дисциплiну як екзаменацiйну?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    int index = SubjectDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                    int ID = (int)SubjectDataGrid[0, index].Value;
                    bool exam = Convert.ToBoolean(SubjectDataGrid[2, index].Value);
                    string commandText = "UPDATE academic SET exam =" + Convert.ToString(!exam) + " WHERE subjectID=" + Convert.ToString(ID);
                    ExecuteQuery(commandText);
                    ShowSubjects(termId);
                }
            }
            else MessageBox.Show("Не обрано жодної дисциплiни!", "Помилка!", MessageBoxButtons.OK);
        }

        private void EditSubjectButton_Click(object sender, EventArgs e)
        {
            if (TermDataGrid.CurrentCell != null)
            {
                int index = TermDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int ID = (int)TermDataGrid[0, index].Value;
                string termName = Convert.ToString(TermDataGrid[1, index].Value);
                AcademicListForm listForm = new AcademicListForm { termID = ID };
                listForm.AcademicTermLabel.Text += termName + "у";
                listForm.ShowDialog();
                ShowSubjects(termId);
            }
            else MessageBox.Show("Не обрано семестр зi списку!", "Помилка!", MessageBoxButtons.OK);
        }
    }
}
