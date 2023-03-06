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
    public partial class test : Form
    {
        //以下为随机数字
        //实际上不需要知道显示的数字到底是什么顺序
        //标签一样就是一样的
        //设计图里是默认的标签
        int[] number = new int[12];//显示数字的顺序
        int[] seq = new int[5];//闪烁顺序
        int[] res = new int[5];//选择顺序
        int time = 4;
        int flag = 0;

        private void end()
        {
            MessageBox.Show("测试结束。");
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                if (res[i] == seq[i])
                    score += 10;
            }
            datapass.stra = String.Format("第一道题：{0,-2}", number[res[4] - 1]) + String.Format("    正确答案：{0,-2}", number[seq[4] - 1].ToString());
            datapass.strb = String.Format("第二道题：{0,-2}", number[res[3] - 1]) + String.Format("    正确答案：{0,-2}", number[seq[3] - 1].ToString());
            datapass.strc = String.Format("第三道题：{0,-2}", number[res[2] - 1]) + String.Format("    正确答案：{0,-2}", number[seq[2] - 1].ToString());
            datapass.strd = String.Format("第四道题：{0,-2}", number[res[1] - 1]) + String.Format("    正确答案：{0,-2}", number[seq[1] - 1].ToString());
            datapass.stre = String.Format("第五道题：{0,-2}", number[res[0] - 1]) + String.Format("    正确答案：{0,-2}", number[seq[0] - 1].ToString());
            datapass.strf = "得分：" + score.ToString();
            result form2 = new result();
            form2.ShowDialog();
            Close();
        }

        public test()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            //生成不重复随机数
            int[] index = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Random r = new Random();
            int site = 12;
            int id;
            for (int j = 0; j < 12; j++)
            {
                id = r.Next(0, site);
                number[j] = index[id];
                index[id] = index[site - 1];
                site--;
            }
            //随机挑5个数
            int[] ind = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Random rt = new Random();
            int max = 12;
            int idx;
            for (int j = 0; j < 5; j++)
            {
                idx = rt.Next(0, max);
                seq[j] = ind[idx];
                ind[idx] = ind[max - 1];
                max--;
            }
            //开始计时，隔一秒亮一个
            timer1.Enabled = true;
            time = 4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (seq[time])
            {
                case 1:
                    button1.BackColor = Color.DeepSkyBlue;
                    break;
                case 2:
                    button2.BackColor = Color.DeepSkyBlue;
                    break;
                case 3:
                    button3.BackColor = Color.DeepSkyBlue;
                    break;
                case 4:
                    button4.BackColor = Color.DeepSkyBlue;
                    break;
                case 5:
                    button5.BackColor = Color.DeepSkyBlue;
                    break;
                case 6:
                    button6.BackColor = Color.DeepSkyBlue;
                    break;
                case 7:
                    button7.BackColor = Color.DeepSkyBlue;
                    break;
                case 8:
                    button8.BackColor = Color.DeepSkyBlue;
                    break;
                case 9:
                    button9.BackColor = Color.DeepSkyBlue;
                    break;
                case 10:
                    button10.BackColor = Color.DeepSkyBlue;
                    break;
                case 11:
                    button11.BackColor = Color.DeepSkyBlue;
                    break;
                case 12:
                    button12.BackColor = Color.DeepSkyBlue;
                    break;
            }
            //每个亮半秒，可以调
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (seq[time])
            {
                case 1:
                    button1.BackColor = Color.White;
                    break;
                case 2:
                    button2.BackColor = Color.White;
                    break;
                case 3:
                    button3.BackColor = Color.White;
                    break;
                case 4:
                    button4.BackColor = Color.White;
                    break;
                case 5:
                    button5.BackColor = Color.White;
                    break;
                case 6:
                    button6.BackColor = Color.White;
                    break;
                case 7:
                    button7.BackColor = Color.White;
                    break;
                case 8:
                    button8.BackColor = Color.White;
                    break;
                case 9:
                    button9.BackColor = Color.White;
                    break;
                case 10:
                    button10.BackColor = Color.White;
                    break;
                case 11:
                    button11.BackColor = Color.White;
                    break;
                case 12:
                    button12.BackColor = Color.White;
                    break;
            }
            //用完记得关
            timer2.Enabled = false;
            if (time > 0)
            {
                timer1.Enabled = true;
                time--;
            }
            else
            {
                //保险起见建议用完关表
                timer1.Enabled = false;
                //显示结束后开启按钮
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                //显示随机数字
                button1.Text = number[0].ToString();
                button2.Text = number[1].ToString();
                button3.Text = number[2].ToString();
                button4.Text = number[3].ToString();
                button5.Text = number[4].ToString();
                button6.Text = number[5].ToString();
                button7.Text = number[6].ToString();
                button8.Text = number[7].ToString();
                button9.Text = number[8].ToString();
                button10.Text = number[9].ToString();
                button11.Text = number[10].ToString();
                button12.Text = number[11].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //保存点击的按钮序号
            res[4 - flag] = 1;
            flag++;
            if (flag == 5)
                end();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 2;
            flag++;
            if (flag == 5)
                end();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 3;
            flag++;
            if (flag == 5)
                end();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 4;
            flag++;
            if (flag == 5)
                end();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 5;
            flag++;
            if (flag == 5)
                end();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 6;
            flag++;
            if (flag == 5)
                end();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 7;
            flag++;
            if (flag == 5)
                end();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 8;
            flag++;
            if (flag == 5)
                end();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 9;
            flag++;
            if (flag == 5)
                end();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 10;
            flag++;
            if (flag == 5)
                end();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 11;
            flag++;
            if (flag == 5)
                end();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            res[4 - flag] = 12;
            flag++;
            if (flag == 5)
                end();
        }

        private void test_Load(object sender, EventArgs e)
        {
            //按要求清空标签，详见论文
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";

            //最大化等比调整
            int a = Size.Width;
            int b = Size.Height;
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            //比例系数
            int k1 = Size.Width / a;
            int k2 = Size.Height / b;

            foreach (Control bs in this.Controls)
            {
                bs.Location = new Point(k1 * bs.Location.X, k2 * bs.Location.Y);
                bs.Size = new Size(k1 * bs.Size.Width, k2 * bs.Size.Height);
                
            }


        }
    }
}
