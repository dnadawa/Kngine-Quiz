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
    public partial class IPform : Form
    {

        public static string ipadd;

        public IPform()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncon_Click(object sender, EventArgs e)
        {
                ipadd = txtip.Text;
            Form1 x = new Form1();
            //MessageBox.Show("Your ip is" + ip);
            x.Show();
            this.Visible = false;
        }
    }
}
