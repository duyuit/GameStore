using SteamMini.Class;
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
    public partial class MyHome : Form
    {
        private Register register = null;
        private string id = null;

        List<Image> background = new List<Image>();
        List<Label> recommend_select = new List<Label>();
        List<GameObject> lib_game = new List<GameObject>();

        public MyHome(string Id)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(42, 46, 51);
            menuStrip1.BackColor = Color.FromArgb(27, 32, 54);
            steamToolStripMenuItem.BackColor = Color.FromArgb(42, 46, 51);
            //viewToolStripMenuItem1.BackColor = Color.FromArgb(42, 46, 51);
            //gameToolStripMenuItem.BackColor = Color.FromArgb(42, 46, 51);
            //helpToolStripMenuItem.BackColor = Color.FromArgb(42, 46, 51);
          
            viewToolStripMenuItem1.ForeColor = Color.White;
            gameToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.ForeColor = Color.White;

            search_icon.Image = Properties.Resources.search_icon_white;
            txtSearch.BackColor = Color.FromArgb(42, 46, 51);
            listGame.BackColor = Color.FromArgb(42, 46, 51);

            game_name_panel.BackColor = Color.FromArgb(80, Color.Black);
            lbl_game_name.BackColor = Color.FromArgb(00, Color.Black);
            panel_play.BackColor = Color.FromArgb(100, Color.Black);
            panel4.BackColor = Color.FromArgb(100, Color.Black);
            listGame.SmallImageList = imageList1;
            main_achievement.Image = Properties.Resources._100;
            progressBar1.Value = 13;
            pictureBox1.Image = Properties.Resources.demo;


            
            
            //Listview Game Library Init
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

            //Store panel Init
            store_panel.BackColor = Color.FromArgb(21, 53, 77);
            txtSearch_store.BackColor = Color.FromArgb(21, 53, 77);
            btn_search_store.BackColor = Color.FromArgb(85, 159, 204);

            //Recommend Game Init
            panel3.BackColor = Color.FromArgb(21, 53, 77);
            recommend_picture1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("GTAV1");
            recommend_picture2.Image = Properties.Resources.GTAV2;
            recommend_picture3.Image = Properties.Resources.GTAV3;
            recommend_picture4.Image = Properties.Resources.GTAV4;
            recommend_picture5.Image = Properties.Resources.GTAV1;
            recommend_panel.BackColor = Color.FromArgb(7, 17, 26);
            recommend_select.Add(recommend_select1);
            recommend_select.Add(recommend_select2);
            recommend_select.Add(recommend_select3);
            recommend_select.Add(recommend_select4);
            recommend_select.Add(recommend_select5);

            this.id = Id;
        }
        private void MyHome_Load(object sender, EventArgs e)
        {
           var embed = "<html><head>"+
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>"+
            "</head><body>" +
            "<iframe width=\"1026\" height=\"250\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = "https://www.youtube.com/embed/3Q6U3BSbrlY";
               this.webBrowser1.DocumentText = string.Format(embed, url);


            lib_game.Add(new GameObject());
        }

        private void steamToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem a = (ToolStripMenuItem)sender;
            a.ForeColor = Color.Black;

        }



        private void steamToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem a = (ToolStripMenuItem)sender;
            a.ForeColor = Color.White;


        }



        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Label a = (Label)sender;
            a.Font = new Font("Microsoft Sans Serif", 27);

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {

            Label a = (Label)sender;
            a.Font = new Font("Microsoft Sans Serif", 24);
        }

        private void listGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGame.SelectedItems.Count > 0)
            {
                var item = listGame.SelectedItems[0];
                lbl_game_name.Text = item.Text;
                img_game.Image = imageList1.Images[item.ImageIndex];
                lib_panel.BackgroundImage = background[item.ImageIndex];
                item.Focused = false;
                //rest of your logic
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 170, 255);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 31, 151);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Profile a = new Profile();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            store_panel.Visible = true;
            lib_panel.Visible = false;
            panel2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            store_panel.Visible = false;
            lib_panel.Visible = true;
            panel2.Visible = true;
        }

        private void recommend_image_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;

        }
        private void Select_Recommend(int selected)
        {
            if(selected % 2==0)
            {
                recommend_picture1.Image = Properties.Resources.GTAV1;
                recommend_picture2.Image = Properties.Resources.GTAV2;
                recommend_picture3.Image = Properties.Resources.GTAV3;
                recommend_picture4.Image = Properties.Resources.GTAV4;
                recommend_picture5.Image = Properties.Resources.GTAV1;
                recommend_game_name.Text = "GTA V";
            }
            else
            {
                recommend_picture1.Image = Properties.Resources.csgo1;
                recommend_picture2.Image = Properties.Resources.csgo2;
                recommend_picture3.Image = Properties.Resources.csgo3;
                recommend_picture4.Image = Properties.Resources.csgo4;
                recommend_picture5.Image = Properties.Resources.csgo1;
                recommend_game_name.Text = "CSGO";
            }
        }

        private void recommend_select1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int last = 0;
            Label lb_temp = (Label)sender;
            foreach (Label lb in recommend_select)
            {
                lb.BackColor = Color.Black;
                if (lb_temp == lb)
                    last = i;
                i++;
            }
            Select_Recommend(last);
         
            lb_temp.BackColor = Color.Silver;
        }

        private void MyHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name == "Login")
                {
                    Application.OpenForms[index].Close();
                }
            }
        }

        private void steamToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.register = new Register(this.id);
            this.register.Show();
            //this.Enabled = false;
        }
    }
}
