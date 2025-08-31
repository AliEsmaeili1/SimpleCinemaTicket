using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Response;


namespace CinemaTicket.Views.MovieOperation
{
    internal class DeleteMovieSterategy:IMovieOperation
    {
        public int OperationId => 4;

        public void Execute(MovieService movieBl)
        {
            int idToDelete = GetInfoToDelete(movieBl);
            movieBl.DeleteById(idToDelete);
            //should delete seat
            Console.WriteLine("============================");
            Console.WriteLine("-------Movie deleted------");
            Console.WriteLine("============================");
        }
        /// <summary>
        /// get user to delete from list
        /// </summary>
        /// <param name="conBl"></param>
        /// <returns></returns>
        public int GetInfoToDelete(MovieService movieBl)
        {
            Console.WriteLine("Insert Movie id to delete?");
            int id_to_delete = int.Parse(Console.ReadLine());
            return id_to_delete;
        }
    }
}
