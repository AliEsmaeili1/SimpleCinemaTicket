using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using Core.DTO.Update;
namespace CinemaTicket.Views.ShowTimeOperation
{
    internal class UpdateShowSterategy:IShowTimeOperation
    {
        public int OperationId => 4;
        public void Execute(int HallId, ShowTimeService showTimeBl, MovieService movieBl,
            ShowTimeFactory showTimeStrategyFactory, MovieFactory movieSterategyFactory)
        {
            Console.WriteLine("Insert Show Time id to update?");
            int id = int.Parse(Console.ReadLine());

            var updateRequest = GetInfoTUpdate(showTimeBl, id);
            showTimeBl.Update(updateRequest);
            Console.WriteLine("============================");
            Console.WriteLine("-------ShowTime Updated---------");
            Console.WriteLine("============================");
        }

        public static ShowTimeUpdateRequest GetInfoTUpdate(ShowTimeService showTimeBl, int id_to_update)
        {
            ShowTimeResponse? oldShowTime = showTimeBl.GetById(id_to_update);
            ShowTimeUpdateRequest newShowTime = new ShowTimeUpdateRequest();
            newShowTime.Id = oldShowTime.Id;
            newShowTime.HallId = oldShowTime.HallId;

            Console.WriteLine("Old Date: " + oldShowTime.StartAt);
            Console.WriteLine("Date (2005-05-01)");
            newShowTime.StartAt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Old Price: " + oldShowTime.BasePrice);
            Console.WriteLine("Base Price");
            newShowTime.BasePrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Old Movie: " + oldShowTime.MovieId);
            Console.WriteLine("Movie id");
            newShowTime.MovieId = int.Parse(Console.ReadLine());
            return newShowTime;
        }

    }
}
