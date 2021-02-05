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
        public Form1(int size)
        {
            InitializeComponent();

            Size = new Size(size, size);
            Text = size.ToString();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1((int)(Width * 0.8f));
            form.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Width > 200 && !Program.AllowToClose)
            {
                MessageBox.Show("qwerty");
                e.Cancel = true;
            }

            else if (Width != 500)
            {
                Program.AllowToClose = true;
                Program.FORM.Close();
            }
        }
    }
}
