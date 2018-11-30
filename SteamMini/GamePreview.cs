using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SteamDAL.DAO;
using SteamMini.Class;

namespace SteamMini
{
    public partial class GamePreview : UserControl
    {
        Color defColor;
        public GameObject gameO;
        public void SetGameObject(GameObject input)
        {
            gameO = input;

        }
        public GameObject GetGameObject()
        {
            return gameO;
        }
        [Description("Text display the Game's name"), Category("Appearance")]
        public string GameNameText
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }
        [Description("The font of the Game's name text"), Category("Appearance")]
        public Font GameNameFont
        {
            get { return lbName.Font; }
            set { lbName.Font = value; }
        }
        [Description("Game's name docking style"), Category("Appearance")]
        public DockStyle GameNameDockStyle
        {
            get { return lbName.Dock; }
            set { lbName.Dock = value; }
        }

        [Description("Text display the Game's price"), Category("Appearance")]
        public string GamePriceText
        {
            get { return lbPrice.Text; }
            set { lbPrice.Text = value; }
        }
        [Description("The font of the Game's name text"), Category("Appearance")]
        public Font GamePriceFont
        {
            get { return lbPrice.Font; }
            set { lbPrice.Font = value; }
        }
        [Description("Game's name docking style"), Category("Appearance")]
        public DockStyle GamePriceDockStyle
        {
            get { return lbPrice.Dock; }
            set { lbPrice.Dock = value; }
        }
        [Description("The game's icon image"), Category("Appearance")]
        public Image GameIcon
        {
            get { return picBox.Image; }
            set { picBox.Image = value; }
        }
        [Description("Game's name docking style"), Category("Appearance")]
        public DockStyle GameIconDockStyle
        {
            get { return picBox.Dock; }
            set { picBox.Dock = value; }
        }
        [Description("Game's name docking style"), Category("Appearance")]
        public PictureBoxSizeMode GameIconSizeMode
        {
            get { return picBox.SizeMode; }
            set { picBox.SizeMode = value; }
        }

        public PictureBox GamePictureBox
        {
            get { return picBox; }
            set { picBox = value; }
        }

        public string Rating
        {
            get { return RatingText.Text; }
            set { RatingText.Text = value; }
        }

        public GamePreview()
        {
            InitializeComponent();
            defColor = this.BackColor;
        }

        private void GamePreview_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.RoyalBlue;
        }

        private void GamePreview_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = defColor;
        }
    }
}
