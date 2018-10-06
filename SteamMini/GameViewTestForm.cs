using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace SteamMini
{
    public partial class GameViewTestForm : Form
    {

        /// <summary>
        /// Hàm này nên được gọi khi chạy vòng lặp add GamePreview vào control. Nó sẽ set các giá trị mặc định
        /// như là Font, Kiểu hình Icon, v.v..... Các giá trị có thể edit cho GamePreview bao gồm các giá trị mặc định
        /// và DockStyle của GameNameText, GamePriceText, GameIcon + kiểu Font của GameNameText, GamePriceText
        /// Nếu cần thay đổi thêm bất cứ thuộc tính nào, add ở GamePreview.cs rồi sửa lại hàm SetDefaultFormat
        /// </summary>
        /// <param name="_input"> là GamePreview sẽ được điều chỉnh </param>
        public void SetDefaultFormat(GamePreview _input)
        {
            _input.GameIconSizeMode = PictureBoxSizeMode.CenterImage;
            _input.GameNameFont = new Font("Times New Roman", 24, FontStyle.Bold);
            _input.GamePriceFont = new Font("Times New Roman", 24, FontStyle.Bold);
        }

        //đây là list object tạo tạm thời để test, chỉ cần lưu 3 string
        //tên game, giá tiền và tên của Icon (trong Resources)
        public List<object[]> GameObjects = new List<object[]>();
        object[] game1 = new object[]
        {
            "Escape from tarkov", "1.350.000 VND", "EFTIcon"
        };
        object[] game2 = new object[]
        {
            "Defend of the Accient (DOTA)", "FREE TO PLAY", "DOTA2Icon"
        };


        public GameViewTestForm()
        {
            InitializeComponent();

            //add Object game vào list gameobject
            GameObjects.Add(game1);
            GameObjects.Add(game2);

            //position này sẽ giúp các GamePreview không bị chồng lên nhau
            Point position = new Point(0, 0);

            //vòng lặp add GamePreview
            foreach (object[] a in GameObjects)
            {
                GamePreview temp = new GamePreview();
                temp.GameNameText = a[0].ToString();
                temp.GamePriceText = a[1].ToString();

                //lấy object hình từ resource với tên là thuộc tính thứ 3 của game object, tên phải chính xác
                //và không có .png, .jpg.v.v...
                Object bmp = new Object();
                bmp = Properties.Resources.ResourceManager.GetObject(a[2].ToString());
                temp.GameIcon = (Bitmap)bmp;

                temp.Location = position;
                SetDefaultFormat(temp);
                this.Controls.Add(temp);
                position = new Point(0, temp.Height);
         
            }
        }
    }
}
