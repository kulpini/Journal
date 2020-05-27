using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journal
{
    public partial class MainForm : Form
    {
        static string pathToDb = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "journal.mdb");
        public string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathToDb;
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
            string CommandText = "SELECT * FROM terms";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "term"); // заполняем таблицу Books данными из базы данных 
            TermDataGrid.DataSource = ds.Tables["term"].DefaultView;   // выводим данные о студентах в DataGrid на форме
            TermDataGrid.Columns["ID"].Visible = false; // 
            TermDataGrid.Columns["TermName"].HeaderText = "Назва семестру"; // задаём Наменование столбца
            TermDataGrid.Columns["TermName"].Width = 200;  // ширина столбца
        }

        private void ShowStudents(string CommandText)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "student"); // заполняем таблицу Books данными из базы данных 
            StudentsDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме
            StudentsDataGrid.Columns["ID"].Visible = false; // 
            StudentsDataGrid.Columns["Surname"].HeaderText = "Прiзвище"; // задаём Наменование столбца
            StudentsDataGrid.Columns["Surname"].Width = 200;  // ширина столбца 
            StudentsDataGrid.Columns["Name"].HeaderText = "Iм`я"; // задаём Наменование столбца
            StudentsDataGrid.Columns["Name"].Width = 200;  // ширина столбца 
            StudentsDataGrid.Columns["Patronymic"].HeaderText = "По-батьковi"; // задаём Наменование столбца
            StudentsDataGrid.Columns["Patronymic"].Width = 200;  // ширина столбца 
            StudentsDataGrid.Columns["RecordBook"].HeaderText = "№ залiкової"; // задаём Наменование столбца
            StudentsDataGrid.Columns["RecordBook"].Width = 200;  // ширина столбца 
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
                int taxId = int.Parse(newStudentForm.TaxIdTextBox.Text);
                DateTime birthDate = newStudentForm.BirthDatePicker.Value;
                CommandText = "INSERT INTO Student (Surname,Name,Patronymic,RecordBook,Phone,Address,BirthDate,Passport,taxId)";
                CommandText += "VALUES ('" + surname + "','" + name + "','" + patronymic + "','" + recordbook + "','" + phone + "','";
                CommandText += address + "','" + Convert.ToString(birthDate) + "','" + passport + "'," + Convert.ToString(taxId) + ")";
                ExecuteQuery(CommandText);
                CommandText = "SELECT ID, Surname,Name,Patronymic, RecordBook FROM student";
                ShowStudents(CommandText);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string CommandText = "SELECT ID, Surname,Name,Patronymic, RecordBook FROM student";
            ShowStudents(CommandText);
            ShowTerms();
        }

        private void DeleteStudent(int studentId)
        {
            string CommandText = "DELETE FROM student WHERE ID =" + Convert.ToString(studentId);
            ExecuteQuery(CommandText);
            CommandText = "SELECT ID, Surname,Name,Patronymic, RecordBook FROM student";
            ShowStudents(CommandText);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT ID, Surname,Name,Patronymic, RecordBook FROM student";
            if (FindTextBox.Text != "")
                CommandText += " WHERE Surname LIKE '" + FindTextBox.Text + "'";
            ShowStudents(CommandText);
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
                string CommandText;
                EditStudentForm editForm = new EditStudentForm();
                CommandText = "SELECT * FROM student WHERE ID=" + Convert.ToString(ID);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
                DataSet ds = new DataSet();  // создаем объект DataSet
                dataAdapter.Fill(ds, "student"); // заполняем таблицу Books данными из базы данных 
                editForm.SurnameTextBox.Text = Convert.ToString(ds.Tables["student"].Columns["Surname"].DefaultValue);
                editForm.NameTextBox.Text = Convert.ToString(ds.Tables["student"].Columns["Name"].DefaultValue);
                editForm.PatronymicTextBox.Text = Convert.ToString(ds.Tables["student"].Columns["Patronymic"].DefaultValue);
                editForm.RecordTextBox.Text = Convert.ToString(ds.Tables["student"].Columns["RecordBook"].DefaultValue);
                editForm.PhoneTextBox.Text = Convert.ToString(ds.Tables["student"].Columns["Phone"].DefaultValue);
                editForm.AddressTextBox.Text = Convert.ToString(ds.Tables["student"].Columns["Address"].DefaultValue);
                editForm.BirthDatePicker.Text = Convert.ToString(ds.Tables["student"].Columns["BirthDate"].DefaultValue);
                editForm.PassportTextBox.Text = Convert.ToString(ds.Tables["student"].Columns["Passport"].DefaultValue);
                editForm.TaxIdTextBox.Text = Convert.ToString(ds.Tables["student"].Columns["taxID"].DefaultValue);
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
                    string birthday = editForm.BirthDatePicker.Text;
                    string passport = editForm.PassportTextBox.Text;
                    string taxid = editForm.TaxIdTextBox.Text;
                    CommandText = "UPDATE student SET ";
                    CommandText += "Surname = '" + surname + "', Name = '" + name + "', Patronymic ='" + patronymic + "', RecordBook = '" + recordbook;
                    CommandText += "', Phone = '" + phone + "', Address = '" + address + "', BirthDate = '" + birthday + "', Passport = '" + passport + "', taxID =" + taxid;
                    CommandText += " WHERE ID=" + Convert.ToString(ID);
                    ExecuteQuery(CommandText);
                    CommandText = "SELECT ID, Surname,Name,Patronymic, RecordBook FROM student";
                    ShowStudents(CommandText);
                }
            }
            else MessageBox.Show("Не обрано жодного студента!", "Помилка!", MessageBoxButtons.OK);
        }

        private void DeleteTermButton_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Ви дiйсно бажаєте видалити семестр? \n Видаленi данi вiдновити буде неможливо!", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    int index = TermDataGrid.CurrentCell.RowIndex;   // № по порядку в таблице представления
                    int termID = (int)TermDataGrid[0, index].Value;
                    string CommandText = "DELETE FROM term WHERE ID=" + Convert.ToString(termID);
                    ShowTerms();
                }
            }
            else MessageBox.Show("Не обрано семестр зi списку!", "Помилка!", MessageBoxButtons.OK);
        }


        private void EditTermButton_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.CurrentCell != null)
            {
                //gbtjy
            }
            else MessageBox.Show("Не обрано семестр зi списку!", "Помилка!", MessageBoxButtons.OK);
        }
    }
}