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
        GameStore.DTOs.PayloadBody user = null;

        public Profile(GameStore.DTOs.PayloadBody input)
        {
            user = input;
            InitializeComponent();
            panel1.BackColor=Color.FromArgb(42, 46, 51);
            avatar.Image = Properties.Resources.gta5;
            listGame.BackColor = Color.FromArgb(42, 46, 51);

            listGame.SmallImageList = imageList1;
            LoadPurchased();
            SoDuText.Text = "Money: " + user.Money.ToString();
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

        //thai.caodu nut nap tien
        private void RechargeButton_Click(object sender, EventArgs e)
        {

        }
        //thai.caodu textbox text change
        private void RechargeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //thai.caodu textbox key up
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
    }
}
