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
        MyHome myHome = null;
        public GameSale(MyHome input)
        {

            myHome = input;
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
            DateTime start = StartDate.Value;
            DateTime end = EndDate.Value;
            if (start.CompareTo(end) > 0)
            {
                MessageBox.Show("End date has to be later than Start date", "Error");
            }
            else
            {
                GameSaleRequest sale = new GameSaleRequest(Convert.ToInt32(txbPercent.Text), start, end);
                var response = GameControllerShould.PutGameSaleByGameIdController(sale, selectedgamed.Id.ToString());
                if (response.IsSuccess == "True")
                {
                    MessageBox.Show("GameSale has been published", "Succeeded" );
                }
                else
                {
                    MessageBox.Show("Sale request response was a failure", "Error");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myHome.Enabled = true;
            this.Close();
            myHome.Show();
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
            {
                float saledprice = selectedgamed.Price - (selectedgamed.Price * Convert.ToInt32(txbPercent.Text) / (float)100);
                if (saledprice < 0)
                    saledprice = 0;
                txbAfter.Text = saledprice.ToString() + " VND";
            }
                
            else
            {
                txbPercent.Text = "0";
                txbAfter.Text = selectedgamed.Price.ToString() + " VND";
            }
        }

    }
}
