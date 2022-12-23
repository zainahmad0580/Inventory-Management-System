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

    public partial class Login : Form
    {
        public static bool logincheck = false;

        public Login()
        {
            InitializeComponent();
           

        }

        private void regis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            createaccount ca = new createaccount();
            this.Hide();
            ca.Show();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                AccountDataContext d = new AccountDataContext();
                string emails = email.Text;
                string passwords = password.Text;
                
                var data = d.Accounts.Where(itemids => itemids.email == emails && itemids.passwords == passwords).ToList();
                if (data.Count > 0)
                {
                    logincheck = true;
                    checkout ch = new checkout();
                    this.Hide();
                    ch.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Email or password", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
