using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;

namespace CinemaTicket.Views.CinemaOperation
{
    public class ShowTimeSterategy : ICinemaOperation
    {
        public int OperationId => 6;

        public void Execute(CinemaViewModel cinemaViewModel)
        {
            Console.WriteLine("insert hall id to show sanse?");
            int hallId = int.Parse(Console.ReadLine());
            ShowTimeView.Index(hallId, cinemaViewModel.showTimeBl, 
                cinemaViewModel.movieBl, cinemaViewModel.showTimeSterategyFactory, 
                cinemaViewModel.movieSterategyFactory);
        }
    }
}
