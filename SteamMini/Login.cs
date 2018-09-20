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
            pictureBox1.Image = Properties.Resources.gd;
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
            MyHome a = new MyHome();
            
            a.Show();
           
        }
    }
}
