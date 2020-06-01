using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journal
{
    public partial class MainForm : Form
    {
        static string pathToDb = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "journal.mdb");
        public string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathToDb;
        public string activeTable = "term";

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExecuteQuery(string CommandText)
        {
            OleDbConnection QueryConnection = new OleDbConnection(ConnectionString);   //создаём подключение
            QueryConnection.Open();    // открываем подключение
            OleDbCommand myCommand = QueryConnection.CreateCommand();   // создаём команду
            myCommand.CommandText = CommandText;    // текст команды
            myCommand.ExecuteNonQuery();        // выполняем команду
            QueryConnection.Close();        // закрываем соединение
        }

        private void ShowTerms()
        {
            string CommandText = "SELECT * FROM term";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "term"); // заполняем таблицу данными из базы данных 
            TermDataGrid.DataSource = ds.Tables["term"].DefaultView;   // выводим данные в DataGrid на форме
            TermDataGrid.Columns["ID"].Visible = false; // 
            TermDataGrid.Columns["TermName"].HeaderText = "Назва семестру"; // задаём Наменование столбца
            TermDataGrid.Columns["TermName"].Width = 200;  // ширина столбца
        }

        private void ShowSubjects()
        {
            string CommandText = "SELECT * FROM subject ORDER BY SubjectName";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "subject"); // заполняем таблицу Books данными из базы данных 
            TermDataGrid.DataSource = ds.Tables["subject"].DefaultView;   // выводим данные о студентах в DataGrid на форме
            TermDataGrid.Columns["ID"].Visible = false; // 
            TermDataGrid.Columns["SubjectName"].HeaderText = "Назва дiсциплiни"; // задаём Наменование столбца
            TermDataGrid.Columns["SubjectName"].Width = 200;  // ширина столбца
        }

        private void ShowFilter(string commandText)
        {
            string fieldName = activeTable == "term" ? "TermName" : "SubjectName";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, activeTable); // заполняем таблицу данными из базы данных 
            TermDataGrid.DataSource = ds.Tables[activeTable].DefaultView;   // выводим данные в DataGrid на форме
            TermDataGrid.Columns["ID"].Visible = false; // 
            TermDataGrid.Columns[fieldName].HeaderText = activeTable == "term" ? "Назва семестру" : "Назва дiсциплiни"; // Наменование столбца
            TermDataGrid.Columns[fieldName].Width = 200;  // ширина столбца
        }

        private void FilterStudents(string CommandText)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "student"); // заполняем таблицу Books данными из базы данных 
            StudentsDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            StudentsDataGrid.Columns["ID"].Visible = false; // 
            StudentsDataGrid.Columns["StudentName"].HeaderText = "ПIБ студента"; // задаём Наменование столбца
            StudentsDataGrid.Columns["StudentName"].Width = 350;  // ширина столбца 
            StudentsDataGrid.Columns["RecordBook"].HeaderText = "№ залiкової"; // задаём Наменование столбца
            StudentsDataGrid.Columns["RecordBook"].Width = 150;  // ширина столбца 
        }

        private void ShowStudents()
        {
            string CommandText = "SELECT ID, Surname & ' ' & Name & ' ' & Patronymic as StudentName, RecordBook FROM student ORDER BY Surname";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "student"); // заполняем таблицу Books данными из базы данных 
            StudentsDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            StudentsDataGrid.Columns["ID"].Visible = false; // 
            StudentsDataGrid.Columns["StudentName"].HeaderText = "ПIБ студента"; // задаём Наменование столбца
            StudentsDataGrid.Columns["StudentName"].Width = 350;  // ширина столбца 
            StudentsDataGrid.Columns["RecordBook"].HeaderText = "№ залiкової"; // задаём Наменование столбца
            StudentsDataGrid.Columns["RecordBook"].Width = 150;  // ширина столбца 
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            NewStudentForm newStudentForm = new NewStudentForm();
            newStudentForm.ShowDialog();
            if (newStudentForm.DialogResult == DialogResult.OK)
            {
                string CommandText;         //  вводим переменную для записи команды вставки
                string surname = newStudentForm.SurnameTextBox.Text;
                string name = newStudentForm.NameTextBox.Text;
                string patronymic = newStudentForm.PatronymicTextBox.Text;
                string recordbook = newStudentForm.RecordTextBox.Text;
                string phone = newStudentForm.PhoneTextBox.Text;
                string address = newStudentForm.AddressTextBox.Text;
                string passport = newStudentForm.PassportTextBox.Text;
                string taxId = newStudentForm.TaxIdTextBox.Text;
                DateTime birthDate = newStudentForm.BirthDatePicker.Value;
                CommandText = "INSERT INTO Student (Surname,Name,Patronymic,RecordBook,Phone,Address,BirthDate,Passport,taxId)";
                CommandText += "VALUES ('" + surname + "','" + name + "','" + patronymic + "','" + recordbook + "','" + phone + "','";
                CommandText += address + "','" + Convert.ToString(birthDate) + "','" + passport + "','" + taxId + "')";
                ExecuteQuery(CommandText);
                ShowStudents();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowStudents();
            ShowTerms();
            ShowedTableLabel.Text = "Перелiк семестрiв:";
        }

        private void DeleteStudent(int studentId)
        {
            string CommandText = "DELETE FROM student WHERE ID =" + Convert.ToString(studentId);
            ExecuteQuery(CommandText);
            ShowStudents();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT ID, Surname & ' ' & Name & ' ' & Patronymic as StudentName, RecordBook FROM student";
            if (FindTextBox.Text != "")
                CommandText += " WHERE Surname LIKE '" + FindTextBox.Text + "%'";
            CommandText += " ORDER BY Surname";
            FilterStudents(CommandText);
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Ви дiйсно бажаєте видалити обраного студента?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    int index = StudentsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                    int ID = (int)StudentsDataGrid[0, index].Value;
                    DeleteStudent(ID);
                }
            }
            else MessageBox.Show("Не обрано жодного студента!", "Помилка!", MessageBoxButtons.OK);
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.CurrentCell != null)
            {
                int index = StudentsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int ID = (int)StudentsDataGrid[0, index].Value;
                string CommandText = "SELECT * FROM student WHERE ID=" + Convert.ToString(ID); 
                EditStudentForm editForm = new EditStudentForm();

                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = CommandText;
                DbDataReader reader = command.ExecuteReader();
                reader.Read();
                editForm.SurnameTextBox.Text = Convert.ToString(reader["Surname"]);
                editForm.NameTextBox.Text = Convert.ToString(reader["Name"]);
                editForm.PatronymicTextBox.Text = Convert.ToString(reader["Patronymic"]);
                editForm.RecordTextBox.Text = Convert.ToString(reader["RecordBook"]); 
                editForm.PhoneTextBox.Text = Convert.ToString(reader["Phone"]);
                editForm.AddressTextBox.Text =  Convert.ToString(reader["Address"]);
                editForm.BirthDatePicker.Text =  Convert.ToString(reader["BirthDate"]);
                editForm.PassportTextBox.Text =  Convert.ToString(reader["Passport"]);
                editForm.TaxIdTextBox.Text =  Convert.ToString(reader["taxID"]);
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.Yes)
                {
                    DeleteStudent(ID);
                }
                if (editForm.DialogResult == DialogResult.OK)
                {
                    string surname = editForm.SurnameTextBox.Text;
                    string name = editForm.NameTextBox.Text;
                    string patronymic = editForm.PatronymicTextBox.Text;
                    string recordbook = editForm.RecordTextBox.Text;
                    string phone = editForm.PhoneTextBox.Text;
                    string address = editForm.AddressTextBox.Text;
                    DateTime birthDate = editForm.BirthDatePicker.Value;
                    string passport = editForm.PassportTextBox.Text;
                    string taxid = editForm.TaxIdTextBox.Text;
                    CommandText = "UPDATE student SET ";
                    CommandText += "Surname = '" + surname + "', Name = '" + name + "', Patronymic ='" + patronymic + "', RecordBook = '" + recordbook;
                    CommandText += "', Phone = '" + phone + "', Address = '" + address + "', BirthDate = '" + Convert.ToString(birthDate) + "', Passport = '" + passport + "', taxID ='" + taxid+"'";
                    CommandText += " WHERE ID=" + Convert.ToString(ID);
                    ExecuteQuery(CommandText);
                    ShowStudents();
                }
            }
            else MessageBox.Show("Не обрано жодного студента!", "Помилка!", MessageBoxButtons.OK);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (TermsRadioButton.Checked)
            {
                ShowTerms();
                activeTable = "term";
                ShowedTableLabel.Text = "Перелiк семестрiв:";
            }
            else
            {
                ShowSubjects();
                activeTable = "subject";
                ShowedTableLabel.Text = "Перелiк дiсциплiн:";
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string commandText = "SELECT * FROM " + activeTable + " WHERE ";
            commandText += activeTable == "term" ? "TermName":"SubjectName";
            commandText += " LIKE '" + FilterTextBox.Text + "%'";
            ShowFilter(commandText);
        }

        private void AddTermButton_Click(object sender, EventArgs e)
        {
            AddTermForm addForm = new AddTermForm();
            string value = "";
            string commandText, fieldName;
            if (activeTable == "term")
            {
                addForm.Text += "семестру";
                fieldName = "TermName";
            }
            else
            {
                addForm.Text += "дiсциплiни";
                fieldName = "SubjectName";
            }
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK)
                value = addForm.ValueTextBox.Text;
            commandText = "INSERT INTO " + activeTable + "(" + fieldName + ") VALUES ('" + value + "')";
            ExecuteQuery(commandText);
            if (activeTable == "term")
                ShowTerms();
            else ShowSubjects();
        }

        private void EditTermButton_Click(object sender, EventArgs e)
        {
            if (TermDataGrid.CurrentCell != null)
            {
                int index = TermDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int ID = (int)TermDataGrid[0, index].Value;
                string commandText;
                string fieldName = activeTable == "term" ? "TermName" : "SubjectName";
                string editingValue = Convert.ToString(TermDataGrid[1, index].Value);
                AddTermForm editForm = new AddTermForm();
                if (activeTable == "term")
                    editForm.Text = "Редагування семестру";
                else
                    editForm.Text = "Редагування дiсциплiни";
                editForm.ValueTextBox.Text = editingValue;
                editForm.AddButton.Text = "Зберегти";
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK)
                {
                    commandText = "UPDATE " + activeTable + " SET " + fieldName + "=\n'" + editForm.ValueTextBox.Text + "' WHERE ID=" + Convert.ToString(ID);
                    ExecuteQuery(commandText);
                    if (activeTable == "term")
                        ShowTerms();
                    else ShowSubjects();
                    TermDataGrid.ClearSelection();
                    TermDataGrid[1, index].Selected = true;
                }
            }
            else MessageBox.Show("Не обрано даних для редагування!", "Помилка!", MessageBoxButtons.OK);
        }

        private void DeleteTermButton_Click(object sender, EventArgs e)
        {
            if (TermDataGrid.CurrentCell != null)
            {
                string deletingData = activeTable == "term" ? "семестр" : "дiсциплiну";
                DialogResult result = MessageBox.Show("Ви дiйсно бажаєте видалити " + deletingData + "?\nВидаленi данi вiдновити буде неможливо!", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    int index = TermDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                    int termID = (int)TermDataGrid[0, index].Value;
                    string CommandText = "DELETE FROM " + activeTable + " WHERE ID=" + Convert.ToString(termID);
                    ExecuteQuery(CommandText);
                    if (activeTable == "term")
                        ShowTerms();
                    else ShowSubjects();
                }
            }
            else MessageBox.Show("Не обрано жодного запису зi списку!", "Помилка!", MessageBoxButtons.OK);
        }

        private void CurriculumButton_Click(object sender, EventArgs e)
        {
            CurriculumForm planForm = new CurriculumForm();
            planForm.ShowDialog();
        }

        private void RatingsButton_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.CurrentCell != null)
            {
                int index = StudentsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int ID = (int)StudentsDataGrid[0, index].Value;
                string studentName = Convert.ToString(TermDataGrid[1, index].Value);
                GradesForm gradeForm = new GradesForm { studentID = ID };
                gradeForm.StudentNameLabel.Text = studentName;
                gradeForm.ShowDialog();
            }
            else MessageBox.Show("Не обрано студента для внесення оцiнок!", "Помилка!", MessageBoxButtons.OK);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.CurrentCell != null)
            {
                int index = StudentsDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                int ID = (int)StudentsDataGrid[0, index].Value;
                string studentName = Convert.ToString(StudentsDataGrid[0, index].Value);
                ReportForm reportForm = new ReportForm { studentID = ID};
                reportForm.StudentNameLabel.Text = studentName;
                reportForm.ShowDialog();
            }
            else MessageBox.Show("Не обрано студента для формування виписки!", "Помилка!", MessageBoxButtons.OK);
        }

        private void AbsenceButton_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.CurrentCell != null)
            {
                int index = StudentsDataGrid.CurrentCell.RowIndex;
                int ID = (int)StudentsDataGrid[0, index].Value;
                string studentName = Convert.ToString(StudentsDataGrid[1, index].Value);
                AbsenceForm absenceForm = new AbsenceForm { studentID = ID};
                absenceForm.StudentNameLabel.Text = studentName;
                absenceForm.ShowDialog();
            }
            else MessageBox.Show("Не обрано студента для внесення даних!", "Помилка!", MessageBoxButtons.OK);
        }
    }
}