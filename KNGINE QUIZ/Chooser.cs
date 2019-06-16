using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNGINE_QUIZ
{
    public partial class Chooser : Form
    {
        public Chooser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeamA g = new TeamA();
            g.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backend x = new Backend();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Question y = new Add_Question();
            y.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                try
                {
                    // String que = "datasource="+ip+";port=3306;username=dulaj;password=abc;database=ano;SslMode=none";
                    String que = "datasource=localhost;port=3306;username=root;password=;database=ano;SslMode=none";
                    MySqlConnection connection = new MySqlConnection(que);
                    connection.Open();
                    String up = "UPDATE store SET teama='' , teamb='' , Aanswered='',Banswered='',firstAnswered='' WHERE qno="+i;
                    MySqlCommand cmd1 = new MySqlCommand(up, connection);
                    MySqlDataReader read = cmd1.ExecuteReader();
                    //MessageBox.Show("Data updated!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();


                    MessageBox.Show("Question No." + i + " Deleted!");

               


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }






            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Backend2 z = new Backend2();
            z.Show();
        }
    }
}
