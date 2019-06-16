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

namespace KNGINE_QUIZ
{
   
    public partial class Form1 : Form
    {
        public static String ip;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // IPform ipform = new IPform();
             ip = IPform.ipadd;
            //MessageBox.Show("Your Ip is" + ip);
            //button1.Text = ip;
        }

        private void send(String x)
        {

            try
            {
               // String que = "datasource="+ip+";port=3306;username=dulaj;password=abc;database=ano;SslMode=none";
                String que = "datasource=localhost;port=3306;username=root;password=;database=ano;SslMode=none";
                MySqlConnection connection = new MySqlConnection(que);
                connection.Open();
                String up = "UPDATE no SET no=" + x + " WHERE id=1";
                MySqlCommand cmd = new MySqlCommand(up, connection);
                MySqlDataReader read = cmd.ExecuteReader();
                MessageBox.Show("Data updated!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update!! " + ex);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            send("1");
            button1.Enabled = false;
            
            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            send("2");
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            send("3");
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            send("4");
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            send("5");
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            send("100");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            buttonsix.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
        }

        private void buttonsix_Click(object sender, EventArgs e)
        {
            send("6");
            buttonsix.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            send("7");
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            send("8");
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            send("9");
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            send("10");
            button10.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            send("11");
            button20.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            send("12");
            button19.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            send("13");
            button18.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            send("14");
            button17.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            send("15");
            button16.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            send("16");
            button15.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            send("17");
            button14.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            send("18");
            button13.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            send("19");
            button12.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            send("20");
            button11.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            send("21");
            button30.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            send("22");
            button29.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            send("23");
            button28.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            send("24");
            button27.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            send("25");
            button26.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            send("26");
            button25.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            send("27");
            button24.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            send("28");
            button23.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            send("29");
            button22.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            send("30");
            button21.Enabled = false;
        }
    }
}
