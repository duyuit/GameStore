using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SteamDAL.DAO;

namespace SteamMini
{
    public partial class GamePreview : UserControl
    {
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
        public GamePreview()
        {
            InitializeComponent();
        }
    }
}
