using GameStore.DTOs;
using GameStore.Model;
using SteamDAL.Model;
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
    public partial class PushGame : Form
    {
        Responses<PublisherDTOs> publisherResponse;
        List<PublisherDTOs> publisherDTOs;
        int publisherIndex = 0;
        EventHandler getPublisherCallBack;
        EventHandler pushGameCallBack;
        Guid gameID;
        public PushGame()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 46, 51);
            PublisherControllerShould publisherController = new PublisherControllerShould();
            getPublisherCallBack += _getPublisherCallBack;
            publisherResponse = publisherController.GetAllPublishersController(getPublisherCallBack);
            comboBox1.Text = "Choose Publisher";
         
       
        }

        private void _getPublisherCallBack(object sender, EventArgs e)
        {
            PublisherEventArgs argTemp =(PublisherEventArgs) e;
            publisherDTOs = argTemp.respone.Payload;
            foreach (PublisherDTOs a in publisherDTOs)
            {
                comboBox1.Items.Add(a.Name);
            }
        }
        private void _pushGameCallBack(object sender, EventArgs e)
        {
            GameEventArgs gameEventArgs = (GameEventArgs)e;
            ImageToPushGame image1 = new ImageToPushGame(gameEventArgs.gameID,txtLink1.Text,"");
            ImageToPushGame image2 = new ImageToPushGame(gameEventArgs.gameID, txtLink2.Text, "");
            ImageToPushGame image3 = new ImageToPushGame(gameEventArgs.gameID, txtLink3.Text, "");
            ImageToPushGame image4 = new ImageToPushGame(gameEventArgs.gameID, txtLink4.Text, "");

            ImageGameController imageGameController = new ImageGameController();
            imageGameController.PostImage(image1);
            imageGameController.PostImage(image2);
            imageGameController.PostImage(image3);
            imageGameController.PostImage(image4);

          
        }
        private void PushGame_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          
            if(txtName.Text!="" &&
                txtContent.Text != "" &&
                txtLink1.Text != "" && 
                txtLink2.Text != "" &&
               txtLink3.Text != "" && 
               txtLink4.Text != "" &&
                txtPrice.Text != "" )
            {
                pushGameCallBack += _pushGameCallBack;
                GameControllerShould gameControllerShould = new GameControllerShould();
                gameControllerShould.PostNewGameController(txtName.Text,
                 publisherDTOs[publisherIndex].Id.ToString(), "", "", "", "", 2,"", "", txtContent.Text, "128bbdf2-5038-498b-a32e-31ace3068cfe", "128bbdf2-5038-498b-a32e-31ace3068cfe", int.Parse(txtPrice.Text), pushGameCallBack);
            }
            else
            {
                MessageBox.Show("Information is not enough!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            publisherIndex = comboBox1.SelectedIndex;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            List<string> listImage = new List<string>();
            listImage.Add(txtLink1.Text);
            listImage.Add(txtLink2.Text);
            listImage.Add(txtLink3.Text);
            listImage.Add(txtLink4.Text);

            GameDTOs gameDTO = new GameDTOs();
            gameDTO.Name = txtName.Text;
            gameDTO.Price = txtPrice.Text;
            gameDTO.Content = txtContent.Text;
            string Pub = comboBox1.Text;
            PushPreview a = new PushPreview(gameDTO, listImage, Pub);
            a.Show();
            
        }
    }
}
