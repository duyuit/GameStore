using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SteamMini.Class
{
    public class GameObject
    {
        public Guid Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public Guid PublisherId { get; set; }
        public float Rating { get; set; }
        public PictureBox Logo { get; set; }
        public string VideoUrl { get; set; }
        public string Content { get; set; }
        public DateTime PurchaseDate { get; set; }
        public List<String> GameImages { get; set; }
        public float Sale { get; set; }


        public GameObject()
        {
            PurchaseDate = DateTime.Now;
        }
        public GameObject(string name,int money,string content,string cate1,string cate2, string publisher)
        {
            PurchaseDate = DateTime.Now;
            Name = name;
            Price = money;
            Content = content;
            
        }
    }
}
