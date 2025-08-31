using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicContracts
{
    public interface ISeatServiceContracts
        :IBaseServiceContracts<SeatAddRequest, SeatResponse, SeatUpdateRequest >
    {
        SeatResponse? GetSeatWithTicket(int id);
        SeatResponse? SeatReserved(int id);
        SeatResponse? SeatOutReserved(int id);
        void AddSeatMany(SeatAddRequest seatAddRequest);
        public List<SeatResponse>? AllseatIsNotReserved(int hallId);
        bool DeleteMany(int hallId);
        List<SeatResponse>? GetHallSeat(int hallId);


    }
}
