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
    public partial class itemss : UserControl
    {
         int item1 = 0;
         int item2 = 0;
       int item3 = 0;
        string Formname = "";
        

        public itemss()
        {
            InitializeComponent();
            pictureBox1.Hide();
           textBox1.Hide();
            label2.Hide();
            pictureBox2.Hide();
            label3.Hide();
            textBox2.Hide();
            pictureBox3.Hide();
            label5.Hide();
            textBox3.Hide();
            Addtocart.Hide();
            button1.Hide();
            button2.Hide();


        }

        
        public void item(int id,string path, string des, string price)
        {
            if (path != null)
            {
                pictureBox1.Show();
                textBox1.Show();
                label2.Show();
                Addtocart.Show();
                pictureBox1.Load(path);
                textBox1.Text = des;
                item1 = id;
                label2.Text += price;
            }
            else
            {
                pictureBox1.Hide();
                textBox1.Hide();
                label2.Hide();
            }
        }
        public void itr(int id,string paths, string des, string price,string formname)
        {
            if (paths != "")
            {
                pictureBox2.Show();
                label3.Show();
                textBox2.Show();
                button1.Show();
                item2 = id;
                Formname= formname;
                pictureBox2.Load(paths);
                label3.Text += price;
                textBox2.Text = des;
               
            }
            else
            {
                pictureBox2.Hide();
                label3.Hide();
                textBox2.Hide();
            }
        }
        public void itr3(int id, string paths, string des, string price)
        {
            if (paths !="")
            {
                pictureBox3.Load(paths);
                label5.Text += price;
                textBox3.Text = des;
                item3 = id;
                pictureBox3.Show();
                label5.Show();
                textBox3.Show();
                button2.Show();
                
            }
            else
            {
                pictureBox3.Hide();
                label5.Hide();
                textBox3.Hide();
            }
        }

        private void Addtocart_Click(object sender, EventArgs e)
        {
            if (checkout.form == "")
            {
                checkout.form = Formname;
            }
            checkout.list.Add(item1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkout.form == "")
            {
                checkout.form = Formname;
            }
            
            checkout.list.Add(item2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkout.form == "")
            {
                checkout.form = Formname;
            }

            checkout.list.Add(item3);
           
        }
        public string tablename(string table)
        {
            return ""; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
