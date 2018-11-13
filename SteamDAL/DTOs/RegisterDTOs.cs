using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class RegisterDTOs
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Hobbies { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public virtual ICollection<Guid> IDGames { get; set; }
        public virtual ICollection<Guid> IDWishGames { get; set; }
        public RegisterDTOs()
        {
            IDGames = new Collection<Guid>();
            IDWishGames = new Collection<Guid>();
        }
    }
}
