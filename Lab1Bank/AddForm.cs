using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Bank
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.fopList.Add(new FOP(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text), textBox6.Text));
            }

            catch
            {
                MessageBox.Show("Incorrect input");
            }
        }
    }
}
