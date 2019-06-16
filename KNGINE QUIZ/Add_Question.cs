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
    public partial class Add_Question : Form
    {
        String ip = IPform.ipadd;
        public Add_Question()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txta1.Text = "";
            txta2.Text = "";
            txta3.Text = "";
            txta4.Text = "";
            txtq.Text = "";
            txtqno.Text = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String qno = txtqno.Text;
            String ques = txtq.Text;
            String a1 = txta1.Text;
            String a2 = txta2.Text;
            String a3 = txta3.Text;
            String a4 = txta4.Text;



            try
            {
                // String que = "datasource="+ip+";port=3306;username=dulaj;password=abc;database=ano;SslMode=none";
                String que = "datasource=localhost;port=3306;username=root;password=;database=ano;SslMode=none";
                MySqlConnection connection = new MySqlConnection(que);
                connection.Open();

                String updatequery = "UPDATE questions set question='"+ques+"',a1='"+a1+"',a2='"+a2+"',a3='"+a3+"',a4='"+a4+"' WHERE qno=" + qno;
                MySqlCommand command = new MySqlCommand(updatequery, connection);
                command.ExecuteReader();
                connection.Close();
                MessageBox.Show("Updated");
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
    }
}
