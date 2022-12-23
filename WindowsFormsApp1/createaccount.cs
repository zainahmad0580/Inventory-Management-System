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
    public partial class createaccount : Form
    {
        public createaccount()
        {
            InitializeComponent();
        }

        private void back_log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            bool exists = false;
            string email=Email.Text;
            AccountDataContext d = new AccountDataContext();
            var data = (from s in d.Accounts select s).ToList();
            foreach(var account in data)
            {
                if(account.email == email)
                {
                    exists = true;
                }
            }
            string passwords = "";
            if (confirm_password.Text == password.Text)
            {
                 passwords = password.Text;
            }
            else
            {
                MessageBox.Show("Passwords did not match", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!exists)
            {
                AccountDataContext dataClasses4DataContext = new AccountDataContext();
                createnewaccount cr = new createnewaccount();
                cr.email = email;
                cr.password = passwords;
                Account r = new Account();
                r.email = email;
                r.passwords = passwords;
                dataClasses4DataContext.Accounts.InsertOnSubmit(r);
                dataClasses4DataContext.SubmitChanges();
                MessageBox.Show("Account Created Successfully!", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                MessageBox.Show("Username already exists!", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

        }

        private void createaccount_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void see_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
