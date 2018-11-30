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
        private static string id = "";
        private static float currmoney = 0;

        public static void SetUser(GameStore.DTOs.PayloadBody input, string Id)
        {
            user = input;
            id = Id;
            currmoney = user.Money;
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

            SoDuText.Text = "Money: $" + Math.Round(user.Money, 2);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            UserName.Text = user.UserName;
            //avatar.Load(user.ImageUser.UrlOnline);
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

                    MessageBox.Show($"Recharge success!\nYour account has ${SoDuText.Text}!", "Success");
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
