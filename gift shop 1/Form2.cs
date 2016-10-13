using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gift_shop_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form3 f3=new Form3();
            Form4 f4=new Form4();
            Form5 f5=new Form5();
            Form6 f6=new Form6();
            if (radioButton1.Checked)
                f3.Show();
            else if (radioButton2.Checked)
                f4.Show();
            else if (radioButton3.Checked)
                f5.Show();
            else if (radioButton4.Checked)
                f6.Show();

            

        }

     
       
    }
}
