using SteamDAL.DAO;
using SteamMini.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if(txtPass.Text.Equals(txtRe.Text))
            {
                txtWarningRePass.Visible = false;
            }
            else txtWarningRePass.Visible = true;
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
            this.idText = this.txtID.Text;
            if (this.txtID.Text != "" && this.txtPass.Text != "" && this.txtRe.Text != "" && this.txtMail.Text != ""
                && txtWarningMail.Visible && txtWarningPass.Visible)
            {
                string result = BaseController.ExecutePostRequest("accounts", new RegisterObject(txtID.Text, txtPass.Text));
                if (result != "")
                {
                    if (result.Contains(txtID.Text))
                    {
                        if (result.Contains("DuplicateUserName"))
                            MessageBox.Show("Tài khoản này đã được đăng kí, vui lòng chọn ID khác");
                        else
                            MessageBox.Show("Đăng kí thành công");
                    }
                   
                    else
                    {
                        MessageBox.Show("Đăng kí lỗi");
                    }
                }
                if (OnDataAvailable != null)
                    OnDataAvailable(this, EventArgs.Empty);

                this.Close();
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
            bool containSpecial = false;
            bool containNormal = false;
            for (int i=33;i<=96;i++)
            {
                if (txtPass.Text.Contains((char)i))
                {
                    containSpecial = true;
                    break;
                }
                   
            }
            for (int i = 65; i <= 122; i++)
            {
                if (txtPass.Text.Contains((char)i))
                {
                    containNormal = true;
                    break;
                }

            }
            if (containNormal && containSpecial)
            {
                txtWarningPass.Visible = false;
            }
            else txtWarningPass.Visible = true;
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if(txtMail.Text.Contains('@') && txtMail.Text.Contains('.'))
            {
                txtWarningMail.Visible = false;
            }
            else txtWarningMail.Visible = true;
        }
    }
}
