using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormdanFormaVeri_2
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            //FormGelen frm = new FormGelen(textBox1.Text,textBox2.Text);

            
            FormGelen frm = new FormGelen();
            frm.LBL1 = textBox1.Text;
            frm.LBL2 = textBox2.Text;
            frm.Show();
            this.Hide();
        }
    }
}
