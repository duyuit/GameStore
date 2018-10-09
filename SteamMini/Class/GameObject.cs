using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamMini.Class
{
    class GameObject
    {
        public Guid Id { get; set; }
        public int Money { get; set; }
        public string Name { get; set; }
        public Guid PublisherId { get; set; }
        public float Rating { get; set; }
        public string Logo { get; set; }
        public string VideoUrl { get; set; }
        public string Content { get; set; }
        public DateTime PurchaseDate { get; set; }


        public GameObject()
        {
            PurchaseDate = DateTime.Now;
        }
        public GameObject(string name,int money,string content,string cate1,string cate2, string publisher)
        {
            PurchaseDate = DateTime.Now;
            Name = name;
            Money = money;
            Content = content;
            
        }
    }
}
