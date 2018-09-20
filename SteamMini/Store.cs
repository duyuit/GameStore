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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(21, 53, 77);
            txtSearch.BackColor = Color.FromArgb(21, 53, 77);
            //    btn_search.Image = Properties.Resources.search_icon_white;
            btn_search.BackColor= Color.FromArgb(85, 159, 204);
            pictureBox1.Image = Properties.Resources.GTAV1;
            pictureBox2.Image = Properties.Resources.GTAV2;
            pictureBox3.Image = Properties.Resources.GTAV3;
            pictureBox4.Image = Properties.Resources.GTAV4;
            pictureBox5.Image = Properties.Resources.GTAV1;
            panel2.BackColor = Color.FromArgb(7, 17, 26);
        }

        private void Store_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            pictureBox1.Image = a.Image;

        }

      
    }
}
