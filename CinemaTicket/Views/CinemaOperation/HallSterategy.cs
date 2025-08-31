using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicContracts;
using Core.BusinessLogicServices;
using Core.Domain.Entities;

namespace CinemaTicket.Views.CinemaOperation
{
    public class HallSterategy : ICinemaOperation
    {
        private readonly ICinemaServiceContracts _cinemaService;
        public HallSterategy(ICinemaServiceContracts cinemaService)
        {
            _cinemaService = cinemaService;
        }
        public int OperationId => 5;

        public void Execute(CinemaViewModel cinemaViewModel)
        {
            int cinemaId;
            do
            {
                Console.WriteLine("Insert valid Cinema ID:");
                cinemaId = int.Parse(Console.ReadLine());
            } while (!_cinemaService.ValidCinema(cinemaId));
            
            
            HallViewModel hallViewModel = new HallViewModel() 
            {
                CinemaId = cinemaId,
                cinemaBL = cinemaViewModel.cinemaBL,
                cinemaStrategyFactory = cinemaViewModel.cinemaStrategyFactory,
                hallBl = cinemaViewModel.hallBl,
                hallstrategyFactory = cinemaViewModel.hallStrategyFactory,
                seatBl = cinemaViewModel.seatBl,
                seatSterategyFactory = cinemaViewModel.seatStrategyFactory
            };

            HallView.Index(hallViewModel);
        }
    }
}
