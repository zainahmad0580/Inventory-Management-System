using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            panel2.Show();
            Listitem lt = new Listitem();
            panel2.Controls.Add(lt);
            //flowLayoutPanel3.Scroll=HomePage.ScrollStateVScrollVisible
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Show();
            Listitem lt = new Listitem();
            panel2.Controls.Add(lt);
        }
        public void loaddata()
        {
            DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
            Homeitem ht = new Homeitem();
            List<Homeitem> st = (from s in dataClasses1DataContext.Homeitems select s).ToList();
            itemss[] its = new itemss[st.Count];
            int j = 0;
            int k = 0;
            //i=0,j=1,k=2,
            //i=3 j=4,k=5
            //i=6 j=7,k=8
            //i=9 j=10,k=11
            for (int i = 0; i < st.Count; i += 3)
            {
                ht = new Homeitem();
                ht = st[i];
                its[i] = new itemss();
                its[i].item(ht.itemid, ht.imagepath, ht.descriptions, ht.price.ToString());
                Homeitem ht2 = new Homeitem();
                if (j < st.Count)
                {
                    j = i + 1;
                    if (j < st.Count)
                    {
                        ht2 = st[j];
                        if (ht2 != null)
                            its[i].itr(ht2.itemid, ht2.imagepath, ht2.descriptions, ht2.price.ToString(), "Homeitem");
                    }


                }
                Homeitem ht3 = new Homeitem();
                if (k < st.Count)
                {
                    k = i + 2;
                    if (k < st.Count)
                    {

                        ht3 = st[k];
                        if (ht3 != null)
                            its[i].itr3(ht3.itemid, ht3.imagepath, ht3.descriptions, ht3.price.ToString());
                    }


                }

                flowLayoutPanel3.Controls.Add(its[i]);





            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (Login.logincheck)
            {
                checkout ch = new checkout();
                ch.Show();
            }
            else
            {
                Login l = new Login();
                l.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Beautyitems bi = new Beautyitems();
            bi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Sportsitem sp = new Sportsitem();
            sp.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Hide();
            }
        }
    }
}
