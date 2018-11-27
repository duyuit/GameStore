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
        public virtual ICollection<TitleGame> Games { get; set; }

        public string Hobbies { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<TitleGame> WishGames { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public TitleImagePublisher ImageUser { get; set; }
    }
}
