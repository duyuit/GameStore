﻿using SteamDAL.DAO;
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
        private Login login = null;

        public event EventHandler OnDataAvailable;
        public string idText { get; private set; }
        public static bool idCheckChange = false;

        public Register()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 46, 51);
            LOGO.Image = Properties.Resources.steam_logo;
            txtID.BackColor = Color.FromArgb(42, 46, 51);
            txtPass.BackColor = Color.FromArgb(42, 46, 51);
            txtRe.BackColor = Color.FromArgb(42, 46, 51);
            txtMail.BackColor = Color.FromArgb(42, 46, 51);
            txtFullname.BackColor = Color.FromArgb(42, 46, 51);
            txtPhone.BackColor = Color.FromArgb(42, 46, 51);
        }

        public Register(string username)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 46, 51);
            LOGO.Image =  Properties.Resources.steam_logo;
            txtID.BackColor = Color.FromArgb(42, 46, 51);
            txtPass.BackColor = Color.FromArgb(42, 46, 51);
            txtRe.BackColor = Color.FromArgb(42, 46, 51);
            txtMail.BackColor = Color.FromArgb(42, 46, 51);
            txtFullname.BackColor = Color.FromArgb(42, 46, 51);
            txtPhone.BackColor = Color.FromArgb(42, 46, 51);

            this.txtMail.Text = username;
            this.Text = "Change Account";
            this.txtMail.Enabled = false;
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

            if (txtWarningRePass.Visible == false && txtRe.Text.Length == 0)
            {
                txtWarningRePass.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idText = "";
            if (OnDataAvailable != null)
                OnDataAvailable(this, EventArgs.Empty);

            if (!idCheckChange)
            {
                this.Close();
                this.login = new Login();
            }
            else
            {
                this.Close();
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

            //register
            if (!idCheckChange)
            {
                this.idText = this.txtMail.Text; // idText = mailText

                if (txtFullname.Text.Length == 0)
                {
                    txtWarningFullName.Visible = true;
                    MessageBox.Show("Full name is required!");
                }
                else if (txtID.Text.Length == 0)
                {
                    txtWarningName.Visible = true;
                    MessageBox.Show("User name is required!");
                }
                else if (!reg.IsMatch(this.idText))
                {
                    txtWarningMail.Visible = true;
                    MessageBox.Show("Mail not yet entered or wrong format!");
                }
                else if (this.txtPass.Text.Length < 8)
                {
                    txtWarningPass.Visible = true;
                    MessageBox.Show("Password not yet entered or wrong format!");
                }
                else if (!this.txtPass.Text.Equals(this.txtRe.Text))
                {
                    txtWarningRePass.Visible = true;
                    MessageBox.Show("Passwords not match!");
                }
                else if (txtPhone.Text.Length == 0)
                {
                    txtWarningPhone.Visible = true;
                    MessageBox.Show("Phone number is required!");
                }
                else //register account
                {
                    string result = "";
                    result = AccountsControllerShould.PostNewAccountController(
                        new RegisterObject(txtMail.Text, txtPass.Text, "defaulthobbies",
                        txtFullname.Text, txtPhone.Text, txtID.Text));

                    if (result == "True") //rs = isSuccess
                    {
                        MessageBox.Show("Register success!");
                        this.Close();

                        this.login = new Login();
                        this.login.Show();
                    }
                    else //rs = failed msg
                    {
                        if (result.Equals("System.Collections.Generic.List`1[Microsoft.AspNetCore.Identity.IdentityError]"))
                        {
                            MessageBox.Show("Register failed. User name already exists!");
                        }
                        else
                        {
                            MessageBox.Show("Register failed. Email already exists!");
                        }
                    }
                }
            }
            //change
            else
            {
                //MessageBox.Show(txtMail.Text);
                this.Close();
            }




        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            idText = "";
            if (OnDataAvailable != null)
                OnDataAvailable(this, EventArgs.Empty);

            if (!idCheckChange)
            {
                this.login = new Login();
                this.login.Show();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPass.Text.Length > 0 && this.txtPass.Text.Length < 8)
            {
                txtWarningPass.Visible = true;
            }
            //else if(txtWarningPass.Visible == true && this.txtPass.Text.Length == 0)
            //{
            //    txtWarningPass.Visible = false;
            //}
            else if (this.txtPass.Text.Length >= 8)
            {
                txtWarningPass.Visible = false;
            }


            //Duy wrote
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
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

            if (reg.IsMatch(this.txtMail.Text))
            {
                txtWarningMail.Visible = false;
            }
            else
            {
                txtWarningMail.Visible = true;
            }

            //if (txtMail.Text.Contains('@') && txtMail.Text.Contains('.'))
            //{
            //    txtWarningMail.Visible = false;
            //}

            //if(txtWarningMail.Visible == true && txtMail.Text.Length == 0)
            //{
            //    txtWarningMail.Visible = false;
            //}
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

        private void txtMail_MouseHover(object sender, EventArgs e)
        {
        }

        private void txtMail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtMail.Text.Length == 0)
            {
                txtWarningMail.Visible = true;
            }
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPass.Text.Length == 0)
            {
                txtWarningPass.Visible = true;
            }
        }

        private void txtRe_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtRe.Text.Length == 0)
            {
                txtWarningRePass.Visible = true;
            }
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            if (txtWarningFullName.Visible == true && txtFullname.Text.Length > 0)
            {
                txtWarningFullName.Visible = false;
            }
            else if (txtWarningFullName.Visible == false && txtFullname.Text.Length == 0)
            {
                txtWarningFullName.Visible = true;
            }
        }

        private void txtFullname_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtFullname.Text.Length == 0)
            {
                txtWarningFullName.Visible = true;
            }
        }

        private void txtPhone_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPhone.Text.Length == 0)
            {
                txtWarningPhone.Visible = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtWarningPhone.Visible == true && txtPhone.Text.Length > 0)
            {
                txtWarningPhone.Visible = false;
            }
            else if (txtWarningPhone.Visible == false && txtPhone.Text.Length == 0)
            {
                txtWarningPhone.Visible = true;
            }

        }
    }
}
