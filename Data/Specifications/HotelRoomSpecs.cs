using Ardalis.Specification;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Data.Specifications
{
    internal class HotelRoomSpecs
    {
        internal class ById : Specification<HotelRoom>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x => x.TypeRoom)
                    .Include(x => x.NumberOfBeds)
                    .Include(x => x.NumberOfSeats);
            }
        }
        internal class All : Specification<HotelRoom>
        {
            public All()
            {
                Query.Include(x => x.TypeRoom)
                    .Include(x => x.NumberOfBeds)
                    .Include(x => x.NumberOfSeats);
            }
        }
        internal class ByIds : Specification<HotelRoom>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.TypeRoom)
                    .Include(x => x.NumberOfBeds)
                    .Include(x => x.NumberOfSeats);
            }
        }
    }
}
