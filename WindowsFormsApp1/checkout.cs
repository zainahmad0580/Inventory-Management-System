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
    public partial class checkout : Form
    {
        public static List<int> list = new List<int>();
        public List<int> idlist=new List<int>();

        public static string form = "";
        string formname;
        int? totalBill = 0;
        checkoutusercontrol[] its = new checkoutusercontrol[list.Count];
        public checkout()
        {
            InitializeComponent();
            loaddata();
            idlist=list;
            formname=form;
            loaddata();
        }

        private void checkout_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loaddata()
        {
            
            if (formname == "Maleitem")
            {
                DataClasses2DataContext dataClasses1DataContext = new DataClasses2DataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int items = 0; items < list.Count; items++)
                {
                    int itemids = list.ElementAt(items);
                    var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.itemid == itemids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.itemid;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].descriptions = item.descriptions;
                        k++;
                        totalBill += item.price;
                    }
                }
                //checkoutusercontrol[] its = new checkoutusercontrol[list.Count];
                int j = 0;
                int l = 0;

                //i=0,j=1,k=2,
                //i=3 j=4,k=5
                //i=6 j=7,k=8
                //i=9 j=10,k=11
                int objectcounter = 0;
                for (int i = 0; i < list.Count; i += 3)
                {

                    its[objectcounter] = new checkoutusercontrol();

                    its[objectcounter].itr3(ht[i].itemid, ht[i].imagepath, ht[i].price.ToString());
                    Homeitem ht2 = new Homeitem();
                    if (j < list.Count)
                    {
                        j = i + 1;
                        if (j < list.Count)
                        {

                            if (ht[j] != null)
                                its[objectcounter].itr(ht[j].itemid, ht[j].imagepath, ht[j].price.ToString());
                        }


                    }
                    Homeitem ht3 = new Homeitem();
                    if (l < list.Count)
                    {
                        l = i + 2;
                        if (l < list.Count)
                        {

                            //  ht3 = st[k];
                            //if (ht3 != null)
                            its[objectcounter].itr2(ht[l].itemid, ht[l].imagepath, ht[l].price.ToString());
                        }


                    }

                    flowLayoutPanel2.Controls.Add(its[objectcounter]);




                    objectcounter++;
                }
                objectcounter = 0;

            }



            if (formname == "Femaleitem")
            {
                DataClasses3DataContext dataClasses1DataContext = new DataClasses3DataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int z = 0; z < list.Count; z++)
                {
                    int ids = list.ElementAt(z);
                    var sf = (dataClasses1DataContext.Femaleitems.Where(itemid => itemid.itemid == ids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.itemid;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].descriptions = item.descriptions;
                        k++;
                        totalBill += item.price;
                    }
                }
                //checkoutusercontrol[] its = new checkoutusercontrol[list.Count];
                int j = 0;
                int l = 0;

                //i=0,j=1,k=2,
                //i=3 j=4,k=5
                //i=6 j=7,k=8
                //i=9 j=10,k=11
                int objectcounter = 0;
                for (int i = 0; i < list.Count; i += 3)
                {

                    its[objectcounter] = new checkoutusercontrol();

                    its[objectcounter].itr3(ht[i].itemid, ht[i].imagepath, ht[i].price.ToString());
                    Homeitem ht2 = new Homeitem();
                    if (j < list.Count)
                    {
                        j = i + 1;
                        if (j < list.Count)
                        {

                            if (ht[j] != null)
                                its[objectcounter].itr(ht[j].itemid, ht[j].imagepath, ht[j].price.ToString());
                        }


                    }
                    Homeitem ht3 = new Homeitem();
                    if (l < list.Count)
                    {
                        l = i + 2;
                        if (l < list.Count)
                        {

                            //  ht3 = st[k];
                            //if (ht3 != null)
                            its[objectcounter].itr2(ht[l].itemid, ht[l].imagepath, ht[l].price.ToString());
                        }


                    }

                    flowLayoutPanel2.Controls.Add(its[objectcounter]);

                    objectcounter++;



                }
                objectcounter = 0;

            }
            if (formname == "Homeitem")
            {
                DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int items = 0; items < list.Count; items++)
                {
                    int itemids = list.ElementAt(items);
                    var sf = (dataClasses1DataContext.Homeitems.Where(itemid => itemid.itemid == itemids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.itemid;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].descriptions = item.descriptions;
                        k++;
                        totalBill += item.price;
                    }
                }

                int j = 0;
                int l = 0;

                //i=0,j=1,k=2,
                //i=3 j=4,k=5
                //i=6 j=7,k=8
                //i=9 j=10,k=11
                int objectcounter = 0;
                for (int i = 0; i < list.Count; i += 3)
                {

                    its[objectcounter] = new checkoutusercontrol();

                    its[objectcounter].itr3(ht[i].itemid, ht[i].imagepath, ht[i].price.ToString());
                    
                    Homeitem ht2 = new Homeitem();
                    if (j < list.Count)
                    {
                        j = i + 1;
                        if (j < list.Count)
                        {

                            if (ht[j] != null)
                                its[objectcounter].itr(ht[j].itemid, ht[j].imagepath, ht[j].price.ToString());
                        }


                    }
                    Homeitem ht3 = new Homeitem();
                    if (l < list.Count)
                    {
                        l = i + 2;
                        if (l < list.Count)
                        {

                            //  ht3 = st[k];
                            //if (ht3 != null)
                            its[objectcounter].itr2(ht[l].itemid, ht[l].imagepath, ht[l].price.ToString());
                        }


                    }

                    flowLayoutPanel2.Controls.Add(its[objectcounter]);

                    objectcounter++;
                }
                objectcounter = 0;
                
            }
            if (formname == "Beautyitem")
            {
                DataClasses6DataContext dataClasses1DataContext = new DataClasses6DataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int items = 0; items < list.Count; items++)
                {
                    int itemids = list.ElementAt(items);
                    var sf = (dataClasses1DataContext.Beauties.Where(itemid => itemid.id == itemids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.id;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].descriptions = item.descriptions;
                        k++;
                        totalBill += item.price;
                    }
                }

                int j = 0;
                int l = 0;

                //i=0,j=1,k=2,
                //i=3 j=4,k=5
                //i=6 j=7,k=8
                //i=9 j=10,k=11
                int objectcounter = 0;
                for (int i = 0; i < list.Count; i += 3)
                {

                    its[objectcounter] = new checkoutusercontrol();

                    its[objectcounter].itr3(ht[i].itemid, ht[i].imagepath, ht[i].price.ToString());
                    Homeitem ht2 = new Homeitem();
                    if (j < list.Count)
                    {
                        j = i + 1;
                        if (j < list.Count)
                        {

                            if (ht[j] != null)
                                its[objectcounter].itr(ht[j].itemid, ht[j].imagepath, ht[j].price.ToString());
                        }


                    }
                    Homeitem ht3 = new Homeitem();
                    if (l < list.Count)
                    {
                        l = i + 2;
                        if (l < list.Count)
                        {

                            //  ht3 = st[k];
                            //if (ht3 != null)
                            its[objectcounter].itr2(ht[l].itemid, ht[l].imagepath, ht[l].price.ToString());
                        }


                    }

                    flowLayoutPanel2.Controls.Add(its[objectcounter]);

                    objectcounter++;
                }
                objectcounter = 0;
            }
            if (formname == "Sportsitem")
            {
                SportssDataContext dataClasses1DataContext = new SportssDataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int items = 0; items < list.Count; items++)
                {
                    int ids = list.ElementAt(items);
                    var sf = (dataClasses1DataContext.sports.Where(itemid => itemid.itemid == ids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.itemid;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].descriptions = item.descriptions;
                        k++;
                        totalBill += item.price;
                    }
                }
                // checkoutusercontrol[] its = new checkoutusercontrol[list.Count];
                int j = 0;
                int l = 0;

                //i=0,j=1,k=2,
                //i=3 j=4,k=5
                //i=6 j=7,k=8
                //i=9 j=10,k=11
                int objectcounter = 0;
                for (int i = 0; i < list.Count; i += 3)
                {

                    its[objectcounter] = new checkoutusercontrol();

                    its[objectcounter].itr3(ht[i].itemid, ht[i].imagepath, ht[i].price.ToString());
                    Homeitem ht2 = new Homeitem();
                    if (j < list.Count)
                    {
                        j = i + 1;
                        if (j < list.Count)
                        {

                            if (ht[j] != null)
                                its[objectcounter].itr(ht[j].itemid, ht[j].imagepath, ht[j].price.ToString());
                        }


                    }
                    Homeitem ht3 = new Homeitem();
                    if (l < list.Count)
                    {
                        l = i + 2;
                        if (l < list.Count)
                        {

                            //  ht3 = st[k];
                            //if (ht3 != null)
                            its[objectcounter].itr2(ht[l].itemid, ht[l].imagepath, ht[l].price.ToString());
                        }


                    }

                    flowLayoutPanel2.Controls.Add(its[objectcounter]);

                    objectcounter++;



                }
                objectcounter = 0;
            }
            if (formname == "Kiditem")
            {
                kiditemDataContext dataClasses1DataContext = new kiditemDataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int items = 0; items < list.Count; items++)
                {
                    int ids = list.ElementAt(items);
                    var sf = (dataClasses1DataContext.kiditems.Where(itemid => itemid.itemid == ids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.itemid;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].descriptions = item.descriptions;
                        k++;
                        totalBill += item.price;
                    }
                }
                // checkoutusercontrol[] its = new checkoutusercontrol[list.Count];
                int j = 0;
                int l = 0;

                //i=0,j=1,k=2,
                //i=3 j=4,k=5
                //i=6 j=7,k=8
                //i=9 j=10,k=11
                int objectcounter = 0;
                for (int i = 0; i < list.Count; i += 3)
                {

                    its[objectcounter] = new checkoutusercontrol();

                    its[objectcounter].itr3(ht[i].itemid, ht[i].imagepath, ht[i].price.ToString());
                    Homeitem ht2 = new Homeitem();
                    if (j < list.Count)
                    {
                        j = i + 1;
                        if (j < list.Count)
                        {

                            if (ht[j] != null)
                                its[objectcounter].itr(ht[j].itemid, ht[j].imagepath, ht[j].price.ToString());
                        }


                    }
                    Homeitem ht3 = new Homeitem();
                    if (l < list.Count)
                    {
                        l = i + 2;
                        if (l < list.Count)
                        {

                            //  ht3 = st[k];
                            //if (ht3 != null)
                            its[objectcounter].itr2(ht[l].itemid, ht[l].imagepath, ht[l].price.ToString());
                        }


                    }

                    flowLayoutPanel2.Controls.Add(its[objectcounter]);

                    objectcounter++;
                }
                objectcounter = 0;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (formname == "Maleitem")
            {
                DataClasses2DataContext dataClasses1DataContext = new DataClasses2DataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int m = 0; m < list.Count; m++)
                {
                    int ids = list.ElementAt(m);
                    var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.itemid == ids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.itemid;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].quantity = item.quantity;
                        ht[k].descriptions = item.descriptions;
                        k++;

                    }
                }
                int[] quantity = new int[list.Count];
                checkoutusercontrol[] it = new checkoutusercontrol[list.Count];
                for (int i = 0; i < checkoutusercontrol.conunter; i++)
                {
                    if (i < ht.Length)
                    {

                        // it[i] = new checkoutusercontrol();
                        int item1count = its[i].itemcount[i];
                        int item2count = its[i].item2count;
                        int item3count = its[i].item3count;
                        int counter = 0;
                        for (int n = 0; n < list.Count; n++)
                        {

                            if (n < ht.Length)
                            {
                                quantity[n] = (int)ht[n].quantity;
                                if (n != 0)
                                {
                                    if (n % 3 == 0)
                                    {
                                        i++;
                                        counter = 0;
                                        if (its[i].itemcount[counter] != 0)
                                            quantity[n] = quantity[n] - its[i].itemcount[counter];
                                    }
                                    else
                                    {
                                        if (its[i].itemcount[counter] != 0)
                                            quantity[n] = quantity[n] - its[i].itemcount[counter];
                                    }
                                }
                                else
                                {
                                    if (its[i].itemcount[counter] != 0)
                                        quantity[n] = quantity[n] - its[i].itemcount[counter];
                                }
                            }
                            counter++;
                        }

                    }







                }

                for (int j = 0; j < quantity.Length; j++)
                {
                    DataClasses5DataContext dataClass = new DataClasses5DataContext();
                    int ids = list.ElementAt(j);
                    Maleitem mt = dataClass.Maleitems.Single(itemid => itemid.itemid == ids);
                    mt.quantity = quantity[j];
                    dataClass.SubmitChanges();
                }

                idlist.Clear();
                checkoutusercontrol.conunter = 0;
            }
            if (formname == "Femaleitem")
            {
                DataClasses3DataContext dataClasses1DataContext = new DataClasses3DataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int m = 0; m < list.Count; m++)
                {
                    int ids = list.ElementAt(m);
                    var sf = (dataClasses1DataContext.Femaleitems.Where(itemid => itemid.itemid == ids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.itemid;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].quantity = item.quantity;
                        ht[k].descriptions = item.descriptions;
                        k++;

                    }
                }
                int[] quantity = new int[list.Count];
                checkoutusercontrol[] it = new checkoutusercontrol[list.Count];
                for (int i = 0; i < checkoutusercontrol.conunter; i++)
                {


                    quantity[i] = (int)ht[i].quantity;
                    // it[i] = new checkoutusercontrol();
                    int item1count = its[i].itemcount[i];
                    int item2count = its[i].item2count;
                    int item3count = its[i].item3count;
                    int counter = 0;
                    for (int n = 0; n < list.Count; n++)
                    {

                        if (n < ht.Length)
                        {
                            quantity[n] = (int)ht[n].quantity;
                            if (n != 0)
                            {
                                if (n % 3 == 0)
                                {
                                    i++;
                                    counter = 0;
                                    if (its[i].itemcount[counter] != 0)
                                        quantity[n] = quantity[n] - its[i].itemcount[counter];
                                }
                                else
                                {
                                    if (its[i].itemcount[counter] != 0)
                                        quantity[n] = quantity[n] - its[i].itemcount[counter];
                                }
                            }
                            else
                            {
                                if (its[i].itemcount[counter] != 0)
                                    quantity[n] = quantity[n] - its[i].itemcount[counter];
                            }
                        }
                        counter++;
                    }

                }

                for (int j = 0; j < quantity.Length; j++)
                {
                    DataClasses3DataContext dataClass = new DataClasses3DataContext();
                    int ids = list.ElementAt(j);
                    Femaleitem mt = dataClass.Femaleitems.Single(itemid => itemid.itemid == ids);
                    mt.quantity = quantity[j];
                    dataClass.SubmitChanges();
                }
                idlist.Clear();
                checkoutusercontrol.conunter = 0;
            }
            if (formname == "Homeitem")
            {
                DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int m = 0; m < list.Count; m++)
                {
                    int ids = list.ElementAt(m);
                    var sf = (dataClasses1DataContext.Homeitems.Where(itemid => itemid.itemid == ids)).ToList();
                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.itemid;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].quantity = item.quantity;
                        ht[k].descriptions = item.descriptions;
                        k++;

                    }
                }
                int[] quantity = new int[list.Count];
                checkoutusercontrol[] it = new checkoutusercontrol[list.Count];
                for (int i = 0; i < checkoutusercontrol.conunter; i++)
                {


                    // it[i] = new checkoutusercontrol();
                    int item1count = its[i].itemcount[i];
                    int item2count = its[i].item2count;
                    int item3count = its[i].item3count;
                    int counter = 0;
                    for (int n = 0; n < list.Count; n++)
                    {

                        if (n < ht.Length)
                        {
                            quantity[n] = (int)ht[n].quantity;
                            if (n != 0)
                            {
                                if (n % 3 == 0)
                                {
                                    i++;
                                    counter = 0;
                                    if (its[i].itemcount[counter] != 0)
                                        quantity[n] = quantity[n] - its[i].itemcount[counter];
                                }
                                else
                                {
                                    if (its[i].itemcount[counter] != 0)
                                        quantity[n] = quantity[n] - its[i].itemcount[counter];
                                }
                            }
                            else
                            {
                                if (its[i].itemcount[n] != 0)
                                    quantity[n] = quantity[n] - its[i].itemcount[counter];
                            }
                        }
                        counter++;
                    }

                }

                for (int j = 0; j < quantity.Length; j++)
                {
                    DataClasses1DataContext dataClass = new DataClasses1DataContext();
                    int ids = list.ElementAt(j);
                    Homeitem mt = dataClass.Homeitems.Single(itemid => itemid.itemid == ids);
                    mt.quantity = quantity[j];
                    dataClass.SubmitChanges();
                }
                idlist.Clear();
                checkoutusercontrol.conunter = 0;
            }
            if (formname == "Beautyitem")
            {
                DataClasses6DataContext dataClasses1DataContext = new DataClasses6DataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int m = 0; m < list.Count; m++)
                {
                    int ids = list.ElementAt(m);
                    var sf = (dataClasses1DataContext.Beauties.Where(itemid => itemid.id == ids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.id;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].quantity = item.quantity;
                        ht[k].descriptions = item.descriptions;
                        k++;

                    }
                }
                int[] quantity = new int[list.Count];
                checkoutusercontrol[] it = new checkoutusercontrol[list.Count];
                for (int i = 0; i < checkoutusercontrol.conunter; i++)
                {


                    // it[i] = new checkoutusercontrol();
                    int item1count = its[i].itemcount[i];
                    int item2count = its[i].item2count;
                    int item3count = its[i].item3count;
                    int counter = 0;
                    for (int n = 0; n < list.Count; n++)
                    {

                        if (n < ht.Length)
                        {
                            quantity[n] = (int)ht[n].quantity;
                            if (n != 0)
                            {
                                if (n % 3 == 0)
                                {
                                    i++;
                                    counter = 0;
                                    if (its[i].itemcount[counter] != 0)
                                        quantity[n] = quantity[n] - its[i].itemcount[counter];
                                }
                                else
                                {
                                    if (its[i].itemcount[counter] != 0)
                                        quantity[n] = quantity[n] - its[i].itemcount[counter];
                                }
                            }
                            else
                            {
                                if (its[i].itemcount[counter] != 0)
                                    quantity[n] = quantity[n] - its[i].itemcount[counter];
                            }
                        }
                        counter++;
                    }

                }

                for (int j = 0; j < quantity.Length; j++)
                {
                    DataClasses6DataContext dataClass = new DataClasses6DataContext();
                    int ids = list.ElementAt(j);
                    Beauty mt = dataClass.Beauties.Single(itemid => itemid.id == ids);
                    mt.quantity = quantity[j];
                    dataClass.SubmitChanges();
                }
                idlist.Clear();
                checkoutusercontrol.conunter = 0;
            }
            if (formname == "Sportsitem")
            {
                SportssDataContext dataClasses1DataContext = new SportssDataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int m = 0; m < list.Count; m++)
                {
                    int ids = list.ElementAt(m);
                    var sf = (dataClasses1DataContext.sports.Where(itemid => itemid.itemid == ids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.itemid;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].quantity = item.quantity;
                        ht[k].descriptions = item.descriptions;
                        k++;

                    }
                }
                int[] quantity = new int[list.Count];
                checkoutusercontrol[] it = new checkoutusercontrol[list.Count];
                for (int i = 0; i < checkoutusercontrol.conunter; i++)
                {



                    // it[i] = new checkoutusercontrol();
                    int item1count = its[i].itemcount[i];
                    int item2count = its[i].item2count;
                    int item3count = its[i].item3count;

                    int counter = 0;
                    for (int n = 0; n < list.Count; n++)
                    {

                        if (n < ht.Length)
                        {
                            quantity[n] = (int)ht[n].quantity;
                            if (n != 0)
                            {
                                if (n % 3 == 0)
                                {
                                    i++;
                                    counter = 0;
                                    if (its[i].itemcount[counter] != 0)
                                        quantity[n] = quantity[n] - its[i].itemcount[counter];
                                }
                                else
                                {
                                    if (its[i].itemcount[counter] != 0)
                                        quantity[n] = quantity[n] - its[i].itemcount[counter];
                                }
                            }
                            else
                            {
                                if (its[i].itemcount[n] != 0)
                                    quantity[n] = quantity[n] - its[i].itemcount[counter];
                            }
                        }
                        counter++;
                    }
                }

                for (int j = 0; j < quantity.Length; j++)
                {
                    SportssDataContext dataClass = new SportssDataContext();
                    int ids = list.ElementAt(j);
                    sport mt = dataClass.sports.Single(itemid => itemid.itemid == ids);
                    mt.quantity = quantity[j];
                    dataClass.SubmitChanges();
                }
                idlist.Clear();
                checkoutusercontrol.conunter = 0;
            }

            if (formname == "Kiditem")
            {
                kiditemDataContext dataClasses1DataContext = new kiditemDataContext();

                List<Homeitem> st = new List<Homeitem>();
                //var sf = (dataClasses1DataContext.Maleitems.Where(itemid => itemid.Equals(list.ElementAt(0))));
                List<Homeitem> st2 = new List<Homeitem>();
                int k = 0;
                int h = 0;

                Homeitem[] ht = new Homeitem[list.Count];
                for (int m = 0; m < list.Count; m++)
                {
                    int ids = list.ElementAt(m);
                    var sf = (dataClasses1DataContext.kiditems.Where(itemid => itemid.itemid == ids)).ToList();



                    foreach (var item in sf)
                    {
                        ht[k] = new Homeitem();
                        ht[k].itemid = item.itemid;
                        ht[k].itemname = item.itemname;
                        ht[k].imagepath = item.imagepath;
                        ht[k].price = item.price;
                        ht[k].quantity = item.quantity;
                        ht[k].descriptions = item.descriptions;
                        k++;

                    }
                }
                int[] quantity = new int[list.Count];
                checkoutusercontrol[] it = new checkoutusercontrol[list.Count];
                for (int i = 0; i < checkoutusercontrol.conunter; i++)
                {
                    if (i < ht.Length)
                    {

                        // it[i] = new checkoutusercontrol();
                        int item1count = its[i].itemcount[i];
                        int item2count = its[i].item2count;
                        int item3count = its[i].item3count;
                        int counter = 0;
                        for (int n = 0; n < list.Count; n++)
                        {

                            if (n < ht.Length)
                            {
                                quantity[n] = (int)ht[n].quantity;
                                if (n != 0)
                                {
                                    if (n % 3 == 0)
                                    {
                                        i++;
                                        counter = 0;
                                        if (its[i].itemcount[counter] != 0)
                                            quantity[n] = quantity[n] - its[i].itemcount[counter];
                                    }
                                    else
                                    {
                                        if (its[i].itemcount[counter] != 0)
                                            quantity[n] = quantity[n] - its[i].itemcount[counter];
                                    }
                                }
                                else
                                {
                                    if (its[i].itemcount[counter] != 0)
                                        quantity[n] = quantity[n] - its[i].itemcount[counter];
                                }
                            }
                            counter++;
                        }

                    }
                }

                for (int j = 0; j < quantity.Length; j++)
                {
                    kiditemDataContext dataClass = new kiditemDataContext();
                    int ids = list.ElementAt(j);
                    kiditem mt = dataClass.kiditems.Single(itemid => itemid.itemid == ids);
                    mt.quantity = quantity[j];
                    dataClass.SubmitChanges();
                }

                idlist.Clear();
                checkoutusercontrol.conunter = 0;

            }
            MessageBox.Show("Your Order Has Been Placed Successfully!", "Success",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            OrderSummary order = new OrderSummary(totalBill);
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Clear();
            idlist.Clear();
            form = "";
            flowLayoutPanel2.Controls.Clear();
        }
    }

}
