using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicContracts;
using Core.BusinessLogicServices;
using Core.Domain.Entities;
using Core.DTO.Response;
namespace CinemaTicket.Views.Halloperation
{
    public class SeatOperationSterategy: IHallOperation
    {
        private readonly IHallServiceContracts _hallService;
        public SeatOperationSterategy(IHallServiceContracts hallService)
        {
            _hallService = hallService;
        }
        public int OperationId => 5;

        public void Execute(HallViewModel hallViewModel)
        {

            int HallaId;
            do
            {
                Console.WriteLine("Insert Hall ID:");
                HallaId = int.Parse(Console.ReadLine());
            } while (!_hallService.ValidHall(HallaId));
            HallResponse hall = hallViewModel.hallBl.GetById(HallaId);
            SeatView.Index(hallViewModel.seatBl, hallViewModel.seatSterategyFactory, hall);
        }
    }
}
