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
                label5.Visible = false;
            }
            else label5.Visible = true;
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
           

            if (OnDataAvailable != null)
                OnDataAvailable(this, EventArgs.Empty);

            this.Close();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            idText = "";
            if (OnDataAvailable != null)
                OnDataAvailable(this, EventArgs.Empty);
            
        }
    }
}
