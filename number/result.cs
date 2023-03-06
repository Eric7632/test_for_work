using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number
{
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test form1 = new test();
            form1.ShowDialog();
            Close();
        }

        private void result_Load(object sender, EventArgs e)
        {
            label2.Text = datapass.stra;
            label3.Text = datapass.strb;
            label4.Text = datapass.strc;
            label5.Text = datapass.strd;
            label6.Text = datapass.stre;
            label7.Text = datapass.strf;
        }
    }
}
