using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colors
{
    public partial class Colors : Form
    {
        int[] col = new int[30];

        public Colors()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label[] texts = new Label[30];
            for (int i = 0; i < 30; i++)
            {
                texts[i] = new Label();
                texts[i].Location = new Point(20+i*50,20+i*30);
                texts[i].ForeColor = Color.FromArgb(255,0,0);
            }
        }
    }
}
