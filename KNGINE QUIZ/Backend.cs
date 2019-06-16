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
    public partial class Backend : Form
    {
        String ip = IPform.ipadd;
        public Backend()
        {
            InitializeComponent();
        }

        private void Backend_Load(object sender, EventArgs e)
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
            dataGridView1.ForeColor=Color.Black;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


       



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
                dataGridView1.DataSource = bsource;
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
        private String qno, teamaans, teambans, firstanswer;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selrow = dataGridView1.Rows[index];

             qno = selrow.Cells[0].Value.ToString();
             teamaans = selrow.Cells[1].Value.ToString();
             teambans = selrow.Cells[2].Value.ToString();
            firstanswer = selrow.Cells[5].Value.ToString();

            lblqno2.Text = qno;
            lblaans2.Text = teamaans;
            lblbans2.Text = teambans;
            String a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12,a13,a14,a15;
            a1 = "2";
            a2 = "2";
            a3 = "1";
            a4 = "2";
            a5 = "3";
            a6 = "3";
            a7 = "4";
            a8 = "3";
            a9 = "2";
            a10 = "2";
            a11 = "2";
            a12 = "3";
            a13 = "4";
            a14 = "4";
            a15 = "3";
            cal("1",a1);
            cal("2", a2);
            cal("3", a3);
            cal("4", a4);
            cal("5", a5);
            cal("6", a6);
            cal("7", a7);
            cal("8", a8);
            cal("9", a9);
            cal("10", a10);
            cal("11", a11);
            cal("12", a12);
            cal("13", a13);
            cal("14", a14);
            cal("15", a15);
            lbltota2.Text = tota.ToString();
            lbltotb2.Text = totb.ToString();
            

        }
        double tota, totb = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            qno = "0";
            teamaans = "0";
            teambans = "0";
            firstanswer = "";
            lblqno2.Text = "0";
            lblaans2.Text = "answer";
            lblbans2.Text = "answer";
            lbltota2.Text = "0";
            lbltotb2.Text = "0";


            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("C:\\Users\\DULAJ\\Desktop\\Book1.xlsx");
                Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                x.Range["A2"].Value = "0";
                x.Range["B2"].Value = "0";
                x.Range["C2"].Value = "N/A";
                x.Range["D2"].Value = "N/A";
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

        private void timer1_Tick(object sender, EventArgs e)
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
                dataGridView1.DataSource = bsource;
                ada.Update(dt);











                /*   var read = cmd.ExecuteReader();

                   read.Read();
                   String num = read.GetString(0);
                   connection.Close();*/




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("C:\\Users\\DULAJ\\Desktop\\Book1.xlsx");
                Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                x.Range["A2"].Value = tota.ToString();
                x.Range["B2"].Value = totb.ToString();
                x.Range["C2"].Value = teamaans.ToString();
                x.Range["D2"].Value = teambans.ToString();
                //x.Range["c2"].Value = "how are you";
                //x.Cells[7, 2] = "Hello";
                sheet.Close(true, Type.Missing, Type.Missing);
                excel.Quit();
                MessageBox.Show("Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }












        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void cal(String q,String a)
        {
            

           
            if(qno == q && firstanswer == "teamA")
            {
                if(qno == q && teamaans == a)
                {
                    tota = tota + 10;
                }
                else
                {
                    tota = tota - 5;
                    if(qno == q && teambans == a)
                    {
                        totb = totb + 5;
                    }
                    
                }
            }

            else if(qno == q && firstanswer == "teamB")
            {
                if(qno ==q && teambans == a)
                {
                    totb = totb + 10;
                }
                else
                {
                    totb = totb - 5;
                    if (qno == q && teamaans == a)
                    {
                        tota = tota + 5;
                    }

                }
            }





        }



        






        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


  
            



}
