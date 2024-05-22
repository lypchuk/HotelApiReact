using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class TypeRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<HotelRoom>? HotelRooms { get; set; }
    }
}
