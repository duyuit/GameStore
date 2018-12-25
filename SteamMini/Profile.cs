using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameStore.DTOs;

namespace SteamMini
{
    public partial class Profile : Form
    {
        List<Image> background = new List<Image>();
        private static GameStore.DTOs.PayloadBody user = null;
        private MyHome myHome = null;

        private static string id = "";
        private static float currmoney = 0;


        public Profile(GameStore.DTOs.PayloadBody input, MyHome home)
        {
            user = input;
            InitializeComponent();
            panel1.BackColor=Color.FromArgb(42, 46, 51);
            avatar.Image = Properties.Resources.gta5;
            listGame.BackColor = Color.FromArgb(42, 46, 51);

            listGame.SmallImageList = imageList1;
            LoadPurchased();

            SoDuText.Text = "Money: $" + Math.Round(user.Money, 2).ToString();
            this.myHome = home;
        }

        public static void SetUser(GameStore.DTOs.PayloadBody inputUser, string Id)
        {
            user = inputUser;
            id = Id;
            currmoney = inputUser.Money;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            UserName.Text = user.UserName;
            //avatar.Load(user.ImageUser.UrlOnline);
        }
        private void LoadPurchased()
        {
            listGame.Clear();
            foreach (TitleGame game in user.Games)
            {
                ListViewItem item = new ListViewItem();
                item.Name = game.Id.ToString();
                item.Text = game.Name;

                //add logo cho itemlistview
                System.Net.WebRequest request = System.Net.WebRequest.Create(game.ImageGames.ElementAt(0).UrlOnline);
                System.Net.WebResponse resp = request.GetResponse();
                System.IO.Stream respStream = resp.GetResponseStream();
                Bitmap bmp = new Bitmap(respStream);
                respStream.Dispose();

                imageList1.Images.Add("Icon" + game.Name, bmp);
                item.ImageKey = "Icon" + game.Name;

                listGame.Items.Add(item);
            }
            Wished.BorderStyle = BorderStyle.None;
            Purchased.BorderStyle = BorderStyle.Fixed3D;
        }
        private void LoadWish()
        {
            listGame.Clear();
            foreach (TitleGame game in user.WishGames)
            {
                ListViewItem item = new ListViewItem();
                item.Name = game.Id.ToString();
                item.Text = game.Name;

                //add logo cho itemlistview
                System.Net.WebRequest request = System.Net.WebRequest.Create(game.ImageGames.ElementAt(0).UrlOnline);
                System.Net.WebResponse resp = request.GetResponse();
                System.IO.Stream respStream = resp.GetResponseStream();
                Bitmap bmp = new Bitmap(respStream);
                respStream.Dispose();

                imageList1.Images.Add("Icon" + game.Name, bmp);
                item.ImageKey = "Icon" + game.Name;

                listGame.Items.Add(item);
            }
            Wished.BorderStyle = BorderStyle.Fixed3D;
            Purchased.BorderStyle = BorderStyle.None;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RechargeButton_Click(object sender, EventArgs e)
        {
            if (RechargeTextBox.Text != "")
            {
                float addmoney = float.Parse(RechargeTextBox.Text);
                var response = AccountsControllerShould.UpdateMoneyAccountController(new RechargeObject(currmoney + addmoney), id);

                if (response.IsSuccess.ToString() == "False")
                {
                    MessageBox.Show("Recharge failed!\nUser Id is wrong!", "Error");
                }
                else
                {
                    RechargeTextBox.Text = "";
                    currmoney += addmoney;
                    SoDuText.Text = "Money: $" + Math.Round(currmoney, 2);

                    MessageBox.Show($"Recharge success!\nYour account has ${Math.Round(currmoney, 2)}!", "Success");
                }
            }
            else
            {
                MessageBox.Show("Money have not entered yet!", "Error");
            }
        }

        private void RechargeTextBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void RechargeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LoadPurchased();
        }

        private void Wished_Click(object sender, EventArgs e)
        {
            LoadWish();
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            myHome.Enabled = true;
        }

        private void RechargeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
