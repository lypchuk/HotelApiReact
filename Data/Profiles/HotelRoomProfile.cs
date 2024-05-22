using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;
using Data.DTOs;
using Data.Entities;


namespace Data.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile(IFileService fileService)
        {
            CreateMap<HotelRoomDto, HotelRoom>()
                .ForMember(x => x.TypeRoom, opt => opt.Ignore());
            CreateMap<HotelRoom, HotelRoomDto>();

            
            CreateMap<TypeRoom, TypeRoomDto>().ReverseMap();
            CreateMap<NumberOfSeats, NumberOfSeatsDto>().ReverseMap();
            CreateMap<NumberOfBeds, NumberOfBedsDto>().ReverseMap();


            //CreateMap<Order, OrderDto>().ReverseMap();


            CreateMap<CreateHotelRoom, HotelRoom>();
            //CreateMap<CreateHotelRoom, HotelRoom>()
            //    .ForMember(x => x.ImageUrl, opt => opt.MapFrom(src => fileService.SaveProductImage(src.Image).Result));

            /*
            CreateMap<Order, OrderSummaryModel>()
                .ForMember(x => x.Number, opts => opts.MapFrom(src => src.Id))
                .ForMember(x => x.UserName, opts => opts.MapFrom(src => src.User.UserName));

            CreateMap<RegisterModel, User>()
                .ForMember(x => x.UserName, opts => opts.MapFrom(s => s.Email));
            */
        }
    }
}
