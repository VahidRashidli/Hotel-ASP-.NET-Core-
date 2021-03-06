using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Hotel.Models
{
    public class User:IdentityUser
    {
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public ICollection<Comment> Comments { get; set; }
        public string Image { get; set; }
        public bool IsHotelUser { get; set; } = false;
        public ICollection<Reservation> Reservations { get; set; }
        public bool IsBlocked { get; set; } = false;
    }
}
