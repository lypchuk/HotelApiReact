using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Data.DTOs;
using Data.Interfaces;


namespace HotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelRoomController : ControllerBase
    {
        private readonly IHotelRoomService hotelRoomService;
        public HotelRoomController(IHotelRoomService hotelRoomService)
        {
            this.hotelRoomService = hotelRoomService;
        }
        /*
        private readonly MyHotelDb context;
        public HotelController(MyHotelDb context)
        {
            this.context = context;
        }
        */


        [HttpGet("all")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = Policies.ADULT)]
        public async Task<IActionResult> Get()
        {
            return Ok(await hotelRoomService.GetAll());
        }



        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return Ok(await hotelRoomService.Get(id));
        }


        [HttpPost]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = Policies.PREMIUM_CLIENT)]
        public IActionResult Create([FromForm] CreateHotelRoom model)
        {
            hotelRoomService.Create(model);
            return Ok();
        }

        [HttpPut]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Edit([FromBody] HotelRoomDto model)
        {
            hotelRoomService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            hotelRoomService.Delete(id);
            return Ok();
        }

        [HttpGet("typeroom")]
        public IActionResult GetTypeRoomAll()
        {
            return Ok(hotelRoomService.GetTypeRoomAll());
        }

        [HttpGet("numberofbeds")]
        public IActionResult GetNumberOfBedsAll()
        {
            return Ok(hotelRoomService.GetNumberOfBedsAll());
        }

        [HttpGet("numberofseats")]
        public IActionResult GetNumberOfSeatsAll()
        {
            return Ok(hotelRoomService.GetNumberOfSeatsAll());
        }


        /*
        [HttpGet]
        public IActionResult GetHotelRoomInfo()
        {
            //string jsonString = JsonSerializer.Serialize(context.HotelRooms.Include(x => x.NumberOfBeds).Include(x => x.NumberOfSeats).Include(x => x.Responses).Include(x => x.TypeRoom).ToList());
            
            return Ok(context.HotelRooms.Include(x => x.NumberOfBeds).Include(x => x.NumberOfSeats).Include(x => x.Responses).Include(x => x.TypeRoom));
            
            //return Ok(context.HotelRooms.ToList());
            //return Ok(context.HotelRooms);
        }
        

        [HttpGet("{id}")]
        public IActionResult GetHotelRoomInfoId(int id)
        {
            var entity = context.HotelRooms.Find(id);

            if (entity == null)
            {
                return NotFound();
            }
            //return Ok(entity);
            //return Ok(context.HotelRooms.Where(x => x.Id == id).Include(x => x.NumberOfBeds).Include(x => x.NumberOfSeats).Include(x => x.Responses).Include(x => x.TypeRoom).ToList());
            
            return Ok(context.HotelRooms.Where(x => x.Id == id).Include(x => x.NumberOfBeds).Include(x => x.NumberOfSeats).Include(x => x.Responses).Include(x => x.TypeRoom).FirstOrDefault());
            //return Ok(context.HotelRooms.Where(x => x.Id == id).ToList());
            
            //return Ok(context.HotelRooms.Where(x => x.Id == id).FirstOrDefault());
        }




        /*
        [HttpPost]
        //public IActionResult Create([FromForm] HotelRoom model)
        public IActionResult Create(HotelRoom model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            context.HotelRooms.Add(model);
            context.SaveChanges();


            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(HotelRoom model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var entity = context.HotelRooms.AsNoTracking().FirstOrDefault(x => x.Id == model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            context.HotelRooms.Update(model);
            context.SaveChanges();


            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var entity = context.HotelRooms.Find(id);

            if (entity == null)
            {
                return NotFound();
            }

            context.HotelRooms.Remove(entity);
            context.SaveChanges();


            return Ok();
        }
        */
    }
}
