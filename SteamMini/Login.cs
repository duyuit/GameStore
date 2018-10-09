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
  
    public partial class Login : Form
    {
       private Register register = null;
        public Login()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"..\..\Resources\" + "logo-facebook" + ".png");
            string a =System.IO.Directory.GetCurrentDirectory();
            pictureBox2.Image = Properties.Resources.logo_facebook;
            pictureBox3.Image = Properties.Resources.steam_logo;
            this.BackColor = Color.FromArgb(42, 46, 51);
            txtID.BackColor = Color.FromArgb(42, 46, 51);
            txtPass.BackColor = Color.FromArgb(42, 46, 51);
        }
        void formB_OnDataAvailable(object sender, EventArgs e)
        {
            //Event handler for when FormB fires off the event
            this.txtID.Text = register.idText;
            this.Enabled = true;
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.register = new Register();

            //FormA subscribes to FormB's event
            register.OnDataAvailable += new EventHandler(formB_OnDataAvailable);
            register.Show();
            this.Enabled = false;
        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.Close();
            //if (txtID.Text != "" && txtPass.Text != "")
            //{
            //    string rs=BaseController.ExecutePostRequest("Auths", new LoginObject(txtID.Text, txtPass.Text));
            //    if(rs.Equals("BadRequest") || rs.Equals("Unauthorized"))
            //    {
            //        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu","Error");

            //    }
            //    else
            //    {

            //        MyHome a = new MyHome(txtID.Text);
            //        a.Show();
   
            //        this.Hide();           //Hide the main form before showing the secondary
            //        a.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            //        this.Show();           //When frm2 is closed, continue with the code (show main form)
            //    }
            //}
            //else MessageBox.Show("Chưa nhập đủ thông  tin");


            MyHome b = new MyHome("hoa");
           b.Show();

            this.Hide();           //Hide the main form before showing the secondary
            b.Show();     //Show secondary form, code execution stop until frm2 is closed
            this.Hide();           //When frm2 is closed, continue with the code (show main form)

        }
    }
}
