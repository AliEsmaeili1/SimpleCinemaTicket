using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.Domain.Entities;
using Core.DTO.Response;
namespace CinemaTicket.Views.Halloperation
{
    public class MovieOperationSterategy: IShowTimeOperation
    {
        public int OperationId => 6;

        public void Execute(int HallId, ShowTimeService showTimeBl, MovieService movieBl,
            ShowTimeFactory showTimeStrategyFactory, MovieFactory movieSterategyFactory)
        {
            Console.WriteLine("Insert ShowTime ID:");
            int HallaId = int.Parse(Console.ReadLine());

            
            MovieView.Index(movieBl, movieSterategyFactory);
        }
    }
}
