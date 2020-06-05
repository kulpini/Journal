using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journal
{
    public partial class TermReportForm : Form
    {
        int[] subjectID;
        public int termId;
        private Bitmap memoryImage;
        public TermReportForm()
        {
            InitializeComponent();
        }

        private int GetSubjectCount()
        {
            string commandText = "SELECT count(ID) FROM academic ";
            commandText += " WHERE termID=" + Convert.ToString(termId);
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.ConnectionString);
            OleDbCommand command = new OleDbCommand(commandText, connection);
            connection.Open();
            return (int)command.ExecuteScalar();
        }

        private void FillTheRow(int rowIndex,int studentId)
        {
            foreach (int id in subjectID)
            { 
                string commandText = "SELECT score FROM examination WHERE termID="+Convert.ToString(termId)+" AND studentID="+Convert.ToString(studentId)+" AND subjectID="+Convert.ToString(id);
                MainForm form = new MainForm();
                OleDbConnection connection = new OleDbConnection(form.ConnectionString);
                OleDbCommand command = new OleDbCommand(commandText, connection);
                connection.Open();
                int score = command.ExecuteScalar()==null ? 0 : (int)command.ExecuteScalar();
                if (score==0)
                    ReportDataGrid.Rows[rowIndex].Cells[Convert.ToString(id)].Value = "";
                else
                    ReportDataGrid.Rows[rowIndex].Cells[Convert.ToString(id)].Value = score;
            }
        }

        private void MakeHeaders()
        {
            ReportDataGrid.Columns.Add("count","№");
            ReportDataGrid.Columns["count"].Width = 20;
            ReportDataGrid.Columns.Add("name", "ПIБ");
            ReportDataGrid.Columns["name"].Width = 280;
            ReportDataGrid.Columns.Add("hours","Пропущено");
            ReportDataGrid.Columns["hours"].Width = 30;
            string commandText1 = "SELECT s.ID,s.SubjectName FROM academic a,subject s";
            commandText1 += " WHERE a.termID=" + Convert.ToString(termId) + " AND s.ID=a.subjectID AND a.exam=false";
            string commandText2 = "SELECT s.ID,s.SubjectName FROM academic a,subject s";
            commandText2 += " WHERE a.termID=" + Convert.ToString(termId) + " AND s.ID=a.subjectID AND a.exam=true";
            string commandText = commandText1 + " UNION ALL " + commandText2;
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.ConnectionString);
            OleDbCommand command = new OleDbCommand(commandText, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            subjectID = new int[GetSubjectCount()];
            int i = 0;
            while (reader.Read())
            {
                ++i;
                ReportDataGrid.Columns.Add(Convert.ToString(reader.GetInt32(0)), reader.GetString(1));
                ReportDataGrid.Columns[Convert.ToString(reader.GetInt32(0))].Width = 30;
                subjectID[i - 1] = reader.GetInt32(0);
            }
        }

        private void MakeRows()
        {
            string commandText = "SELECT s.ID,s.Surname & ' ' & s.Name & ' ' & s.Patronymic as StudentName,a.hours FROM absence a,student s";
            commandText += " WHERE a.termID=" + Convert.ToString(termId) + " AND s.ID=a.studentID ORDER BY Surname,Name,Patronymic";
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.ConnectionString);
            OleDbCommand command = new OleDbCommand(commandText, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            int rowNumber;
            while (reader.Read())
            {
                rowNumber = ReportDataGrid.Rows.Add();
                ReportDataGrid.Rows[rowNumber].Cells["count"].Value = rowNumber + 1;
                ReportDataGrid.Rows[rowNumber].Cells["name"].Value = reader.GetString(1);
                ReportDataGrid.Rows[rowNumber].Cells["hours"].Value = reader.GetInt32(2);
                FillTheRow(rowNumber,reader.GetInt32(0));
            }
        }

        private void TermReportForm_Load(object sender, EventArgs e)
        {
            ReportDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            MakeHeaders();
            MakeRows();
        }

        private void ReportDataGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex < ReportDataGrid.Columns.Count)
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.TranslateTransform(e.CellBounds.Left, e.CellBounds.Bottom);
                e.Graphics.RotateTransform(270);
                e.Graphics.DrawString(e.FormattedValue?.ToString(), e.CellStyle.Font, Brushes.Black, 5, 5);
                e.Graphics.ResetTransform();
                e.Handled = true;
                ReportDataGrid.ColumnHeadersHeight = 100;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowHelp = true;
            printDialog.Document = printDocument;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(ReportDataGrid.Size.Width + 10, ReportDataGrid.Size.Height + 10);
            ReportDataGrid.DrawToBitmap(bmp, ReportDataGrid.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
