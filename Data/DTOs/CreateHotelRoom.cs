using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOs
{
    public class CreateHotelRoom
    {
        public string Name { get; set; }
        public bool State { get; set; }
        public int TypeRoomId { get; set; }
        public string? TypeRoomName { get; set; }
        public int NumberOfBedsId { get; set; }
        public int? NumberOfBedsNumber { get; set; }
        public int NumberOfSeatsId { get; set; }
        public int? NumberOfSeatsNumber { get; set; }
        public decimal Price { get; set; }
        public string? ImageWay { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public bool Internet { get; set; }
        public bool Bath { get; set; }
        public double? RatingNumber { get; set; }
    }
}
