using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class HotelRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }
        public int TypeRoomId { get; set; }
        public TypeRoom? TypeRoom { get; set; }
        public int NumberOfBedsId { get; set; }
        public NumberOfBeds? NumberOfBeds { get; set; }
        public int NumberOfSeatsId { get; set; }
        public NumberOfSeats? NumberOfSeats { get; set; }
        public decimal Price { get; set; }
        public string? ImageWay { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        //public int Quantity { get; set; }
        public bool Internet { get; set; }
        public bool Bath { get; set; }

        //public Response? Response { get; set; }
        public ICollection<Response>? Responses { get; set; }
        //public int ResponseId { get; set; }

        //public Rating? Rating { get; set; }
        //public int RatingId { get; set; }
        public double? RatingNumber { get; set; }

    }
}
