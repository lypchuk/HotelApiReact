using Data.DTOs;

namespace Data.Interfaces
{
    public interface IHotelRoomService
    {
        Task<IEnumerable<HotelRoomDto>> GetAll();
        Task<IEnumerable<HotelRoomDto>> Get(IEnumerable<int> ids);      
        Task<HotelRoomDto?> Get(int id);
        IEnumerable<TypeRoomDto> GetTypeRoomAll();
        IEnumerable<NumberOfBedsDto> GetNumberOfBedsAll();
        IEnumerable<NumberOfSeatsDto> GetNumberOfSeatsAll();

        void Create(CreateHotelRoom room);
        void Edit(HotelRoomDto room);
        void Delete(int id);
        
    }
}
