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
    public partial class PushPreview : Form
    {
        List<string> listImage;
        public PushPreview(GameDTOs gameDTO, List<string> _listImage,string pub)
        {
            InitializeComponent();
            listImage = _listImage;
            LoadImage();
            GameDescription.Text = gameDTO.Content;
            Publisher.Text = Publisher.Text + gameDTO.Publisher;
            this.BackColor = Color.FromArgb(42, 46, 51);
            GameNameLabel.Text = gameDTO.Name;
            Publisher.Text = pub;
            GameDetailPanel.BackColor = Color.FromArgb(42, 46, 51);
            panel5.BackColor = Color.FromArgb(20, 46, 51);
            GameDescription.BackColor = Color.FromArgb(20, 46, 51);
            PriceLabel.Text = gameDTO.Price;
        }
        private void LoadImage()
        {
            try
            {
                this.GameDetailPicBox1.Load(listImage[0]);
            }
            catch (Exception e) { };
            try
            {
                this.GameDetailPicBox2.Load(listImage[0]);
            }
            catch (Exception e) { }; try
            {
                this.GameDetailPicBox3.Load(listImage[1]);
            }
            catch (Exception e) { }; try
            {
                this.GameDetailPicBox4.Load(listImage[2]);
            }
            catch (Exception e) { }; try
            {
                this.GameDetailPicBox5.Load(listImage[3]);
            }
            catch (Exception e) { }; 
           
        }

        private void PushPreview_Load(object sender, EventArgs e)
        {

        }

        private void GameDetailPicBox3_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            GameDetailPicBox1.Image = pic.Image;
        }
    }
}
