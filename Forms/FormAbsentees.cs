﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using ExcelDataReader;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormAbsentees : Form
    {
        public FormAbsentees()
        {
            InitializeComponent();
        }

        private void FormAbsentees_Load(object sender, EventArgs e)
        {
            labelAbsenteesDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })  //Filter for excel file
            {
                //RETRIEVING EXCEL FILE  AND ITS DATA
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    txtFilename.Text = openFileDialog.FileName; // 'txtFilename.Text' is the selected excel file
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read)) //Opens and Read access to the excel file
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()   //Converts selected sheet into DataSet
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }   //Gets or sets data of selected of excel file
                            });
                            tableCollection = result.Tables;    //Gets the collection of tables
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName);    //Adds the sheet to combobox

                        }
                    }
                }
            }
        }

        private void cboSheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected excel sheet
            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            dv.RowFilter = "Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'" + "AND Status = 'Absent'";
            dataGridView2.DataSource = dt;   //Gets or sets data that the DataGridView displays
        }
        DataTableCollection tableCollection;    //Collection of tables for the DataSet

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DataGridViewColumn column2 = dataGridView2.Columns[1];   //Sets Width size of a column
            column2.Width = 200;

            dataGridView2.Columns[4].DefaultCellStyle.Format = "HH:mm:ss tt";   //Setting the format of Time column on excel
            dataGridView2.Columns[8].DefaultCellStyle.Format = "HH:mm:ss tt";   //Setting the format of Time column on excel
            dataGridView2.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";    //Setting the format of Date column on excel
            dataGridView2.Columns["ID Number"].Visible = false;     //Hide a specific column
            dataGridView2.Columns["VerifyCode"].Visible = false;    //Hide a specific column    
            dataGridView2.Columns["CardNo"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Location ID"].Visible = false;   //Hide a specific column
            dataGridView2.Columns["LateTime"].Visible = false;  //Hide a specific column
            dataGridView2.Columns["AbsentTime"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Time-Out"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Time-Out-Status"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Overtime"].Visible = false;    //Hide a specific column



            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            //SETS AND CHANGE ROWS BACKGROUND COLOR OR FOREGROUND COLOR
            if (this.dataGridView2.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                //GREEN IS PRESENT
                //YELLOW IS LATE
                //RED IS ABSENT

                var onTime = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["Time-In"].Value);    //Arrival Time of staff
                var lateTime = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["LateTime"].Value);  //Late time is set to 8:08 AM
                var absentTime = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["AbsentTime"].Value);  //Late time is set to 12:00 AM in excel but when the program is executed in
                                                                                                                //DataGridView it'll be set to 00:00 AM which means the staff is absent

                if (onTime <= lateTime)
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                if (onTime > lateTime)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                if (onTime == absentTime)
                {
                    e.CellStyle.BackColor = Color.Red;

                }
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            // get the name of the user in local disk c and store it in a variable
            // this is to save the excel file in the local disk c Downloads folder
            string serverName = Environment.UserName;

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program  
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            // changing the name of active sheet  
            worksheet.Name = "Sheet 1 Exported";

            // storing header part in Excel
            /* export all column header
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }*/

            // export only the column header visible
            for (int i = 1; i < 7; i++)
            {
                worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
            }

            List<DataGridViewColumn> listVisible = new List<DataGridViewColumn>();

            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                if (col.Visible)
                    listVisible.Add(col);
            }

            for (int i = 0; i < listVisible.Count; i++)
            {
                worksheet.Cells[1, i + 1] = listVisible[i].HeaderText;
            }

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < listVisible.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[listVisible[j].Name].Value.ToString();
                }
            }

            /* storing Each row and column value to excel sheet and printing all columns
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }*/

            DateTime localDate = DateTime.Now;
            // save the excel file
            workbook.SaveAs("C:\\Users\\" + serverName + "\\Downloads\\Absentees-Output.xlsx " + " - " + localDate + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = sortComboBox.SelectedItem.ToString();     //Selected combobox item
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet


            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            //SORTS THE COLUMN 'NAME'
            if (selectedItem == "All")
            {
                dv.RowFilter = "Status = 'Absent'";
                dataGridView2.DataSource = dv.ToTable(); //Creates and returns a new DataTable base on rows in DataView
            }
            else
            {
                dataGridView2.DataSource = dt;  //Gets or sets data that the DataGridView displays
            }

   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet

            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            dv.RowFilter = "Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'" + "AND Status = 'Absent'"; //Filters and displays all the data between the selected date on 'Date' column
            dataGridView2.DataSource = dt;  //Gets or sets data that the DataGridView displays
        }
    }
}
