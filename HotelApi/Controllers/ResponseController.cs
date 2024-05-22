using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController : Controller
    {
        private readonly MyHotelDb context;
        public ResponseController(MyHotelDb context)
        {
            this.context = context;
        }

        [HttpGet("all")]
        public IActionResult GetResponses()
        {
            //return Ok(context.Responses.Include(x => x.Rating).ToList());
            //return Ok(context.Responses.ToList());
            return Ok(context.Responses);
        }
    }
}
