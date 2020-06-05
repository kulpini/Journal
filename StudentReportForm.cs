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
    public partial class StudentReportForm : Form
    {
        public int studentId;
        private int[] subjectID;
        public StudentReportForm()
        {
            InitializeComponent();
        }

        private int GetSubjectsCount()
        {
            string commandText = "SELECT count(ID) FROM subject";
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.ConnectionString);
            OleDbCommand command = new OleDbCommand(commandText, connection);
            connection.Open();
            return (int)command.ExecuteScalar();
        }

        private void FillTheRow(int rowIndex, int termId)
        {
            foreach (int id in subjectID)
            {
                string commandText = "SELECT score FROM examination WHERE termID=" + Convert.ToString(termId) + " AND studentID=" + Convert.ToString(studentId) + " AND subjectID=" + Convert.ToString(id);
                MainForm form = new MainForm();
                OleDbConnection connection = new OleDbConnection(form.ConnectionString);
                OleDbCommand command = new OleDbCommand(commandText, connection);
                connection.Open();
                int score = command.ExecuteScalar() == null ? 0 : (int)command.ExecuteScalar();
                if (score == 0)
                    ReportDataGrid.Rows[rowIndex].Cells[Convert.ToString(id)].Value = "";
                else
                    ReportDataGrid.Rows[rowIndex].Cells[Convert.ToString(id)].Value = score;
            }
        }

        private void MakeHeaders()
        {
            ReportDataGrid.Columns.Add("count", "№");
            ReportDataGrid.Columns["count"].Width = 20;
            ReportDataGrid.Columns.Add("term", "");
            ReportDataGrid.Columns["term"].Width = 120;
            ReportDataGrid.Columns.Add("hours", "Пропущено");
            ReportDataGrid.Columns["hours"].Width = 30;
            string commandText = "SELECT ID,SubjectName FROM subject ORDER BY SubjectName";
            MainForm form = new MainForm();
            OleDbConnection connection = new OleDbConnection(form.ConnectionString);
            OleDbCommand command = new OleDbCommand(commandText, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            subjectID = new int[GetSubjectsCount()];
            int i = 0;
            while (reader.Read())
            {
                i++;
                ReportDataGrid.Columns.Add(Convert.ToString(reader.GetInt32(0)), reader.GetString(1));
                ReportDataGrid.Columns[Convert.ToString(reader.GetInt32(0))].Width = 30;
                subjectID[i - 1] = reader.GetInt32(0);
            }
        }

        private void MakeRows()
        {
            string commandText = "SELECT t.ID,t.TermName,a.hours FROM absence a,term t";
            commandText += " WHERE a.termID=t.ID AND a.studentID="+Convert.ToString(studentId);
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
                ReportDataGrid.Rows[rowNumber].Cells["term"].Value = reader.GetString(1);
                ReportDataGrid.Rows[rowNumber].Cells["hours"].Value = reader.GetInt32(2);
                FillTheRow(rowNumber, reader.GetInt32(0));
            }
        }

        private void StudentReportForm_Load(object sender, EventArgs e)
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

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(ReportDataGrid.Size.Width + 10, ReportDataGrid.Size.Height + 10);
            ReportDataGrid.DrawToBitmap(bmp, ReportDataGrid.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
