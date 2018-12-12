using GameStore.DTOs;
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
    public partial class Freecode : Form
    {
        private string id = null;

        public Freecode()
        {
            InitializeComponent();
        }

        public Freecode(string id)
        {
            InitializeComponent();

            this.id = id;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFreecode.Text))
            {
                MessageBox.Show("You should enter free code!", "Error");
            }
            else
            {
                var response = AccountsControllerShould.PostEnterFreeCodeAccountController(new FreeCode(txtFreecode.Text), id);

                var rs = response.IsSuccess.ToString();
                var mess = response.Message;

                if (rs == "False")
                {
                    if (mess.Equals("Object reference not set to an instance of an object."))
                    {
                        txtFreecode.Text = "";
                        MessageBox.Show("Free code is wrong!", "Error");
                    }
                    else
                    {
                        txtFreecode.Text = "";
                        MessageBox.Show("Free code used!\nYou already have this game!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Get game success!");
                    this.Close();


                    //update temp game on library

                    //enable form MyHome
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
         
            //enable form MyHome
        }
    }
}
