using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev4_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = 0;
            do
            {
                richTextBox1.Text = richTextBox1.Text + say.ToString();
                say++;
            } while (say <= 30);
        }
    }
}
