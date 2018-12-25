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
        MyHome myHome = null;

        public Freecode()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(21, 53, 77);
        }

        public Freecode(string id, MyHome home)
        {
            InitializeComponent();

            this.id = id;
            myHome = home;
            this.BackColor = Color.FromArgb(21, 53, 77);
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
                    for (int i = 0; i < myHome.lib_game.Count(); i++)
                    {
                        if (myHome.lib_game.ElementAt(i).Id.ToString() == response.Payload.gameId)
                        {
                            myHome.user_game.Add(myHome.lib_game.ElementAt(i));
                            break;
                        }
                    }
                    myHome.showListGame();
                    myHome.setLibpanelVisible(true);
                    myHome.setStorepanelVisible(false);
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void Freecode_FormClosing(object sender, FormClosingEventArgs e)
        {
            myHome.Enabled = true;
        }
    }
}
