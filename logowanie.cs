using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerD
{
    public partial class logowanie : Form
    {
        public logowanie()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                nazwaUz.Enabled = true;
                haslo.Enabled = true;
            }
            else
            {
                nazwaUz.Enabled = false;
                haslo.Enabled = false;
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Cdb baza;
            if(radioButton1.Checked)
            {
                baza = new Cdb(nazwaUz.Text, haslo.Text, nazwaSerwera.Text, nazwaBazy.Text);
            }
            else
            {
                baza = new Cdb(nazwaSerwera.Text, nazwaBazy.Text);
            }

            Form1 form1 = new Form1();
            form1.baza = baza;
            this.Hide();
            form1.Show();
        }
    }
}
