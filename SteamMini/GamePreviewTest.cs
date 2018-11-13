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
    public partial class GamePreviewTest : Form
    {
        public GamePreviewTest()
        {
            InitializeComponent();
            AccountsControllerShould temp = new AccountsControllerShould();
            temp.TestGetAllUsersController();
        }
    }
}
