using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicContracts;
using Core.BusinessLogicServices;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
namespace CinemaTicket.Views.SeatOperation
{
    public class UpdateSeatSterategy: ISeatOperation
    {
        private readonly IHallServiceContracts _hallService;
        public UpdateSeatSterategy(IHallServiceContracts hallService)
        {
            _hallService = hallService;
        }
        public int OperationId => 3;
        public void Execute(SeatService seatBl, SeatFactory seatSterategyFactory, HallResponse hall)
        {
            Console.WriteLine("Insert hall id to update?");
            int id = int.Parse(Console.ReadLine());

            GetInfoToUpdate(seatBl, id);
            //seatBl.Update(updateRequest);
            Console.WriteLine("============================");
            Console.WriteLine("-------Seat Updated---------");
            Console.WriteLine("============================");
        }

        public void GetInfoToUpdate(SeatService seatBl, int id_to_update)
        {
            seatBl.DeleteMany(id_to_update);
            AddSeatSterategy addSeatSterategy = new AddSeatSterategy();

            SeatAddRequest request = addSeatSterategy.GetInfoToAdd(_hallService.GetById(id_to_update));
            seatBl.AddSeatMany(request);
            
        }
    }
}
