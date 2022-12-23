using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Mens : Form
    {
        public Mens()
        {
            InitializeComponent();
            loaddata();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loaddata()
        {
            DataClasses2DataContext dataClasses1DataContext = new DataClasses2DataContext();

            List<Homeitem> st = new List<Homeitem>();
            var sf = (from s in dataClasses1DataContext.Maleitems select s).ToList();
            Homeitem[] ht = new Homeitem[sf.Count];
            int k = 0;
            foreach (var item in sf)
            {
                ht[k] = new Homeitem();
                ht[k].itemid = item.itemid;
                ht[k].itemname = item.itemname;
                ht[k].imagepath = item.imagepath;
                ht[k].price = item.price;
                ht[k].descriptions = item.descriptions;
                k++;

            }
            itemss[] its = new itemss[sf.Count];
            int j = 0;
            int l = 0;

            //i=0,j=1,k=2,
            //i=3 j=4,k=5
            //i=6 j=7,k=8
            //i=9 j=10,k=11
            for (int i = 0; i < sf.Count; i += 3)
            {

                its[i] = new itemss();


                its[i].item(ht[i].itemid, ht[i].imagepath, ht[i].descriptions, ht[i].price.ToString());
                Homeitem ht2 = new Homeitem();
                if (j < sf.Count)
                {
                    j = i + 1;
                    if (j < sf.Count)
                    {

                        if (ht[j] != null)
                            its[i].itr(ht[j].itemid, ht[j].imagepath, ht[j].descriptions, ht[j].price.ToString(), "Maleitem");
                    }


                }
                Homeitem ht3 = new Homeitem();
                if (l < sf.Count)
                {
                    l = i + 2;
                    if (l < sf.Count)
                    {

                        //  ht3 = st[k];
                        //if (ht3 != null)
                        its[i].itr3(ht[l].itemid, ht[l].imagepath, ht[l].descriptions, ht[l].price.ToString());
                    }


                }

                flowLayoutPanel3.Controls.Add(its[i]);





            }

        }

        private void Mens_Load(object sender, EventArgs e)
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

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
