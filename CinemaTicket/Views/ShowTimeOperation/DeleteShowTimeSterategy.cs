using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
namespace CinemaTicket.Views.ShowTimeOperation
{
    public class DeleteShowTimeSterategy: IShowTimeOperation
    {
        public int OperationId => 5;

        public void Execute(int HallId, ShowTimeService showTimeBl, MovieService movieBl,
            ShowTimeFactory showTimeStrategyFactory, MovieFactory movieSterategyFactory)
        {
            int idToDelete = GetInfoToDelete(showTimeBl, movieBl);
            showTimeBl.DeleteById(idToDelete);
            Console.WriteLine("============================");
            Console.WriteLine("-------Show Time deleted------");
            Console.WriteLine("============================");
        }


        /// <summary>
        /// get user to delete from list
        /// </summary>
        /// <param name="showTimeBl"></param>
        /// <returns></returns>
        public int GetInfoToDelete(ShowTimeService showTimeBl, MovieService movieBl)
        {
            Console.WriteLine("Insert hall id to delete?");
            int id_to_delete = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert Movie id to delete?");
            int id_Movie_to_delete = int.Parse(Console.ReadLine());
            movieBl.DeleteById(id_to_delete);

            return id_to_delete;
        }
    }
}
