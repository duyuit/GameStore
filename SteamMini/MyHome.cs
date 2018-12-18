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
        private string currPass = "";

        List<Image> background = new List<Image>();
        List<Label> recommend_select = new List<Label>();
        public List<GameObject> lib_game = new List<GameObject>();
        public List<GameObject> user_game = new List<GameObject>();
        public List<GameObject> sale_game = new List<GameObject>();
        Responses<GameDTOs> GameResponse;
        GetAllGameSaleResponse GameSaleResponse;
        GameStore.DTOs.PayloadBody User;
        GameObject currGame;
        int currRecommend = 0;



        public void setLibpanelVisible(bool val)
        {
            this.lib_panel.Visible = val;
            
        }

        public void setStorepanelVisible(bool val)
        {
            this.store_panel.Visible = val;
        }

        public void setGameDetailpanelVisible(bool val)
        {
            this.GameDetailPanel.Visible = val;
        }
        //3 event nay se hien thi chi tiet game khi nguoi choi nhan vao cac phan tu tuong ung' cua gamepreview
        //do object la khac nhau, nen phai co 3 event xu ly khac nhau, tranh loi
        public void GamePreviewClick(object sender, EventArgs e)
        {
            setStorepanelVisible(false);
            setGameDetailpanelVisible(true);

            GamePreview gPre = (GamePreview)sender;
            currGame = gPre.GetGameObject();
            LoadGamePanel(currGame);

        }

        public void GamePreviewPicClick(object sender, EventArgs e)
        {
            setStorepanelVisible(false);
            setGameDetailpanelVisible(true);

            PictureBox picbox = (PictureBox)sender;
            GamePreview gPre = (GamePreview)picbox.Parent;
            currGame = gPre.GetGameObject();
            LoadGamePanel(currGame);

        }

        public void GamePreviewDescriptonClick(object sender, EventArgs e)
        {
            setStorepanelVisible(false);
            setGameDetailpanelVisible(true);

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
            temp1.Sale = a.Sale;
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

        public void LoadDatabase(string UserId)
        {
            GameResponse = GameControllerShould.GetAllGamesController();
            User = AccountsControllerShould.GetUserByIdController(UserId);
            GameSaleResponse = GameControllerShould.GetAllGamesSaleController();


            List<GameDTOs> gameDTOs = GameResponse.Payload;
            foreach (GameDTOs a in gameDTOs)
            {
                GameObject temp1 = toGameObject(a);
                lib_game.Add(temp1);
            }

            foreach (TitleGame a in User.Games)
            {
                Response<GameDTOs> temp = GameControllerShould.GetGameByIdController(a.Id.ToString());
                GameObject gameobj = toGameObject(temp.Payload);
                user_game.Add(gameobj);
            }

            foreach (GameDTOs a in GameSaleResponse.Payload)
            {
                GameObject gameobj = toGameObject(a);
                sale_game.Add(gameobj);
            }
            if (sale_game.Count() < 4)
            {
                for (int i = 0; i < 4; i ++)
                {
                    sale_game.Add(lib_game.ElementAt(i));
                }
            }
        }

        public void LoadGamePanel(GameObject gameobject)
        {
            this.GameIcon.Image = gameobject.Logo.Image;
            this.GameNameLabel.Text = gameobject.Name;
            this.GameDescription.Text = gameobject.Content;
            this.ReleaseDate.Text = "Release Date: " + gameobject.PurchaseDate;
            this.Publisher.Text = "Publisher: " + PublisherControllerShould.GetPublisherByIdController(gameobject.PublisherId.ToString()).Payload.Name;
            this.Rating.Text = "Rating: " + gameobject.Rating.ToString();
            if (gameobject.Price == 0)
                this.PriceLabel.Text = "FREE";
            else
                this.PriceLabel.Text = "Price: " + gameobject.Price.ToString() + " VND";
            try
            {
                this.GameDetailPicBox1.Image = GetImagebyURI(gameobject.GameImages.ElementAt(0));
                this.GameDetailPicBox2.Image = GetImagebyURI(gameobject.GameImages.ElementAt(1));
                this.GameDetailPicBox3.Image = GetImagebyURI(gameobject.GameImages.ElementAt(2));
                this.GameDetailPicBox4.Image = GetImagebyURI(gameobject.GameImages.ElementAt(3));
                this.GameDetailPicBox5.Image = GetImagebyURI(gameobject.GameImages.ElementAt(0));
                this.GameDetailPicBox6.Image = GetImagebyURI(gameobject.GameImages.ElementAt(1));
            }
            catch (Exception e)
            {
                this.GameDetailPicBox1.Image = GetImagebyURI(gameobject.GameImages.ElementAt(0));
                this.GameDetailPicBox2.Image = GetImagebyURI(gameobject.GameImages.ElementAt(0));
                this.GameDetailPicBox3.Image = GetImagebyURI(gameobject.GameImages.ElementAt(0));
                this.GameDetailPicBox4.Image = GetImagebyURI(gameobject.GameImages.ElementAt(0));
                this.GameDetailPicBox5.Image = GetImagebyURI(gameobject.GameImages.ElementAt(0));
                this.GameDetailPicBox6.Image = GetImagebyURI(gameobject.GameImages.ElementAt(0));
            }

            var embed = "<html><head>" +
 "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
 "</head><body>" +
 "<iframe width=\"1026\" height=\"250\" src=\"{0}\"" +
 "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
 "</body></html>";
            var url = "https://www.youtube.com/embed/3Q6U3BSbrlY";
            this.GameVid.DocumentText = string.Format(embed, url);

            //xu ly neu game co sale:
            if (gameobject.Sale != 0)
            {
                this.PriceLabel.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Strikeout);
                this.saledPriceLabel.Visible = true;
                float saledprice = gameobject.Price - (gameobject.Price * gameobject.Sale / (float)100);
                if (saledprice < 0)
                    saledprice = 0;
                if (saledprice == 0)
                    this.saledPriceLabel.Text = "FREE";
                else
                    this.saledPriceLabel.Text = "Price: " + saledprice.ToString() + " VND";
            }
            else
            {
                this.PriceLabel.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                this.saledPriceLabel.Visible = false;
            }

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
        public MyHome(string Id, string pass)
        {
            InitializeComponent();
            LoadDatabase(Id);
            this.id = Id;
            this.currPass = pass;
            LoadGamePreview();

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
            recommend_picture1.Load(sale_game.ElementAt(0).GameImages.ElementAt(0));
            recommend_picture2.Load(sale_game.ElementAt(1).GameImages.ElementAt(0));
            recommend_picture3.Load(sale_game.ElementAt(2).GameImages.ElementAt(0));
            recommend_picture4.Load(sale_game.ElementAt(3).GameImages.ElementAt(0));
            recommend_picture5.Load(sale_game.ElementAt(0).GameImages.ElementAt(0));
            oldPrice.Text = sale_game.ElementAt(0).Price.ToString() + " VND";
            saleLabel.Text = "On Sale: " + sale_game.ElementAt(0).Sale.ToString() + "%";
            recommend_game_name.Text = sale_game.ElementAt(0).Name;

        }

        public void showListGame()
        {
            listGame.Clear();
            imageList1.Images.Clear();
            if (user_game == null)
                this.panel2.Visible = false;
            else
                this.panel2.Visible = true;
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

        public Bitmap GetImagebyURI(string Uri)
        {
            System.Net.WebRequest request1 = System.Net.WebRequest.Create(Uri);
            System.Net.WebResponse resp1 = request1.GetResponse();
            System.IO.Stream respStream1 = resp1.GetResponseStream();
            Bitmap bmp1 = new Bitmap(respStream1);
            respStream1.Dispose();

            return bmp1;
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

                lib_panel.BackgroundImage = GetImagebyURI(selectedgame.GameImages.ElementAt(1));
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
            Profile.SetUser(User, id);

            Profile a = new Profile(User, this);
            a.Show();
            this.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            setStorepanelVisible(true);
            setLibpanelVisible(false);
            panel2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            setStorepanelVisible(false);
            setLibpanelVisible(true);
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

        private void GameImages_Click(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            this.GameDetailPicBox1.Visible = true;
            this.GameVid.Visible = false;
            this.GameVid.Stop();
            this.GameDetailPicBox1.Image = temp.Image;
        }


        private void recommend_picture1_Click(object sender, EventArgs e)
        {
            setStorepanelVisible(false);
            setGameDetailpanelVisible(true);
            currGame = sale_game.ElementAt(0);
            LoadGamePanel(currGame);
        }

        private void recommend_picture5_Click(object sender, EventArgs e)
        {
            setStorepanelVisible(false);
            setGameDetailpanelVisible(true);
            currGame = sale_game.ElementAt(0);
            LoadGamePanel(currGame);
        }

        private void recommend_picture2_Click(object sender, EventArgs e)
        {
            setStorepanelVisible(false);
            setGameDetailpanelVisible(true);
            currGame = sale_game.ElementAt(1);
            LoadGamePanel(currGame);
        }

        private void recommend_picture3_Click(object sender, EventArgs e)
        {
            setStorepanelVisible(false);
            setGameDetailpanelVisible(true);
            currGame = sale_game.ElementAt(2);
            LoadGamePanel(currGame);
        }

        private void recommend_picture4_Click(object sender, EventArgs e)
        {
            setStorepanelVisible(false);
            setGameDetailpanelVisible(true);
            currGame = sale_game.ElementAt(3);
            LoadGamePanel(currGame);
        }

        private void recommend_select1_Click(object sender, EventArgs e)
        {
            recommend_select1.BackColor = Color.Silver;
            recommend_select2.BackColor = Color.Black;
            recommend_select3.BackColor = Color.Black;
            recommend_select4.BackColor = Color.Black;
            recommend_picture1.Image = recommend_picture5.Image;
            recommend_game_name.Text = lib_game.ElementAt(0).Name;
            oldPrice.Text = sale_game.ElementAt(0).Price.ToString() + " VND";
            float salepriceint = sale_game.ElementAt(0).Price - (sale_game.ElementAt(0).Price * sale_game.ElementAt(0).Sale/ (float)100);
            if (salepriceint < 0)
                salepriceint = 0;
            salePrice.Text = salepriceint.ToString() + " VND";
            saleLabel.Text = "On Sale: " + sale_game.ElementAt(0).Sale.ToString() + "%";
            currRecommend = 0;
        }

        private void recommend_select2_Click(object sender, EventArgs e)
        {
            recommend_select1.BackColor = Color.Black;
            recommend_select2.BackColor = Color.Silver;
            recommend_select3.BackColor = Color.Black;
            recommend_select4.BackColor = Color.Black;
            recommend_picture1.Image = recommend_picture2.Image;
            oldPrice.Text = sale_game.ElementAt(1).Price.ToString() + " VND";
            float salepriceint = sale_game.ElementAt(1).Price - (sale_game.ElementAt(1).Price * sale_game.ElementAt(1).Sale / (float)100);
            if (salepriceint < 0)
                salepriceint = 0;
            salePrice.Text = salepriceint.ToString() + " VND";
            saleLabel.Text = "On Sale: " + sale_game.ElementAt(1).Sale.ToString() + "%";
            currRecommend = 1;
        }

        private void recommend_select3_Click(object sender, EventArgs e)
        {
            recommend_select1.BackColor = Color.Black;
            recommend_select2.BackColor = Color.Black;
            recommend_select3.BackColor = Color.Silver;
            recommend_select4.BackColor = Color.Black;
            recommend_picture1.Image = recommend_picture3.Image;
            oldPrice.Text = sale_game.ElementAt(2).Price.ToString() + " VND";
            float salepriceint = sale_game.ElementAt(2).Price - (sale_game.ElementAt(2).Price * sale_game.ElementAt(2).Sale / (float)100);
            if (salepriceint < 0)
                salepriceint = 0;
            salePrice.Text = salepriceint.ToString() + " VND";
            saleLabel.Text = "On Sale: " + sale_game.ElementAt(2).Sale.ToString() + "%";
            currRecommend = 2;
        }

        private void recommend_select4_Click(object sender, EventArgs e)
        {
            recommend_select1.BackColor = Color.Black;
            recommend_select2.BackColor = Color.Black;
            recommend_select3.BackColor = Color.Black;
            recommend_select4.BackColor = Color.Silver;
            recommend_picture1.Image = recommend_picture4.Image;
            oldPrice.Text = sale_game.ElementAt(3).Price.ToString() + " VND";
            float salepriceint = sale_game.ElementAt(3).Price - (sale_game.ElementAt(3).Price * sale_game.ElementAt(3).Sale / (float)100);
            if (salepriceint < 0)
                salepriceint = 0;
            salePrice.Text = salepriceint.ToString() + " VND";
            saleLabel.Text = "On Sale: " + sale_game.ElementAt(3).Sale.ToString() + "%";
            currRecommend = 3;
        }

        private void recommend_image_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;
            oldPrice.Text = sale_game.ElementAt(currRecommend).Price.ToString() + " VND";
            recommend_game_name.Text = sale_game.ElementAt(currRecommend).Name;
        }

        private void recommend_image5_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;
            currRecommend = 0;
            oldPrice.Text = sale_game.ElementAt(currRecommend).Price.ToString() + " VND";
            saleLabel.Text = "On Sale: " + sale_game.ElementAt(currRecommend).Sale.ToString() + "%";
            recommend_game_name.Text = sale_game.ElementAt(currRecommend).Name;
        }

        private void recommend_image2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;
            currRecommend = 1;
            oldPrice.Text = sale_game.ElementAt(currRecommend).Price.ToString() + " VND";
            saleLabel.Text = "On Sale: " + sale_game.ElementAt(currRecommend).Sale.ToString() + "%";
            recommend_game_name.Text = sale_game.ElementAt(currRecommend).Name;
        }

        private void recommend_image3_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;
            currRecommend = 2;
            oldPrice.Text = sale_game.ElementAt(currRecommend).Price.ToString() + " VND";
            saleLabel.Text = "On Sale: " + sale_game.ElementAt(currRecommend).Sale.ToString() + "%";
            recommend_game_name.Text = sale_game.ElementAt(currRecommend).Name;
        }

        private void recommend_image4_MouseEnter(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            recommend_picture1.Image = a.Image;
            currRecommend = 3;
            oldPrice.Text = sale_game.ElementAt(currRecommend).Price.ToString() + " VND";
            saleLabel.Text = "On Sale: " + sale_game.ElementAt(currRecommend).Sale.ToString() + "%";
            recommend_game_name.Text = sale_game.ElementAt(currRecommend).Name;
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
            this.register = new Register(this.id, this);
            this.register.Show();
            this.Enabled = false;
        }
        //thai.caodu exit event khi click
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buy_Click(object sender, EventArgs e)
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
                setStorepanelVisible(true);
                setGameDetailpanelVisible(false);
                currGame = null;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            setStorepanelVisible(true);
            setGameDetailpanelVisible(false);
            currGame = null;
        }

        private void btn_AddWishList_Click(object sender, EventArgs e)
        {
            TitleGame wishgame = new TitleGame();
            Response<GameDTOs> temp = GameControllerShould.GetGameByIdController(currGame.Id.ToString());
            wishgame.Id = temp.Payload.Id;
            wishgame.ImageGames = temp.Payload.ImageGames;
            wishgame.Name = temp.Payload.Name;
            wishgame.ReleaseDate = temp.Payload.PurchaseDate;
            User.WishGames.Add(wishgame);

            User.Password = currPass;

            var response = AccountsControllerShould.UpdateAccountController(User, this.id);

            var rs = response.IsSuccess.ToString();
            var mess = response.Message;

            if (rs == "False")
            {
                MessageBox.Show("Fail to add to wishlist", "Error");
            }
            else
            {
                MessageBox.Show("Wish list updated", "Success");
            }
        }

        private void GameDetailPicBox2_Click(object sender, EventArgs e)
        {
            this.GameDetailPicBox1.Visible = false;
            this.GameVid.Visible = true;
        }

        private void btnFreeCode_Click(object sender, EventArgs e)
        {
            Freecode a = new Freecode(id, this);
            a.Show();
            this.Enabled = false;
        }

        //show push game
        private void libToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PushGame a = new PushGame(this);
            a.Show();
            this.Enabled = false;
        }

        private void saleGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameSale a = new GameSale(this);
            a.Show();
            this.Enabled = false;
        }
    }
}
