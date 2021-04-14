using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;

namespace week2
{
    public partial class print : Form
    {
        public print()
        {
            InitializeComponent();
        }
        STUDENT std = new STUDENT();
        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (allrb.Checked)
            {
                printView.DataSource = std.getListStd();
                DataGridViewImageColumn picInList = (DataGridViewImageColumn)printView.Columns["picture"];
                picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
                printView.AllowUserToAddRows = false;
            }
            else if (yesrb.Checked && fmalerb.Checked)
            {
                DateTime start = dateTimePicker1.Value;
                DateTime end = dateTimePicker2.Value;
                printView.DataSource = std.getListFemaleYes(start, end);
                DataGridViewImageColumn picInList = (DataGridViewImageColumn)printView.Columns["picture"];
                picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
                printView.AllowUserToAddRows = false;
            }
            else if (yesrb.Checked && malerb.Checked)
            {
                DateTime start = dateTimePicker1.Value;
                DateTime end = dateTimePicker2.Value;
                printView.DataSource = std.getListMaleYes(start, end);
                DataGridViewImageColumn picInList = (DataGridViewImageColumn)printView.Columns["picture"];
                picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
                printView.AllowUserToAddRows = false;
            }
            else if (malerb.Checked)
            {
                printView.DataSource = std.getListMale();
                DataGridViewImageColumn picInList = (DataGridViewImageColumn)printView.Columns["picture"];
                picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
                printView.AllowUserToAddRows = false;
            }
            else if (fmalerb.Checked)
            {
                printView.DataSource = std.getListFemale();
                DataGridViewImageColumn picInList = (DataGridViewImageColumn)printView.Columns["picture"];
                picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
                printView.AllowUserToAddRows = false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "StudentList.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(printView, sfd.FileName);
            }

        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];
                Object oMissing = System.Reflection.Missing.Value;
                Word.Document oDoc = new Word.Document();

                //add rows
                int count=1;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                  

                        for (int r = 0; r <= RowCount - 1; r++)
                    {
                        if (c == 0)
                        {
                            DataArray[r, c] = count.ToString();
                            count++;
                        }
                        else
                            DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                        
                    } //end row loop
                } //end column loop

                
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;
                
                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    if(c==0)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = "No.";

                    }
                    else
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Student List";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                for (int r = 0; r <= RowCount - 1; r++)
                {
                   
                    byte[] imgbyte = (byte[])DGV.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    //Image sparePicture = Image.FromStream(ms);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r+2,8).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r+2, 8).Range.InsertParagraphAfter();
                   
                }
                //save the file
                oDoc.SaveAs(filename);

            }
        }
    }
}
