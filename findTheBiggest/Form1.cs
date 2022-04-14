using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int findTheBiggest(int a, int b, int c)
        {
            int theBiggest = 0;
            if (a > b && a > c)
                theBiggest = a;
            if (b > a && b > c)
                theBiggest = b;
            if (c > a && c > b)
                theBiggest = c;

            return theBiggest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int z = int.Parse(textBox3.Text);

            int result = findTheBiggest(x, y, z);
            MessageBox.Show(result.ToString());
        }
    }
}
