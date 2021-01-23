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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int kontrol=0;

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm2 = new Form2();
            //frm2.Show();
            //Hide();

            //HATA
            //Form2 frm2 = (Form2)Application.OpenForms["Form2"];
            //Application.OpenForms["Form2"].Show();
            //Hide();

            if (kontrol == 0)
            {
                kontrol = 1;
                Form2 frm2 = new Form2();
                frm2.Show();
                Hide();
            }
            else
            {
                Form2 frm2 = (Form2)Application.OpenForms["Form2"];
                Application.OpenForms["Form2"].Show();
                Hide();
            }
        }
    }
}
