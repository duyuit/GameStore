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
        UserDTOs user = null;

        public void SetUser(UserDTOs input)
        {
            user = input;
        }
        public Profile()
        {
            InitializeComponent();
            panel1.BackColor=Color.FromArgb(42, 46, 51);
            avatar.Image = Properties.Resources.gta5;
            listGame.BackColor = Color.FromArgb(42, 46, 51);

            listGame.SmallImageList = imageList1;
            listGame.Items.Add(new ListViewItem("  GTA V", 0));
            imageList1.Images.Add(Properties.Resources.gta5);
            background.Add(Properties.Resources.gta5_background);


            listGame.Items.Add(new ListViewItem("  CS:GO", 1));
            imageList1.Images.Add(Properties.Resources.csgo_icon);
            background.Add(Properties.Resources.csgo_background);

            listGame.Items.Add(new ListViewItem("  PAYDAY 2", 2));
            imageList1.Images.Add(Properties.Resources.payday2_icon);
            background.Add(Properties.Resources.pd2_background);

            listGame.Items.Add(new ListViewItem("  PUBG", 3));
            imageList1.Images.Add(Properties.Resources.pubg_icon);
            background.Add(Properties.Resources.pubg_background);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            UserName.Text = user.UserName;
            //avatar.Load(user.ImageUser.UrlOnline);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
