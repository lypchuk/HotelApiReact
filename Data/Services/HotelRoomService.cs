using AutoMapper;
using Data.DTOs;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Data.Specifications;
using Data.Entities;


//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data.Services
{
    public class HotelRoomService: IHotelRoomService
    {
        private readonly IMapper mapper;
        private readonly IRepository<HotelRoom> hotelRoomR;
        private readonly IRepository<TypeRoom> typeRoomR;
        private readonly IRepository<NumberOfBeds> numberOfBedsR;
        private readonly IRepository<NumberOfSeats> numberOfSeatsR;



        public HotelRoomService(IMapper mapper,
                               IRepository<HotelRoom> hotelRoomR,
                               IRepository<NumberOfBeds> numberOfBedsR,
                               IRepository<NumberOfSeats> numberOfSeatsR,
                               IRepository<TypeRoom> typeRoomR)
        {
            this.mapper = mapper;
            this.hotelRoomR = hotelRoomR;
            this.typeRoomR = typeRoomR;
            this.numberOfBedsR = numberOfBedsR;
            this.numberOfSeatsR = numberOfSeatsR;
        }

        public async Task<HotelRoomDto?> Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            var item = await hotelRoomR.GetItemBySpec(new HotelRoomSpecs.ById(id));
            if (item == null) throw new HttpException(Errors.HotelRoomNotFound, HttpStatusCode.NotFound);

            // load related entity
            //context.Entry(item).Reference(x => x.Category).Load();

            // convert entity type to DTO
            // 1 - using manually (handmade)
            //var dto = new ProductDto()
            //{
            //    Id = product.Id,
            //    CategoryId = product.CategoryId,
            //    Description = product.Description,
            //    Discount = product.Discount,
            //    ImageUrl = product.ImageUrl,
            //    InStock = product.InStock,
            //    Name = product.Name,
            //    Price = product.Price,
            //    CategoryName = product.Category.Name
            //};
            // 2 - using AutoMapper
            var dto = mapper.Map<HotelRoomDto>(item);

            return dto;
        }

        public async Task<IEnumerable<HotelRoomDto>> GetAll()
        {
            return mapper.Map<List<HotelRoomDto>>(await hotelRoomR.GetListBySpec(new HotelRoomSpecs.All()));
        }

        public void Create(CreateHotelRoom room)
        {
            hotelRoomR.Insert(mapper.Map<HotelRoom>(room));
            hotelRoomR.Save();
        }

        public void Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustPositive, HttpStatusCode.BadRequest);

            // delete product by id
            var product = hotelRoomR.GetById(id);

            if (product == null) throw new HttpException(Errors.HotelRoomNotFound, HttpStatusCode.NotFound);

            hotelRoomR.Delete(product);
            hotelRoomR.Save();
        }

        public void Edit(HotelRoomDto room)
        {
            hotelRoomR.Update(mapper.Map<HotelRoom>(room));
            hotelRoomR.Save();
        }


        public async Task<IEnumerable<HotelRoomDto>> Get(IEnumerable<int> ids)
        {
            //return mapper.Map<List<ProductDto>>(context.Products
            //    .Include(x => x.Category)
            //    .Where(x => ids.Contains(x.Id))
            //    .ToList());
            return mapper.Map<List<HotelRoomDto>>(await hotelRoomR.GetListBySpec(new HotelRoomSpecs.ByIds(ids)));
        }

        
        public IEnumerable<TypeRoomDto> GetTypeRoomAll()
        {
            return mapper.Map<List<TypeRoomDto>>(typeRoomR.GetAll());
        }


        public IEnumerable<NumberOfBedsDto> GetNumberOfBedsAll()
        {
            return mapper.Map<List<NumberOfBedsDto>>(numberOfBedsR.GetAll());
        }

        public IEnumerable<NumberOfSeatsDto> GetNumberOfSeatsAll()
        {
            return mapper.Map<List<NumberOfSeatsDto>>(numberOfSeatsR.GetAll());
        }

    }
}
