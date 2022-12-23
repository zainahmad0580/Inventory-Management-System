using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class checkoutusercontrol : UserControl
    {
        public  int[] itemcount=new int[3];
        public  int item2count;
        public  int item3count;
        public static int conunter = 0;
        public checkoutusercontrol()
        {
            InitializeComponent();
            pictureBox1.Hide();
            label1.Hide();
            pictureBox2.Hide();
            label2.Hide();
            pictureBox3.Hide();
            label3.Hide();
            conunter++;
        }

        private void checkoutusercontrol_Load(object sender, EventArgs e)
        {

        }
        public void itr3(int id, string paths,  string price)
        {
            if (paths != "")
            {
                pictureBox1.Load(paths);
                label1.Text = price;
               
                pictureBox1.Show();
                label1.Show();
                label4.Show();
            }
            else
            {
                pictureBox1.Hide();
                label1.Hide();
               
            }
        }
        public void itr(int itemid ,string paths,  string price)
        {
            if (paths != "")
            {
                pictureBox2.Load(paths);
                label2.Text = price;

                pictureBox2.Show();
                label2.Show();
                button2.Show();
            }
            else
            {
                pictureBox2.Hide();
                label2.Hide();

            }
        }
        public void itr2( int itemid,string paths,  string price)
        {
            if (paths != "")
            {
                pictureBox3.Load(paths);
                label3.Text = price;

                pictureBox3.Show();
                label3.Show();
                label6.Show();
                button3.Show();
                

            }
            else
            {
                pictureBox1.Hide();
                label1.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(label4.Text);
             count+= 1;
            label4.Text=count.ToString();
            itemcount[0] = count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(label5.Text);
            count += 1;
            label5.Text = count.ToString();
            itemcount[1] = count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(label6.Text);
            count += 1;
            label6.Text = count.ToString();
            itemcount[2] = count;
        }
    }
}
