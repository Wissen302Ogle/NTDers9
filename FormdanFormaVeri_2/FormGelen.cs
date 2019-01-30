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
    public partial class FormGelen : Form
    {
        public string LBL1
        {
            get
            { return label1.Text; }
            set
            {
                if (value != "Yusuf")
                {

                    MessageBox.Show(string.Format("Senin adın {0} değil,bu değeri göstermeyeceğim", value));
                }
                else
                    label1.Text = value;
            }
        }
        public string LBL2
        {
            get
            { return label2.Text; }
            set
            { label2.Text = value; }
        }
        public FormGelen()
        {
            InitializeComponent();
        }
        //public FormGelen(string txt,string txt2)
        //{
        //    InitializeComponent();
        //    label1.Text = txt;
        //    label2.Text = txt2;
        //}
    }
}
