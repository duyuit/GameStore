using SteamMini.Class;
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
    public partial class GameSale : Form
    {
        public List<GameObject> lib_game = new List<GameObject>();
        GameObject selectedgamed;
        public GameSale()
        {

            InitializeComponent();
            Responses<GameDTOs> GameResponse = GameControllerShould.GetAllGamesController();
            List<GameDTOs> gameDTOs = GameResponse.Payload;
            foreach (GameDTOs a in gameDTOs)
            {
                GameObject temp1 = toGameObject(a);
                lib_game.Add(temp1);
            }
            foreach (GameObject game in lib_game)
            {
                GameCollection.Items.Add(game.Name);
            }
            GameCollection.Text = "Choose a game to sale";

        }

        public GameObject toGameObject(GameDTOs a)
        {
            GameObject temp1 = new GameObject();
            temp1.Id = a.Id;
            temp1.Name = a.Name;
            temp1.Rating = a.Rating;
            temp1.Price = Convert.ToInt32(a.Price);
            temp1.PurchaseDate = Convert.ToDateTime(a.PurchaseDate);
            temp1.PublisherId = a.Publisher.Id;
            temp1.Content = a.Content;
            temp1.VideoUrl = a.VideoUrl;
            temp1.Logo = new PictureBox();
            temp1.Logo.Load(a.ImageGames.ElementAt(0).UrlOnline);
            for (int i = 0; i < a.ImageGames.Count(); i++)
            {
                if (temp1.GameImages == null)
                {
                    temp1.GameImages = new List<String>();
                }
                temp1.GameImages.Add(a.ImageGames.ElementAt(i).UrlOnline);
            }
            return temp1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int Secs = 0;
            if (Days.Value == 0 && Hours.Value == 0 && Mins.Value < 60)
            {
                MessageBox.Show("Error", "The time for sale is too low");
            }
            else
            {
                Secs = Convert.ToInt32(Days.Value) * 24 * 60 * 60 + Convert.ToInt32(Hours.Value) * 60 * 60 + Convert.ToInt32(Mins.Value) * 60;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lib_game.Count(); i++)
            {
                if (GameCollection.SelectedItem.ToString() == lib_game.ElementAt(i).Name)
                {
                    selectedgamed = lib_game.ElementAt(i);
                }
            }
            tbName.Text = selectedgamed.Name;
            tbPrice.Text = selectedgamed.Price.ToString() + " VND";
            txbPercent.Text = "";
            txbAfter.Text = "";
        }

        private void txbPercent_TextChanged(object sender, EventArgs e)
        {
            if (txbPercent.Text != "")
                txbAfter.Text = (selectedgamed.Price - (selectedgamed.Price * Convert.ToInt32(txbPercent.Text) / (float)100)) + " VND";
            else
            {
                txbPercent.Text = "0";
                txbAfter.Text = selectedgamed.Price.ToString() + " VND";
            }
        }

    }
}
