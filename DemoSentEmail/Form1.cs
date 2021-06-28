using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSentEmail
{
    public partial class Form1 : Form
    {
        private Email _email;
        public Form1()
        {
            InitializeComponent();
            _email = new Email();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        public void SentEmail()
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _email.Send(txtEmail.Text, txtCC.Text, txtBcc.Text, "Xin chào!", txtNoiDung.Text) ;
            MessageBox.Show("Ok");
        }
    }
}
