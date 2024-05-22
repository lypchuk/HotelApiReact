using Data;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeRoomController : Controller
    {

        private readonly MyHotelDb context;
        public TypeRoomController(MyHotelDb context)
        {
            this.context = context;
        }


        [HttpGet("all")]
        public IActionResult All()
        {
            return Ok(context.TypeRooms);
        }
    }
}
