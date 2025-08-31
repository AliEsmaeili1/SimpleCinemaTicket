using CinemaTicket.Views.Factory;
using Core.BusinessLogicServices;
using Core.DTO.Response;

namespace CinemaTicket.Views.Operations
{
    public interface ISeatOperation
    {
        public int OperationId { get;}
        void Execute(SeatService seatBl, SeatFactory seatSterategyFactory, HallResponse hall);
    }
}
