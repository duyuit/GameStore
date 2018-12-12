using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class UserDTOs
    {
        public virtual ICollection<TitleGame> Games { get; set; }
        public string Hobbies { get; set; }
        public string FullName { get; set; }
        public virtual ICollection<TitleGame> WishGames { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public TitleImagePublisher ImageUser { get; set; }
        public float Money { get; set; }
        public UserDTOs()
        {
            Games = new Collection<TitleGame>();
            WishGames = new Collection<TitleGame>();
        }
    }

    public class GetUserResponse
    {
        public string IsSuccess { set; get; }
        public string Message { set; get; }
        public PayloadBody Payload { get; set; }
    }
    public class PayloadBody
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public string Hobbies { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<TitleGame> Games { get; set; }

        public virtual ICollection<TitleGame> WishGames { get; set; }

        public TitleImagePublisher ImageUser { get; set; }
        public float Money { get; set; }
    }

    public class BuyGameDTO
    {
        public string IsSuccess { get; set; }
        public string Message { get; set; }
        public string Payload { get; set; }
    }

    public class RechargeObject
    {
        public float money { get; set; }

        public RechargeObject(float money)
        {
            this.money = money;
        }
    }

    public class FreeCode
    {
        public string code { get; set; }
        
        public FreeCode(string Code)
        {
            this.code = Code;
        }
    }

    public class GetFreeCodeResponse
    {
        public string IsSuccess { set; get; }
        public string Message { set; get; }
        public PayloadFreeCode Payload { get; set; }
    }

    public class PayloadFreeCode
    {
        public string id { get; set; }
        public string code { get; set; }
        public string game { get; set; }
        public string gameId { get; set; }
    }
}
