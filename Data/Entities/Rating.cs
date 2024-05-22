using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public ICollection<Response>? Responses { get; set; }
        //public ICollection<HotelRoom>? HotelRooms { get; set; }
    }
}
