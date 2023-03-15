using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabFareDay30
{
    public class User
    {
        public int UserId { get; set; }
        public List<Ride> Rides { get; set; }

        public User(int userId)
        {
            UserId = userId;
            Rides = new List<Ride>();
        }
    }
}
