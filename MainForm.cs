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

        private void MyExecuteNonQuery(string CommandText)
        {
            OleDbConnection QueryConnection = new OleDbConnection(ConnectionString);   //создаём подключение
            QueryConnection.Open();    // открываем подключение
            OleDbCommand myCommand = QueryConnection.CreateCommand();   // создаём команду
            myCommand.CommandText = CommandText;    // текст команды
            myCommand.ExecuteNonQuery();        // выполняем команду
            QueryConnection.Close();        // закрываем соединение
        }

        private void ShowStudents(string CommandText)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);   //создаём адаптер данных и считываем данные помощью запроса
            DataSet ds = new DataSet();  // создаем объект DataSet
            dataAdapter.Fill(ds, "student"); // заполняем таблицу Books данными из базы данных 
            StudentsDataGrid.DataSource = ds.Tables[0].DefaultView;   // выводим данные о студентах в DataGrid на форме

            //StudentsDataGrid.Columns["Surname"].HeaderText = "Прiзвище"; // задаём Наменование столбца
            //StudentsDataGrid.Columns["Surname"].Width = 200;  // ширина столбца 
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
                CommandText += address+"','"+Convert.ToString(birthDate) + "','"+passport+ "',"+Convert.ToString(taxId) +")";
                MyExecuteNonQuery(CommandText);
                CommandText = "SELECT ID, Surname,Name,Patronymic, RecordBook FROM student";
                ShowStudents(CommandText);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string CommandText = "SELECT ID, Surname,Name,Patronymic, RecordBook FROM student";
            ShowStudents(CommandText);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT ID, Surname,Name,Patronymic, RecordBook FROM student";
            if (FindTextBox.Text!="")
                CommandText += " WHERE Surname LIKE '"+ FindTextBox.Text+"'";
            ShowStudents(CommandText);
        }
    }
}
