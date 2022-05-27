using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samostatnapracemetodystach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Ondra = new Form2();
            Ondra.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Kubi = new Form3();
            Kubi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Daviid = new Form4();
            Daviid.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
