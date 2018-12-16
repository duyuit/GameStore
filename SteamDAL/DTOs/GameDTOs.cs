﻿using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class GameDTOs
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual TitlePublisher Publisher { get; set; }
        public virtual ICollection<TitleUser> Members { get; set; }
        public virtual ICollection<TitleUser> FavoriteMembers { get; set; }
        public float Rating { get; set; }
        public string VideoUrl { get; set; }
        public string Content { get; set; }
        public virtual ICollection<TitleCategory> Categories { get; set; }
        public DateTime PurchaseDate { get; set; }
        public ICollection<TitleImagePublisher> ImageGames { get; set; }
        public string Price { get; set; }
        public float Sale { get; set; }
        public DateTime StartDateSale { get; set; }
        public DateTime EndDateSale { get; set; }


        public GameDTOs()
        {
            Members = new Collection<TitleUser>();
            FavoriteMembers = new Collection<TitleUser>();
            Categories = new Collection<TitleCategory>();
            ImageGames = new Collection<TitleImagePublisher>();
        }
    }

    public class BuyGameObject
    {
        public string id { get; set; }
        public BuyGameObject(string idgame)
        {
            id = idgame;
        }
    }

    public class PutGameSaleResponse
    {
        public string IsSuccess { set; get; }
        public string Message { set; get; }
        public GameDTOs Payload { get; set; }
    }

    public class GetAllGameSaleResponse
    {
        public string IsSuccess { set; get; }
        public string Message { set; get; }
        public ICollection<GameDTOs> Payload { get; set; }

        public GetAllGameSaleResponse()
        {
            Payload = new Collection<GameDTOs>();
        }
    }

    public class GameSaleRequest
    {
        public float Sale { get; set; }
        public DateTime StartDateSale { get; set; }
        public DateTime EndDateSale { get; set; }

        public GameSaleRequest(float sale, DateTime start, DateTime end)
        {
            this.Sale = sale;
            this.StartDateSale = start;
            this.EndDateSale = end;
        }
    }
}
