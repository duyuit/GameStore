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
    public partial class MyHome : Form
    {
        private Register register = null;
        private string id = null;

        List<Image> background = new List<Image>();
        List<Label> recommend_select = new List<Label>();
        List<GameObject> lib_game = new List<GameObject>();
        List<GameObject> user_game = new List<GameObject>();
        Responses<GameDTOs> GameResponse;
        GameStore.DTOs.PayloadBody User;
        GameObject currGame;
        int currRecommend = 0;


        //3 event nay se hien thi chi tiet game khi nguoi choi nhan vao cac phan tu tuong ung' cua gamepreview
        //do object la khac nhau, nen phai co 3 event xu ly khac nhau, tranh loi
        public void GamePreviewClick(object sender, EventArgs e)
        {
            this.store_panel.Visible = false;
            this.GameDetailPanel.Visible = true;

            GamePreview gPre = (GamePreview)sender;
            currGame = gPre.GetGameObject();
            LoadGamePanel(currGame);

        }

        public void GamePreviewPicClick(object sender, EventArgs e)
        {
            this.store_panel.Visible = false;
            this.GameDetailPanel.Visible = true;

            PictureBox picbox = (PictureBox)sender;
            GamePreview gPre = (GamePreview)picbox.Parent;
            currGame = gPre.GetGameObject();
            LoadGamePanel(currGame);

        }

        public void GamePreviewDescriptonClick(object sender, EventArgs e)
        {
            this.store_panel.Visible = false;
            this.GameDetailPanel.Visible = true;

            RichTextBox picbox = (RichTextBox)sender;
            GamePreview gPre = (GamePreview)picbox.Parent;
            currGame = gPre.GetGameObject();
            LoadGamePanel(currGame);

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
                temp1.GameImages.Add(a.ImageGames.ElementAt(0).UrlOnline);
            }
            return temp1;
        }

        public void LoadDatabase(string UserId)
        {
            GameControllerShould gameControl = new GameControllerShould();
            GameResponse = gameControl.GetAllGamesController();
            User = AccountsControllerShould.GetUserByIdController(UserId);

            List<GameDTOs> gameDTOs = GameResponse.Payload;
            foreach (GameDTOs a in gameDTOs)
            {
                GameObject temp1 = toGameObject(a);
                lib_game.Add(temp1);
            }

            foreach (TitleGame a in User.Games)
            {
                GameControllerShould gameControl2 = new GameControllerShould();
                Response<GameDTOs> temp = gameControl2.GetGameByIdController(a.Id.ToString());
                GameObject gameobj = toGameObject(temp.Payload);
                user_game.Add(gameobj);
            }
        }

        public void LoadGamePanel(GameObject gameobject)
        {
            this.GameIcon.Image = gameobject.Logo.Image;
            this.GameNameLabel.Text = gameobject.Name;
            this.GameDescription.Text = gameobject.Content;
            this.RatingText.Text = gameobject.Rating.ToString();
            if (gameobject.Price == 0)
                this.Price.Text = "FREE";
            else
                this.Price.Text = "Price: " + gameobject.Price.ToString() + " VND";
            this.GameImages.Load(gameobject.GameImages.ElementAt(0));
            this.GameImages2.Load(gameobject.GameImages.ElementAt(1));

            var embed = "<html><head>" +
 "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
 "</head><body>" +
 "<iframe width=\"1026\" height=\"250\" src=\"{0}\"" +
 "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
 "</body></html>";
            var url = "https://www.youtube.com/embed/3Q6U3BSbrlY";
            this.GameVid.DocumentText = string.Format(embed, url);
        }

        public void LoadGamePreview()
        {
            int i = 0;
            int lastY = 0;
            foreach (GameObject gO in lib_game)
            {
                GamePreview temp = new GamePreview();
                temp.SetGameObject(gO);
                temp.GameIcon = gO.Logo.Image;
                temp.GameNameText = gO.Name;
                temp.Rating = gO.Rating.ToString();
                temp.GameDescription.Text = gO.Content;
                temp.Click += GamePreviewClick;
                temp.GamePictureBox.Click += GamePreviewPicClick; //thai.caodu them event khi click cho picture cua game se thuc hien thao tac tuong tu nhu khi click vao control
                temp.GameDescription.Click += GamePreviewDescriptonClick;
                if (gO.Price == 0)
                {
                    temp.GamePriceText = "Free";
                }
                else
                    temp.GamePriceText = gO.Price.ToString() + " VND";
                if (i == 0)
                {
                    temp.Location = new System.Drawing.Point(label32.Location.X + 10, label32.Location.Y + (i * temp.Height) + 40);
                    lastY = temp.Location.Y;
                }
                else
                {
                    temp.Location = new System.Drawing.Point(label32.Location.X + 10, lastY + temp.Height + 10);
                    lastY = temp.Location.Y;
                }
                i++;
                store_panel.Controls.Add(temp);
            }
        }
        public MyHome(string Id)
        {
            InitializeComponent();
            LoadDatabase(Id);
            this.id = Id;
            LoadGamePreview();

            //myhome binh thuong a ui
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
            this.showListGame();

            //Store panel Init
            store_panel.BackColor = Color.FromArgb(21, 53, 77);
            txtSearch_store.BackColor = Color.FromArgb(21, 53, 77);
            btn_search_store.BackColor = Color.FromArgb(85, 159, 204);

            //Recommend Game Init
            panel3.BackColor = Color.FromArgb(21, 53, 77);
            recommend_picture1.Load(lib_game.ElementAt(0).GameImages.ElementAt(0));
            recommend_picture2.Load(lib_game.ElementAt(1).GameImages.ElementAt(0));
            recommend_picture3.Load(lib_game.ElementAt(2).GameImages.ElementAt(0));
            recommend_picture4.Load(lib_game.ElementAt(3).GameImages.ElementAt(0));
            recommend_picture5.Load(lib_game.ElementAt(0).GameImages.ElementAt(0));
            label17.Text = lib_game.ElementAt(0).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(0).Name;

        }

        private void showListGame()
        {
            listGame.Clear();
            imageList1.Images.Clear();
            foreach (GameObject a in user_game)
            {
                ListViewItem item = new ListViewItem();
                item.Name = a.Id.ToString();
                item.Text = a.Name;

                //add logo cho itemlistview
                System.Net.WebRequest request = System.Net.WebRequest.Create(a.Logo.ImageLocation);
                System.Net.WebResponse resp = request.GetResponse();
                System.IO.Stream respStream = resp.GetResponseStream();
                Bitmap bmp = new Bitmap(respStream);
                respStream.Dispose();

                imageList1.Images.Add("Icon" + a.Name, bmp);
                item.ImageKey = "Icon" + a.Name;

                listGame.Items.Add(item);

                //add background
            }
        }

        private void MyHome_Load(object sender, EventArgs e)
        {
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
                GameObject selectedgame = null;
                foreach (GameObject a in user_game)
                {
                    if (a.Id.ToString() == item.Name)
                    {
                        selectedgame = a;
                    }
                }
                lbl_game_name.Text = item.Text;
                img_game.Image = selectedgame.Logo.Image;

                System.Net.WebRequest request1 = System.Net.WebRequest.Create(selectedgame.GameImages.ElementAt(1));
                System.Net.WebResponse resp1 = request1.GetResponse();
                System.IO.Stream respStream1 = resp1.GetResponseStream();
                Bitmap bmp1 = new Bitmap(respStream1);
                respStream1.Dispose();

                lib_panel.BackgroundImage = bmp1;
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
            a.SetUser(User);
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

        private void Purchase_Click(object sender, EventArgs e)
        {
            var response = AccountsControllerShould.UserBuyGameController(new BuyGameObject(this.currGame.Id.ToString()), this.id);

            if (response == "iduserwrong")
            {
                MessageBox.Show("User Id is wrong!", "Error");
            }
            else if (response == "notenoughmoney")
            {
                MessageBox.Show("Your account don't enought money to buy this game!\n" 
                    + "You have to recharge!", "Error");
            }
            else if (response == "youhavepurchase")
            {
                MessageBox.Show("This game already exists in your game library!\n" +
                    "You should buy another game!", "Error");
            }
            else
            {
                MessageBox.Show("Buy game success!\nThe game was moved to the library!", "Success");
                User.Money -= currGame.Price;

                //add and re-show listgame in lib
                user_game.Add(this.currGame);
                this.showListGame();

                //tiền đã đc api auto chuyển cho publisher

                //trở về store mua tiếp
                this.GameDetailPanel.Visible = false;
                this.store_panel.Visible = true;
                currGame = null;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.GameDetailPanel.Visible = false;
            this.store_panel.Visible = true;
            currGame = null;
        }

        private void GameImages_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currGame.GameImages.Count(); i++)
            {
                if (GameImages.ImageLocation == currGame.GameImages.ElementAt(i))
                {
                    if (i == currGame.GameImages.Count() - 1)
                    {
                        GameImages.Load(currGame.GameImages.ElementAt(0));
                        break;
                    }
                    else
                    {
                        GameImages.Load(currGame.GameImages.ElementAt(i + 1));
                        break;
                    }
                }
            }
        }

        private void GameImages2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currGame.GameImages.Count(); i++)
            {
                if (GameImages2.ImageLocation == currGame.GameImages.ElementAt(i))
                {
                    if (i == currGame.GameImages.Count() - 1)
                    {
                        GameImages2.Load(currGame.GameImages.ElementAt(0));
                        break;
                    }
                    else
                    {
                        GameImages2.Load(currGame.GameImages.ElementAt(i + 1));
                        break;
                    }
                }
            }
        }

        private void recommend_picture1_Click(object sender, EventArgs e)
        {
            this.store_panel.Visible = false;
            this.GameDetailPanel.Visible = true;
            currGame = lib_game.ElementAt(0);
            LoadGamePanel(currGame);
        }

        private void recommend_picture5_Click(object sender, EventArgs e)
        {
            this.store_panel.Visible = false;
            this.GameDetailPanel.Visible = true;
            currGame = lib_game.ElementAt(0);
            LoadGamePanel(currGame);
        }

        private void recommend_picture2_Click(object sender, EventArgs e)
        {
            this.store_panel.Visible = false;
            this.GameDetailPanel.Visible = true;
            currGame = lib_game.ElementAt(1);
            LoadGamePanel(currGame);
        }

        private void recommend_picture3_Click(object sender, EventArgs e)
        {
            this.store_panel.Visible = false;
            this.GameDetailPanel.Visible = true;
            currGame = lib_game.ElementAt(2);
            LoadGamePanel(currGame);
        }

        private void recommend_picture4_Click(object sender, EventArgs e)
        {
            this.store_panel.Visible = false;
            this.GameDetailPanel.Visible = true;
            currGame = lib_game.ElementAt(3);
            LoadGamePanel(currGame);
        }

        private void recommend_select1_Click(object sender, EventArgs e)
        {
            recommend_select1.BackColor = Color.Silver;
            recommend_select2.BackColor = Color.Black;
            recommend_select3.BackColor = Color.Black;
            recommend_select4.BackColor = Color.Black;
            recommend_select5.BackColor = Color.Black;
            recommend_picture1.Image = recommend_picture5.Image;
            label17.Text = lib_game.ElementAt(0).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(0).Name;
            currRecommend = 0;
        }

        private void recommend_select2_Click(object sender, EventArgs e)
        {
            recommend_select1.BackColor = Color.Black;
            recommend_select2.BackColor = Color.Silver;
            recommend_select3.BackColor = Color.Black;
            recommend_select4.BackColor = Color.Black;
            recommend_select5.BackColor = Color.Black;
            recommend_picture1.Image = recommend_picture2.Image;
            label17.Text = lib_game.ElementAt(1).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(1).Name;
            currRecommend = 1;
        }

        private void recommend_select3_Click(object sender, EventArgs e)
        {
            recommend_select1.BackColor = Color.Black;
            recommend_select2.BackColor = Color.Black;
            recommend_select3.BackColor = Color.Silver;
            recommend_select4.BackColor = Color.Black;
            recommend_select5.BackColor = Color.Black;
            recommend_picture1.Image = recommend_picture3.Image;
            label17.Text = lib_game.ElementAt(2).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(2).Name;
            currRecommend = 2;
        }

        private void recommend_select4_Click(object sender, EventArgs e)
        {
            recommend_select1.BackColor = Color.Black;
            recommend_select2.BackColor = Color.Black;
            recommend_select3.BackColor = Color.Black;
            recommend_select4.BackColor = Color.Silver;
            recommend_select5.BackColor = Color.Black;
            recommend_picture1.Image = recommend_picture4.Image;
            label17.Text = lib_game.ElementAt(3).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(3).Name;
            currRecommend = 3;
        }

        private void recommend_select5_Click(object sender, EventArgs e)
        {
            recommend_select1.BackColor = Color.Black;
            recommend_select2.BackColor = Color.Black;
            recommend_select3.BackColor = Color.Black;
            recommend_select4.BackColor = Color.Black;
            recommend_select5.BackColor = Color.Silver;
            recommend_picture1.Image = recommend_picture5.Image;
            label17.Text = lib_game.ElementAt(0).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(0).Name;
            currRecommend = 0;
        }

        private void recommend_image_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;
            label17.Text = lib_game.ElementAt(currRecommend).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(currRecommend).Name;
        }

        private void recommend_image5_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;
            currRecommend = 0;
            label17.Text = lib_game.ElementAt(currRecommend).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(currRecommend).Name;
        }

        private void recommend_image2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;
            currRecommend = 1;
            label17.Text = lib_game.ElementAt(currRecommend).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(currRecommend).Name;
        }

        private void recommend_image3_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;
            currRecommend = 2;
            label17.Text = lib_game.ElementAt(currRecommend).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(currRecommend).Name;
        }

        private void recommend_image4_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;
            currRecommend = 3;
            label17.Text = lib_game.ElementAt(currRecommend).Price.ToString() + " VND";
            recommend_game_name.Text = lib_game.ElementAt(currRecommend).Name;
        }

        private void testNapTienUser()
        {
            //nhớ validate chỉ nhập đc số thập phân.
            // kiểm tra nếu tiền < 0 thì báo lỗi
            //tiền nhập vào + tiền có sẵn của user => đưa xuống update tiền, api ko cộng dồn đc.

            float money = 100.5F; // tiền nhập vào từ txtMoney.Text
            var response = AccountsControllerShould.UpdateMoneyAccountController(new RechargeObject(money + User.Money), this.id);

            if (response.IsSuccess.ToString() == "False")
            {
                MessageBox.Show("Recharge failed!\nUser Id is wrong!", "Error");
            }
            else
            {
                MessageBox.Show($"Recharge success!\nYour account has ${response.Payload.Money}!", "Success");
            }
        }
        //thai.caodu logoutevent khi click
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }
        //thai.caodu changeaccount event khi click
        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //thai.caodu exit event khi click
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
