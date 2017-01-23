using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro_SoftwareArch_GUI
{
    public partial class Form1 : Form
    {
        int M,N,P;
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            M= Int32.Parse(textBox1.Text) ;
            Random r = new Random();
            int min = 0;
            int max = 10 - M;
            N = r.Next(min, max + 1);
            outLabel.Text = "I guess int, N, in range 0..10-M: N ="+N+ "\r\n"; 
        }

        private void button2_Click(object sender,EventArgs e)
        {
            P = Int32.Parse(textBox2.Text);

            if (M+N+P==10)
             outlabel2.Text = "You Win!";
            else
             outlabel2.Text = "You Lose!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}
