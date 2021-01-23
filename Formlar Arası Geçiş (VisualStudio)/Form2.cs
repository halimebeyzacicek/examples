using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form1 frm1;

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 frm1 = new Form1();
            //frm1.Show();
            //Hide();

            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Application.OpenForms["Form1"].Show();
            Hide();
        }
    }
}
