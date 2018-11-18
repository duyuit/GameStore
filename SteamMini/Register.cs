using SteamDAL.DAO;
using SteamMini.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SteamMini
{
    public partial class Register : Form
    {
        public event EventHandler OnDataAvailable;
        public string idText { get; private set; }
    public Register()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 46, 51);
            LOGO.Image =  Properties.Resources.steam_logo;
            txtID.BackColor = Color.FromArgb(42, 46, 51);
            txtPass.BackColor = Color.FromArgb(42, 46, 51);
            txtRe.BackColor = Color.FromArgb(42, 46, 51);
            txtMail.BackColor = Color.FromArgb(42, 46, 51);
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtWarningRePass.Visible == false && !txtPass.Text.Equals(txtRe.Text))
            {
                txtWarningRePass.Visible = true;
            }
            else if (txtWarningRePass.Visible == true && txtPass.Text.Equals(txtRe.Text))
            {
                txtWarningRePass.Visible = false;
            }
            else if(txtWarningRePass.Visible == true && txtRe.Text.Length == 0)
            {
                txtWarningRePass.Visible = false;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            idText = "";
            if (OnDataAvailable != null)
                OnDataAvailable(this, EventArgs.Empty);
            this.Close();
            
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.idText = this.txtMail.Text; // idText = mailText

            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

            if (txtID.Text.Length == 0)
            {
                MessageBox.Show("Display name is required!");
            }
            else if (!reg.IsMatch(this.idText))
            {
                MessageBox.Show("Mail not yet entered or wrong format!");
            }
            else if (this.txtPass.Text.Length < 8)
            {
                MessageBox.Show("Password not yet entered or wrong format!");
            }
            else if(!this.txtPass.Text.Equals(this.txtRe.Text))
            {
                MessageBox.Show("Passwords not match!");
            }
            else //register account
            {
                string result = "";
                result = AccountsControllerShould.PostNewAccountController(
                    new RegisterObject(txtMail.Text, txtPass.Text, "hobbies",
                    "fullname", "0363538331", txtID.Text));

                if (result == "False")
                {
                    MessageBox.Show("Register failed. This mail is duplicate!");
                }
                else
                {
                    MessageBox.Show("Register success!");
                    this.Close();
                }
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            idText = "";
            if (OnDataAvailable != null)
                OnDataAvailable(this, EventArgs.Empty);
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPass.Text.Length > 0 && this.txtPass.Text.Length < 8)
            {
                txtWarningPass.Visible = true;
            }
            else if(txtWarningPass.Visible == true && this.txtPass.Text.Length == 0)
            {
                txtWarningPass.Visible = false;
            }
            else
            {
                txtWarningPass.Visible = false;
            }

            //bool containSpecial = false;
            //bool containNormal = false;
            //for (int i=33;i<=96;i++)
            //{
            //    if (txtPass.Text.Contains((char)i))
            //    {
            //        containSpecial = true;
            //        break;
            //    }

            //}
            //for (int i = 65; i <= 122; i++)
            //{
            //    if (txtPass.Text.Contains((char)i))
            //    {
            //        containNormal = true;
            //        break;
            //    }
            //}
            //if (containNormal && containSpecial)
            //{
            //    txtWarningPass.Visible = false;
            //}
            //else txtWarningPass.Visible = true;
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if(txtMail.Text.Contains('@') && txtMail.Text.Contains('.'))
            {
                txtWarningMail.Visible = false;
            }
            else txtWarningMail.Visible = true;

            if(txtWarningMail.Visible == true && txtMail.Text.Length == 0)
            {
                txtWarningMail.Visible = false;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtWarningPass_Click(object sender, EventArgs e)
        {

        }
        private void txtWarningName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtWarningName.Visible == true && txtID.Text.Length > 0)
            {
                txtWarningName.Visible = false;
            }
            else if (txtWarningName.Visible == false && txtID.Text.Length == 0)
            {
                txtWarningName.Visible = true;
            }
        }

        private void txtID_MouseEnter(object sender, EventArgs e)
        {
        }

        private void txtWarningName_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtID_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtID.Text.Length == 0)
            {
                txtWarningName.Visible = true;
            }
        }
    }
}
