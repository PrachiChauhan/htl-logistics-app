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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace LogisticsApp
{
    public partial class formMain : Form
    {
        Logistics_db db;
        private String env_curr_dir;
        double cal, hand, carm, store, carn, disp,hand1,percent;
        

        public formMain()
        {
            env_curr_dir = Environment.CurrentDirectory;
            InitializeComponent();
            db = new Logistics_db();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            initializeForm();
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCustomer cstForm = new FormAddCustomer(db);
            cstForm.ShowDialog();
        }

        private void initializeForm()
        {
            /*
             * Initialize customer list drop down menu with customer 
             * names.
             */
            DataTable cNames = db.getCustomerNames();
            custList.DisplayMember = "c_name";
            custList.ValueMember = "c_id";
            custList.DataSource = cNames;
            vatRegNoText.Text = "712 1644 70";
            /*
             * 
             */
        }
        private double dataPercent()
        {
            DataTable cPerc = db.getCustomerPerc(custList.SelectedValue.ToString());
            foreach (DataRow dataRow in cPerc.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    percent = Convert.ToDouble(item);
                    Console.WriteLine("pc-" + percent);
                }
            }
            return percent;
        }
        /*
         * This function Prints the Address of the selected customer Name
         */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable cAddress = db.getCustAddress(custList.SelectedValue.ToString());
            foreach (DataRow dataRow in cAddress.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    address.Text = item.ToString();
                }
            }
            lblpercent.Text = dataPercent().ToString();

        }
        private void btnpdf_Click(object sender, EventArgs e)
        {
            //String path = "C:\\Users\\PrachiRuchir\\My_Home\\visual_studio-workspace\\files\\pdffiles\\text.pdf";
            //String image = "C:\\Users\\PrachiRuchir\\My_Home\\visual_studio-workspace\\files\\images\\logo.jpg";
            String path = env_curr_dir+@"\htlSheet.pdf";
            String image = env_curr_dir+@"\logo.jpg";

            //Creates the pdf file in A4 format
            Document doc = new Document(iTextSharp.text.PageSize.A4, 20f, 20f, 20f, 0f);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            //Image display in pdf file
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(image);
            img.ScalePercent(65f);
            doc.Add(img);

            //LineSeparator
            Chunk lb = new Chunk(new LineSeparator(10f, 100f, BaseColor.GRAY, Element.ALIGN_CENTER, 1));
            doc.Add(lb);

            //Font and Display of INVOICE
            BaseFont bfont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bfont, 18, 2, BaseColor.BLACK);
            Paragraph inv = new Paragraph("INVOICE", font);
            inv.Alignment = Element.ALIGN_CENTER;
            doc.Add(inv);
            doc.Add(lb);

            //Display customer name and Address
            Paragraph para = new Paragraph(custList.Text);
            Paragraph para1 = new Paragraph(address.Text);
            doc.Add(para);
            doc.Add(para1);
            doc.Add(lb);

            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 10;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            //pdfTable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE;
            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                        pdfTable.AddCell(cell.Value.ToString());
                }
            }
            doc.Add(pdfTable);

            //display Subtotal,vat,Total
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("Subtotal  :"), 420, 250, 0);
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_RIGHT, new Phrase(txtsubtotal.Text), 550, 250, 0);

            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("VAT 20%   :"), 420, 225, 0);
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_RIGHT, new Phrase(txtvat.Text), 550, 225, 0);

            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("Total     :"), 420, 200, 0);
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_RIGHT, new Phrase(txttotal.Text), 550, 200, 0);


            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_CENTER, new Phrase(lb), 20, 180, 0);

            //Footer Details

            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("Bank Details:"), 20, 160, 0);
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("Address:"), 400, 160, 0);

            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("HDFC Bank Limited"), 20, 145, 0);
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("Soft Freight Logic Private Limited"), 400, 145, 0);

            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("Vasant Kunj Site- 2 OCF Pocket Sector C "), 20, 130, 0);
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("Sector 11"), 400, 130, 0);

            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("New Delhi"), 20, 115, 0);
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("Dwarka"), 400, 115, 0);
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("Delhi 11007"), 20, 100, 0);
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("New Delhi DL 110070"), 400, 100, 0);
            ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, new Phrase("India"), 400, 85, 0);

            doc.Close();
            System.Diagnostics.Process.Start(path);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                dataGridView1.BeginEdit(true);
                ComboBox com = (ComboBox)dataGridView1.EditingControl;
                com.DroppedDown = true;
            }

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        /*
         * Formats the cells in separated commas(like 1,2000) and calculates Total for each row.Total= Qty * Price
         */

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double qty = (Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value));
            double price = (Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[4].Value));
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "qty")
            {
                if (qty != 0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = String.Format("{0:0.0000}",
                        (Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value)));
                    if (price != 0)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[5].Value = String.Format("{0:n}",
                            qty * price);
                        totalCal();
                    }
                }
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "price")
            {
                if (price != 0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = String.Format("{0:0.0000}",
                        Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[4].Value));
                    if (qty != 0)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[5].Value = String.Format("{0:n}",
                            qty * price);
                        totalCal();

                    }
                }
            }
        }

        /*
         * totalCal() calculates subtotal,Vat and Total of all the rows of DataGridView.  
         */

        void totalCal()
            {
                double sum = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                        sum += Convert.ToDouble(row.Cells[5].Value.ToString());
                }
                txtsubtotal.Text = String.Format("{0:n}", sum);
                txtvat.Text = String.Format("{0:n}", (sum * 0.20));
                txttotal.Text = String.Format("{0:n}", (Convert.ToDouble(txtvat.Text) + Convert.ToDouble(txtsubtotal.Text)));
            }


        private void btncsv_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;
            object misvalue = System.Reflection.Missing.Value;
            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.DisplayAlerts = false;
                oXL.Visible = false;

                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "JOBINFO";
                oSheet.Cells[1, 2] = "NIL";

                oSheet.Cells[2, 1] = "INVHEAD";
                oSheet.Cells[2, 2] = "AR";

                oSheet.Cells[2,3] = custList.SelectedValue.ToString();

                oSheet.Cells[2, 5] = "INV";
                oSheet.Cells[2, 10] = "INR";

                oRng = oSheet.get_Range("A3", "A6");
                oRng.Value = "INVLINE";

                oSheet.Cells[2, 8] = DateTime.Now.ToString("yyyyMMdd");

                oSheet.Cells[2, 16] = DateTime.Now.ToString("yyyyMMdd");


                string[,] saValues = new string[4, 3];

                oRng = oSheet.get_Range("I3", "I6");
                oRng.Value = "FREEGST";


                oRng = oSheet.get_Range("K3", "k6");
                oRng.Value = "Y";

                //Display Values from Database(allocation).
                /*string[,] aValues = new string[4,3];
                *aValues = dispAllocation();
                oSheet.get_Range("B3", "B6").Value2 = aValues;
                */
                oSheet.Cells[3 , 2] = "HAND";
                oSheet.Cells[4 , 2] = "STORE";
                oSheet.Cells[5 , 2] = "CARM";
                oSheet.Cells[6 , 2] = "CARN";

                oSheet.Cells[3, 4] = "HANDLING";
                oSheet.Cells[4, 4] = "STORAGE";
                oSheet.Cells[5, 4] = "CARRIAGE M&S";
                oSheet.Cells[6, 4] = "CARRIAGE N/A";


                //Calculation 
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value.ToString() == "DISPATCH W/E")
                        {
                            disp = Convert.ToDouble(row.Cells[5].Value);
                            cal = disp * percent / 100;
                        }
                        else if (row.Cells[0].Value.ToString() == "HANDLING W/E")
                        {
                            hand = Convert.ToDouble(row.Cells[5].Value);
                        }
                        else if (row.Cells[0].Value.ToString() == "STORAGE W/E")
                        {
                            store = Convert.ToDouble(row.Cells[5].Value);
                        }
                        else if (row.Cells[0].Value.ToString() == "CARRIAGE ERROR")
                        {
                            carn = Convert.ToDouble(row.Cells[5].Value);
                        }

                    }
                }
                hand1 = hand + cal;
                carm = disp - cal;
                oSheet.Cells[3, 7] = hand1;
                oSheet.Cells[4, 7] = store;
                oSheet.Cells[5, 7] = carm;
                oSheet.Cells[6, 7] = carn;


                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "C1").Font.Bold = true;
                oSheet.get_Range("A1", "C1").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                //String path = "C:\\Users\\PrachiRuchir\\My_Home\\visual_studio-workspace\\files\\excelsheets\\lsheet.csv";
                String path = env_curr_dir + @"\htlSheet.csv";
                //Console.WriteLine("RC-1: "+ );
                oXL.UserControl = false;
                oWB.SaveAs(path,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlCSVWindows,
                    //Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault,
                    Type.Missing,
                    Type.Missing,
                    true,
                    false,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing);

                oWB.Close();
                System.Diagnostics.Process.Start(path);


            }
            catch (Exception exp1)
            {
                Console.WriteLine(exp1.ToString());
            }
        }
        /*String[,] dispAllocation()
        {
            string[,] aValues = new string[4,3];
            DataTable aCode = db.getAllocationCode();
            int i = 0;
            foreach (DataRow dataRow in aCode.Rows)
            {
                int j = 0;
                foreach (var item in dataRow.ItemArray)
                {
                    aValues[i,j] = item.ToString().Trim('\n');
                    j++;
                }
                i++;
            }

            return aValues;
        }
        */
        
    }
    
}
