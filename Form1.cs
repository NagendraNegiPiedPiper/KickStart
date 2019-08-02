using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using ClosedXML.Excel;
using System.IO;
using Spire.Xls;
using System.Configuration;
using OfficeOpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml.Style;
using OfficeOpenXml.Style.XmlAccess;
using System.Drawing.Imaging;

// Important: include the opencvsharp library in your code
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;
using signotec.STPadLibNet;

namespace FinalAttempt
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9DJNTJB\MSSQLSRV2017STD;Initial Catalog=TutorialDB;Persist Security Info=True;User ID=sa;Password=admin@123 ");
        SqlCommand cmd;
        SqlDataAdapter sda;
        //ID variable used in Updating and Deleting Record  
        int CustomerID = 0;


        public Form1()
        {
            InitializeComponent();          

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void refreshdata()
        {
            cmd = new SqlCommand("select * from Record", con);
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Loc.Text != "" && txt_Email.Text != "" && txt_Mob.Text != "")
            {
                cmd = new SqlCommand("insert into Record(Name,Location,Email,MobileNumber, ImageUrl, DateTime) values(@Name,@Location,@Email,@MobileNumber,@URL,@DateTime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@Location", txt_Loc.Text);
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@MobileNumber", txt_Mob.Text);
                cmd.Parameters.AddWithValue("@URL", txt_URL.Text);
                cmd.Parameters.AddWithValue("@DateTime", dateTimePicker1.Value);
              
                //Image insertion in the database

                /* Image img = pictureBox2.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                cmd.Parameters.AddWithValue("@Image",arr);*/
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                refreshdata();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        //Clear Data  
        private void ClearData()
        {
            txt_Name.Text = "";
            txt_Loc.Text = "";
            txt_Email.Text = "";
            txt_Mob.Text = "";
            CustomerID = 0;
            pictureBox2.Image = null;

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        

        //dataGridView1 RowHeaderMouseClick Event 
        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CustomerID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Loc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Mob.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_URL.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //dateTimePicker1.Value = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Loc.Text != "" && txt_Email.Text != "" && txt_Mob.Text != "" && dateTimePicker1.Value != null)
            {
                cmd = new SqlCommand("update Record set Name = @Name, Location = @Location, Email = @Email, MobileNumber = @MobileNumber, ImageUrl = @URL where CustomerID = @CustomerID , DateTime = @DateTime ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@Location", txt_Loc.Text);
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@MobileNumber", txt_Mob.Text);
                cmd.Parameters.AddWithValue("@DateTime", dateTimePicker1.Value);
                //System.Diagnostics.Process.Start(txt_URL.Text);
                cmd.Parameters.AddWithValue("@URL", txt_URL.Text);

                /*Image img = pictureBox2.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                cmd.Parameters.AddWithValue("@Image", arr);*/
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                refreshdata();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void Button_Del_Click(object sender, EventArgs e)
        {
            if (CustomerID != 0)
            {
                cmd = new SqlCommand("delete Record where CustomerID=@CustomerID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@CustomerID",CustomerID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                refreshdata();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void Button_Excel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    // Bind Grid Data to Datatable
                    DataTable dt = new DataTable();
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {


                        dt.Columns.Add(col.HeaderText, col.ValueType);



                    }
                    int count = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (count < dataGridView1.Rows.Count - 1)
                        {
                            dt.Rows.Add();
                            foreach (DataGridViewCell cell in row.Cells)
                            {                                
                                dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();                               
                            }
                        }
                        count++;
                    }

                    ExcelPackage ExcelPkg = new ExcelPackage();
                    ExcelWorksheet wsSheet1 = NewMethod(ExcelPkg);

                    using (ExcelRange Rng = wsSheet1.Cells[2, 2, 2, 2])
                    {
                        // Rng.Value = "Everyday Be Coding - Excel HYPERLINK using EPPlus .Net Library";
                        Rng.Style.Font.Size = 16;
                        Rng.Style.Font.Bold = true;
                        Rng.Style.Font.Italic = true;
                        Rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        Rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        Rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        Rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    }

                    //SET HYPERLINK STYLE-----------------------  
                    string StyleName = "HyperStyle";
                    ExcelNamedStyleXml HyperStyle = wsSheet1.Workbook.Styles.CreateNamedStyle(StyleName);
                    HyperStyle.Style.Font.UnderLine = true;
                    HyperStyle.Style.Font.Size = 12;
                    HyperStyle.Style.Font.Color.SetColor(System.Drawing.Color.Blue);

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        wsSheet1.Cells[1, i + 2].Value = dt.Columns[i].ToString();
                    }

                    for (int i = 0; i < (dt.Rows.Count); i++)
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if((j != (dt.Columns.Count - 2)))
                            wsSheet1.Cells[i+2, j+2].Value = dt.Rows[i][j].ToString();
                            else
                            {
                                // HYPERLINK with any local file.  

                                using (ExcelRange Rng = wsSheet1.Cells[i+2, j+2, i+2, j+2])
                                 {
                                    txt_URL.Text = dt.Rows[i][j].ToString();
                                     Rng.Formula = "=HYPERLINK(\"" + txt_URL.Text + "\", \"" + txt_URL.Text + "\")";
                                     Rng.StyleName = StyleName;

                                 }
                            }

                           /* if (j == (dt.Columns.Count - 2))
                            {

                                wsSheet1.Cells[i + 2, j + 2].Value = Convert.ToDateTime(dt.Rows[i][j].ToString());
                            }
                            */
                        }

                    // HYPERLINK with any local file.  

                   /* using (ExcelRange Rng = wsSheet1.Cells[22, 2, 22, 2])
                    {
                        Rng.Formula = "=HYPERLINK(\"" + txt_URL.Text + "\", \"" + txt_URL.Text + "\")";
                        Rng.StyleName = StyleName;

                    }*/


                    wsSheet1.Cells[wsSheet1.Dimension.Address].AutoFitColumns();
                    ExcelPkg.SaveAs(new FileInfo(@"E:\Hyperlink.xlsx"));

                    MessageBox.Show("Data Exported Successfully");



                    //   StreamWriter wr = new StreamWriter(@"E:\\DataWareHouse.xls");




                    /*  // Write Columns to excel file
                      for (int i = 0; i < dt.Columns.Count; i++)
                      {
                          wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");



                      }
                      wr.WriteLine();                




                      //write rows to excel file
                      for (int i = 0; i < (dt.Rows.Count); i++)
                      {
                          for (int j = 0; j < dt.Columns.Count; j++)
                          {

                              if (dt.Rows[i][j] != null)
                              {
                               // if (j != (dt.Columns.Count - 1))
                                    wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
                                else
                                {

                                    //HYPERLINK with any local file.  
                                    using (ExcelRange Rng = wsSheet1.Cells[i+1, j+1, i+1, j+1])
                                    {
                                        Rng.Formula = "=HYPERLINK(\"" + txt_URL.Text + "\", \"" + txt_URL.Text + "\")";
                                        Rng.StyleName = StyleName;

                                        wr.Write(wsSheet1.Cells[i + 1, j + 1, i + 1, j + 1] + "\t");

                                    }

                                }

                              }
                              else
                              {
                                  wr.Write("\t");

                              }
                          }
                          wr.WriteLine();
                      }
                      wr.Close();
                      MessageBox.Show("Data Exported Successfully");*/

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

           
        }

        private static ExcelWorksheet NewMethod(ExcelPackage ExcelPkg)
        {
            return ExcelPkg.Workbook.Worksheets.Add("Sheet1");
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_URL.Text = openFileDialog1.FileName; 


            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {       

           
 

        }

        private void polo(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Left Button Clicked!");
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right Button Clicked!");
            }
            
        }

        private void Txt_URL_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

      

        // Create class-level accesible variables
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;

        // Declare required methods
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {

            frame = new Mat();
            capture = new VideoCapture(0);
            // Camera Selection entry point
            // according to which object camera will start recording of that paritcular camera via rtsp url link

            if (comboBox1.Text == "Samsung")
                capture.Open(@"rtsp://admin:elkosta123@192.168.1.235:554/profile1/media.smp");
            else if (comboBox1.Text == "HikVision")
                capture.Open(@"rtsp://admin:hik@12345@192.168.1.70:554/ch1/main/av_stream");
            else if (comboBox1.Text == "Axis")
                capture.Open(@"rtsp://root:essi@192.168.1.205/axis-media/media.amp");
            else
                capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {

                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    pictureBox1.Image = image;
                }
            }
        }

       

        

       

        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text.Equals("Start"))
            {
                CaptureCamera();
                button_Start.Text = "Stop";
                isCameraRunning = true;
            }
            else
            {
                capture.Release();
                camera.Abort();
                button_Start.Text = "Start";
                isCameraRunning = false;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                // Take snapshot of the current image generate by OpenCV in the Picture Box
                Bitmap snapshot = new Bitmap(pictureBox1.Image);

                // Save in some directory
                // in this example, we'll generate a random filename e.g 47059681-95ed-4e95-9b50-320092a3d652.png
                // snapshot.Save(@"C:\Users\sdkca\Desktop\mysnapshot.png", ImageFormat.Png);
                snapshot.Save(string.Format(@"C:\Users\essi.\Desktop\{0}.png", Guid.NewGuid()), ImageFormat.Png);
                MessageBox.Show("Congo!!! Image Saved");
            }
            else
            {
                Console.WriteLine("Cannot take picture if the camera isn't capturing image!");
            }
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private STPadLib stPad = new STPadLib();

        private void Sign_Pad_Click(object sender, EventArgs e)
        {

            DeviceOpen();
            //DeviceStartService();
            // DisplaySetBacklight(BacklightMode.On);
            SignatureStart();
        }

        private void SignStop_Button_Click(object sender, EventArgs e)
        {
            SignatureStop();
            // You should replace the bold image   
            // in the sample below with an icon of your own choosing.  
            // Note the escape character used (@) when specifying the path.  
        }

        private void SignSave_Button_Click(object sender, EventArgs e)
        {
            SignatureSaveAsFileEx();
            // stPadLibControl1.ControlMirrorDisplay = (MirrorMode)ComboBoxMirror.SelectedIndex;
        }

        void DeviceOpen()//int index, bool eraseDisplay)
        {
            try
            {
                stPad.DeviceOpen(0);
            }
            catch (STPadException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void SignatureStart()
        {
            try
            {
                stPad.SignatureStart();

            }
            catch (STPadException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void SignatureSaveAsFileEx()/*string path, int resolution, int width, int height,
System.Drawing.Imaging.ImageFormat fileType, int penWidth, System.Drawing.Color
penColor, signotec.STPadLibNet.SignatureImageFlag options)*/
        {
            try
            {
                stPad.SignatureSaveAsFileEx(@"E:\Signature.tif", 300, 0, 0,
               ImageFormat.Tiff, 0, System.Drawing.Color.FromArgb(0, 0, 255),
               SignatureImageFlag.None);
                MessageBox.Show("Signature Captured!!! Hurrahhhh....");
            }
            catch (STPadException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void SignatureStop()
        {
            try
            {
                int nResult = stPad.SignatureStop();
                MessageBox.Show(String.Format("{0} points captured.", nResult));
            }
            catch (STPadException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private Thread thread1 = null;
        private Thread thread2 = null;

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Thread_Label_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(setText));
            thread2 = new Thread(new ThreadStart(setText));
            thread1.Start();
          
        }

        private void setText()
        {
            for (int i = 0; i < 100; i++)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;               

            }
            thread1.Abort();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(txt_URL.Text);
            pictureBox2.Image = image;
        }
    }
}
