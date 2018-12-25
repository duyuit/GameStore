using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamDAL.Model
{
    public class ImageToPushGame
    {
     
            public Guid GameId { get; set; }
            public string UrlOnline { get; set; }
            public string UrlLocal { get; set; }
            public ImageToPushGame(Guid gameID, string urlOn, string urlLocal)
            {
                GameId = gameID;
                UrlOnline = urlOn;
                UrlLocal = urlLocal;
                // Id = Guid.NewGuid();
            }
    }
}
