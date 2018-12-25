using SteamDAL.DAO;
using SteamMini.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SteamMini
{
  
    public partial class Login : Form
    {
       private Register register = null;
        public Login()
        {
            InitializeComponent();
            string a =System.IO.Directory.GetCurrentDirectory();
            pictureBox3.Image = Properties.Resources.steam_logo;
            this.BackColor = Color.FromArgb(42, 46, 51);
            txtID.BackColor = Color.FromArgb(42, 46, 51);
            txtPass.BackColor = Color.FromArgb(42, 46, 51);
        }
        void formB_OnDataAvailable(object sender, EventArgs e)
        {
            //Event handler for when FormB fires off the event
            //this.txtID.Text = register.idText;
            this.Enabled = true;
        }


        private void Login_Load(object sender, EventArgs e)
        {
            progressBar.Value = 20;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

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
            int check = 0;

            //txtID: username/email
            if (txtID.Text != "" && txtPass.Text != "")
            {
                //Loading_Bar(check);

                LoginObject loginObject = new LoginObject(txtID.Text, txtPass.Text);
                string rs = AuthsControllerShould.LoginController(loginObject);
                if (rs.Equals("user"))
                {
                    check = 1;
                    //Loading_Bar(check);
                    MessageBox.Show("Account does not exist!\nYou should register it!", "Error");
                }
                else if (rs.Equals("pass"))
                {
                    check = 2;
                    //Loading_Bar(check);
                    MessageBox.Show("Password incorrect!", "Error");
                }
                else // login correctly, received token, id
                {
                    string id = rs;
                    MyHome a = new MyHome(id, txtPass.Text); //pass: //add wishgame

                    check = 3;
                    //Loading_Bar(check);

                    a.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Information is not enough!");
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtID: username/email
                if (txtID.Text != "" && txtPass.Text != "")
                {
                    LoginObject loginObject = new LoginObject(txtID.Text, txtPass.Text);
                    string rs = AuthsControllerShould.LoginController(loginObject);
                    //if (rs.Equals("user"))
                    //{
                    //    MessageBox.Show("Account does not exist!\nYou should register it!", "Error");
                    //}
                    //else if (rs.Equals("pass"))
                    //{
                    //    MessageBox.Show("Password incorrect!", "Error");
                    //}
                    //else // login correctly, received token, id
                    //{
                    //    string id = rs;
                    //    MyHome a = new MyHome(id);
                    //    a.Show();
                    //    this.Hide();
                    //}

                    if (!rs.Equals("user") && !rs.Equals("pass"))
                    {
                        string id = rs;
                        MyHome a = new MyHome(id, txtPass.Text);
                        a.Show();
                        this.Hide();
                    }
                }
                //else MessageBox.Show("Information is not enough!");
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            //if (!char.IsControl(Keys.Enter) && !char.IsDigit(Keys.Enter))
            //{
            //    e.Handled = true;
            //}
        }

        public void Loading_Bar(int check)
        {
            int i = 1;
            progressBar.Show();
            if (check == 0)
            {
                for (int j=0; ;j++)
                {
                    Thread.Sleep(10);
                    progressBar.Value = i;
                    progressBar.Update();

                    if (i == 100)
                    {
                        i = -1;
                    }
                    i++;
                }
            }
            else
            {
                progressBar.Hide();
            }

        }

       
    }
}
