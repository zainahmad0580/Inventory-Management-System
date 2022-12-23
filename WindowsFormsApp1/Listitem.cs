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
    public partial class Listitem : UserControl
    {
        public Listitem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Mens m=new Mens();
            m.Show();
        }
        

        private void label2_Click_1(object sender, EventArgs e)
        {
            women wo = new women();
            wo.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Kiditem kd = new Kiditem();
            kd.Show();
            this.Hide();
        }
    }
}
