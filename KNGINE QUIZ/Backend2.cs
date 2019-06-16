using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;





namespace KNGINE_QUIZ
{
    public partial class Backend2 : Form
    {
        String ip = IPform.ipadd;
        public Backend2()
        {
            InitializeComponent();
        }

        private void Backend2_Load(object sender, EventArgs e)
        {
            

            /*dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;*/
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int tota, totb=0;
       



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //String que = "datasource="+ip+";port=3306;username=dulaj;password=abc;database=ano;SslMode=none";
                String que = "datasource=localhost;port=3306;username=root;password=;database=ano;SslMode=none";
                MySqlConnection connection = new MySqlConnection(que);
                connection.Open();
                String sel = "SELECT * FROM store";
                MySqlCommand cmd = new MySqlCommand(sel, connection);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                ada.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
            
                ada.Update(dt);











             /*   var read = cmd.ExecuteReader();

                read.Read();
                String num = read.GetString(0);
                connection.Close();*/




            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);



            }
        }
       
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           
          
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

      
        private void checkans(String team,String player,Boolean correct) {

            if (team == "A")
            {
                if(player == "P1")
                {
                    if(correct == true)
                    {
                        tota = tota + 10;
                    }
                }
                else if(player == "P2")
                {
                    if (correct == true)
                    {
                        tota = tota + 10;
                    }
                }
                else if (player == "P3")
                {
                    if (correct == true)
                    {
                        tota = tota + 10;
                    }
                }
                else if (player == "P4")
                {
                    if (correct == true)
                    {
                        tota = tota + 10;
                    }
                }
                else if (player == "P5")
                {
                    if (correct == true)
                    {
                        tota = tota + 10;
                    }
                }
            }



            else if (team == "B")
            {
                if (player == "P1")
                {
                    if (correct == true)
                    {
                        totb = totb + 10;
                    }
                }
                else if (player == "P2")
                {
                    if (correct == true)
                    {
                        totb = totb + 10;
                    }
                }
                else if (player == "P3")
                {
                    if (correct == true)
                    {
                        totb = totb + 10;
                    }
                }
                else if (player == "P4")
                {
                    if (correct == true)
                    {
                        totb = totb + 10;
                    }
                }
                else if (player == "P5")
                {
                    if (correct == true)
                    {
                        totb = totb + 10;
                    }
                }
            }

            lbltota.Text = tota.ToString();
            lbltotb.Text = totb.ToString();


            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("C:\\Users\\DULAJ\\Desktop\\Book1.xlsx");
                Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                x.Range["E2"].Value = tota.ToString();
                x.Range["F2"].Value = totb.ToString();
                //x.Range["C2"].Value = teamaans.ToString();
                //x.Range["D2"].Value = teambans.ToString();
                //x.Range["c2"].Value = "how are you";
                //x.Cells[7, 2] = "Hello";
                sheet.Close(true, Type.Missing, Type.Missing);
                excel.Quit();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }










        }


        






        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void taq1f_Click(object sender, EventArgs e)
        {
            checkans("A", "P1", false);
        }

        private void ta_Click(object sender, EventArgs e)
        {
            checkans("A", "P2", true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkans("A", "P2", false);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkans("A", "P3", true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkans("A", "P3", false);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            checkans("A", "P4", true);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            checkans("A", "P4", false);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkans("A", "P5", true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkans("A", "P5", false);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            checkans("A", "P1", true);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            checkans("A", "P1", false);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            checkans("A", "P2", true);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            checkans("A", "P2", false);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            checkans("A", "P3", true);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            checkans("A", "P3", false);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            checkans("A", "P4", true);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            checkans("A", "P4", false);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            checkans("A", "P5", true);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            checkans("A", "P5", false);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            tota = 0;
            totb = 0;
            lbltota.Text = "0";
            lbltotb.Text = "0";



            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("C:\\Users\\DULAJ\\Desktop\\Book1.xlsx");
                Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                x.Range["E2"].Value = "0";
                x.Range["F2"].Value = "0";
                //x.Range["C2"].Value = teamaans.ToString();
                //x.Range["D2"].Value = teambans.ToString();
                //x.Range["c2"].Value = "how are you";
                //x.Cells[7, 2] = "Hello";
                sheet.Close(true, Type.Missing, Type.Missing);
                excel.Quit();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            checkans("B", "P1", true);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            checkans("B", "P1", false);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            checkans("B", "P2", true);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            checkans("B", "P2", false);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            checkans("B", "P3", true);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            checkans("B", "P3", false);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            checkans("B", "P4", true);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            checkans("B", "P4", false);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            checkans("B", "P5", true);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            checkans("B", "P5", false);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            checkans("B", "P1", true);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            checkans("B", "P1", false);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            checkans("B", "P2", true);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            checkans("B", "P2", false);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            checkans("B", "P3", true);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            checkans("B", "P3", false);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            checkans("B", "P4", true);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            checkans("B", "P4", false);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            checkans("B", "P5", true);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            checkans("B", "P5", false);
        }

        private void p1q1_Click(object sender, EventArgs e)
        {
            checkans("A", "P1", true);
        }
    }


  
            



}
