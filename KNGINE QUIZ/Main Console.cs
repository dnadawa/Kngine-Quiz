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
using System.Threading;
namespace KNGINE_QUIZ
{
    public partial class TeamA : Form
    {
        String ip = IPform.ipadd;
        public TeamA()
        {
            InitializeComponent();
        }

        private void Main_Console_Activated(object sender, EventArgs e)
        {

            dothis();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dothis();

        }


        


        String qn;
        private void resetnum() {
            try
            {
                // String que = "datasource="+ip+";port=3306;username=dulaj;password=abc;database=ano;SslMode=none";
                String que = "datasource=localhost;port=3306;username=root;password=;database=ano;SslMode=none";
                MySqlConnection connection = new MySqlConnection(que);
                connection.Open();
                String up = "UPDATE no SET no=150  WHERE id=1";
                MySqlCommand cmd1 = new MySqlCommand(up, connection);   
                MySqlDataReader read = cmd1.ExecuteReader();
                //MessageBox.Show("Data updated!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }


        }


        String ques, a1, a2, a3, a4 ,Aanswered,Banswered;
        private void dothis()
        {

            try
            {
                // String que = "datasource="+ip+";port=3306;username=dulaj;password=abc;database=ano;SslMode=none";
                String que = "datasource=localhost;port=3306;username=root;password=;database=ano;SslMode=none";
                MySqlConnection connection = new MySqlConnection(que);
                connection.Open();
                String sel = "SELECT no FROM no WHERE id=1";
                MySqlCommand cmd3 = new MySqlCommand(sel, connection);
                var read = cmd3.ExecuteReader();

                read.Read();
                String num = read.GetString(0);
                connection.Close();
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////
                

                connection.Open();

                String sel2 = "SELECT * FROM questions WHERE qno=" + num;
                MySqlCommand cmd2 = new MySqlCommand(sel2, connection);
                // MysqlReader readques = cmd2.ExecuteReader();
                MySqlDataReader rs = cmd2.ExecuteReader();
                while (rs.Read()) {

                    ques = (String)rs["question"];
                    a1 = (String)rs["a1"];
                    a2 = (String)rs["a2"];
                    a3 = (String)rs["a3"];
                    a4 = (String)rs["a4"];
                }


                switch (num)
                {
                    case "1":getdata("1");break;
                    case "2": getdata("2"); break;
                    case "3": getdata("3"); break;
                    case "4": getdata("4"); break;
                    case "5": getdata("5"); break;
                    case "6": getdata("6"); break;
                    case "7": getdata("7"); break;
                    case "8": getdata("8"); break;
                    case "9": getdata("9"); break;
                    case "10": getdata("10"); break;
                    case "11": getdata("11"); break;
                    case "12": getdata("12"); break;
                    case "13": getdata("13"); break;
                    case "14": getdata("14"); break;
                    case "15": getdata("15"); break;
                    case "16": getdata("16"); break;
                    case "17": getdata("17"); break;
                    case "18": getdata("18"); break;
                    case "19": getdata("19"); break;
                    case "20": getdata("20"); break;
                    case "21": getdata("21"); break;
                    case "22": getdata("22"); break;
                    case "23": getdata("23"); break;
                    case "24": getdata("24"); break;
                    case "25": getdata("25"); break;
                    case "26": getdata("26"); break;
                    case "27": getdata("27"); break;
                    case "28": getdata("28"); break;
                    case "29": getdata("29"); break;
                    case "30": getdata("30"); break;






                }



               
                 if (num == "100")
                {
                    lbla1.Enabled = false;
                    lbla2.Enabled = false;
                    lbla3.Enabled = false;
                    lbla4.Enabled = false;
                    pica1.Enabled = false;
                    pica2.Enabled = false;
                    pica3.Enabled = false;
                    pica4.Enabled = false;
                    checkanswers();
                }

                //MessageBox.Show(num, "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();


            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err);
            }
        }








        private void butnclick(String answer, String x)
        {
            try
            {
                // String que = "datasource="+ip+";port=3306;username=dulaj;password=abc;database=ano;SslMode=none";
                String que = "datasource=localhost;port=3306;username=root;password=;database=ano;SslMode=none";
                MySqlConnection connection = new MySqlConnection(que);
                connection.Open();


                String sele = "SELECT Aanswered,Banswered FROM store WHERE qno="+x;
                MySqlCommand cmd4 = new MySqlCommand(sele, connection);
                var readd = cmd4.ExecuteReader();
                
                 
                while (readd.Read())
                {
                    Aanswered = (String)readd["Aanswered"];
                    Banswered = (String)readd["Banswered"];
                }connection.Close();  
                    
                    if(Banswered == "1")
                    {

                        try
                        {
                        
                        connection.Open();
                            String updatequery = "UPDATE store set firstAnswered= 'teamB' WHERE qno=" + x;
                            MySqlCommand command = new MySqlCommand(updatequery, connection);
                            command.ExecuteReader();
                            connection.Close();
                            
                       // MessageBox.Show(Banswered+"-- team b is answered!");
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show("Error" + e);
                        }
                    }
                    else
                    {
                        try
                        {
                            connection.Open();
                            String update2 = "UPDATE store set firstAnswered= 'teamA' , Aanswered=1 WHERE qno=" + x;
                            MySqlCommand cmmd = new MySqlCommand(update2, connection);
                            cmmd.ExecuteReader();
                            connection.Close();
                            
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Error" + e);
                        }
                    }
                //connection.Close();





                ///////////////////////////////////////////////////////////////////////////////////////////////////////////




                connection.Open();
                String sel = "UPDATE store set teama=" + answer + " WHERE qno=" + x;
                MySqlCommand cmd5 = new MySqlCommand(sel, connection);
                cmd5.ExecuteReader();
                connection.Close();
                lbla1.Enabled = false;
                lbla2.Enabled = false;
                lbla3.Enabled = false;
                lbla4.Enabled = false;
                pica1.Enabled = false;
                pica2.Enabled = false;
                pica3.Enabled = false;
                pica4.Enabled = false;
                resetnum();
                //Thread.Sleep(3000);

                //checkanswers();
                //timer1.Stop();
                //  Thread.Sleep(1000);
                //timer1.Start();


            }
            catch (Exception exx)
            {
                MessageBox.Show("Error" + exx);
            }
        }




        private void btna1_Click(object sender, EventArgs e)
        {
            //lblans1.BackColor = Color.Red;
            
        }

        private void btna2_Click(object sender, EventArgs e)
        {
            
        }

        private void btna3_Click(object sender, EventArgs e)
        {
           
        }

        private void lbla3_Click(object sender, EventArgs e)
        {
            lbla3.BackColor = Color.Red;
            butnclick("3", qn);
        }

        private void Main_Console_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void lbldisplay_Click(object sender, EventArgs e)
        {

        }

        private void pica1_Click(object sender, EventArgs e)
        {
            lbla1.BackColor = Color.Red;
            butnclick("1", qn);
        }

        private void lbla1_Click(object sender, EventArgs e)
        {
            lbla1.BackColor = Color.Red;
            butnclick("1", qn);
        }

        private void pica2_Click(object sender, EventArgs e)
        {
            lbla2.BackColor = Color.Red;
            butnclick("2", qn);
        }

        private void lbla2_Click(object sender, EventArgs e)
        {
            lbla2.BackColor = Color.Red;
            butnclick("2", qn);
        }

        private void pica3_Click(object sender, EventArgs e)
        {
            lbla3.BackColor = Color.Red;
            butnclick("3", qn);
        }

        private void lbla4_Click(object sender, EventArgs e)
        {
            lbla4.BackColor = Color.Red;
            butnclick("4", qn);
        }

        private void pica4_Click(object sender, EventArgs e)
        {
            lbla4.BackColor = Color.Red;
            butnclick("4", qn);
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            dothis();
        }

        private void btna4_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Console_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }


        private void checkanswers()
        {

            switch (qn)
            {
                //this is used to change the button color to green of the correct answer
                
                case "1": lbla2.BackColor = Color.Green; break;//if answer is 1 change the color of lbla1 to green
                case "2": lbla2.BackColor = Color.Green; break;
                case "3": lbla1.BackColor = Color.Green; break;
                case "4": lbla2.BackColor = Color.Green; break;
                case "5": lbla3.BackColor = Color.Green; break;
                case "6": lbla3.BackColor = Color.Green; break;
                case "7": lbla4.BackColor = Color.Green; break;
                case "8": lbla3.BackColor = Color.Green; break;
                case "9": lbla2.BackColor = Color.Green; break;
                case "10": lbla2.BackColor = Color.Green; break;
                case "11": lbla2.BackColor = Color.Green; break;
                case "12": lbla3.BackColor = Color.Green; break;
                case "13": lbla4.BackColor = Color.Green; break;
                case "14": lbla4.BackColor = Color.Green; break;
                case "15": lbla3.BackColor = Color.Green; break;


            }

        }


        private void getdata(String y)
        {

            lbldisplay.Text = ques;
            lbla1.Text = a1;
            lbla2.Text = a2;
            lbla3.Text = a3;
            lbla4.Text = a4;
            qn = y;
            lbla1.Enabled = true;
            lbla2.Enabled = true;
            lbla3.Enabled = true;
            lbla4.Enabled = true;
            pica1.Enabled = true;
            pica2.Enabled = true;
            pica3.Enabled = true;
            pica4.Enabled = true;
            lbla1.BackColor = Color.FromArgb(189,0,0);
            lbla2.BackColor = Color.FromArgb(189, 0, 0);
            lbla3.BackColor = Color.FromArgb(189, 0, 0);
            lbla4.BackColor = Color.FromArgb(189, 0, 0);
            lbla1.Visible = true;
            lbla2.Visible = true;
            lbla3.Visible = true;
            lbla4.Visible = true;



        }

    }

}
