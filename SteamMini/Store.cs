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
    
    public partial class Store : Form
    {
        public static Responses<GameDTOs> Games;
        public Store()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(21, 53, 77);
           
            panel2.BackColor = Color.FromArgb(180,Color.Black);
            panel4.BackColor  = Color.FromArgb(80, Color.Black);
            // txt_addwishlist.BackColor = Color.FromArgb(30, 48, 62);
            // txt_addwishlist.ForeColor= Color.FromArgb(103,193,245);
        }

        private void Store_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            pictureBox1.Image = a.Image;

        }

        private void btn_buy_MouseEnter(object sender, EventArgs e)
        {
            btn_buy.BackColor = Color.FromArgb(50,205,50);
        }

        private void btn_buy_MouseLeave(object sender, EventArgs e)
        {
            btn_buy.BackColor = Color.FromArgb(0,100,0);
        }
    }
}
