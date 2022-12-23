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
    public partial class OrderSummary : Form
    {
        DateTime dateTime = DateTime.Now;
        public OrderSummary(int? totalBill)
        {
            InitializeComponent();
            label1.Text += totalBill.ToString();
            label3.Text += dateTime;
        }

        private void OrderSummary_Load(object sender, EventArgs e)
        {

        }
    }
}
