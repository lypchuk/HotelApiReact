using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public Rating? Rating { get; set; }
        public int RatingId { get; set; }
        public HotelRoom? HotelRooms { get; set; }
        public int HotelRoomId { get; set; }
    }
}
