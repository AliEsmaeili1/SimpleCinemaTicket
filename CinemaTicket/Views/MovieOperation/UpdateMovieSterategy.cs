using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.Domain.Enums;
using Core.DTO.Response;
using Core.DTO.Update;
namespace CinemaTicket.Views.MovieOperation
{
    public class UpdateMovieSterategy : IMovieOperation
    {
        public int OperationId => 3;
        public void Execute(MovieService movieBl)
        {
            Console.WriteLine("Insert Movie id to update?");
            int id = int.Parse(Console.ReadLine());

            MovieUpdateRequest updateRequest = GetInfoTUpdate(movieBl, id);
            movieBl.Update(updateRequest);
            Console.WriteLine("============================");
            Console.WriteLine("-------Movie Updated---------");
            Console.WriteLine("============================");
        }

        public MovieUpdateRequest GetInfoTUpdate(MovieService movieBl, int id_to_update)
        {
            MovieResponse? oldMovie = movieBl.GetById(id_to_update);
            MovieUpdateRequest newMovie = new MovieUpdateRequest();
            newMovie.Id = oldMovie.Id;
            Console.WriteLine("Old Title: " + oldMovie.Title);
            Console.WriteLine("New Title");
            newMovie.Title = Console.ReadLine();
            Console.WriteLine("Old Genere: " + oldMovie.Gener);
            string input;
            GenerEnums status;

            do
            {
                Console.WriteLine("please valid Genere (Action/Drama)");
                input = Console.ReadLine();
            } while (Enum.TryParse(input, out status));

            newMovie.Gener = status;
            Console.WriteLine("Old Duration: " + oldMovie.Duration);
            Console.WriteLine("please valid Time Span");
            newMovie.Duration = TimeSpan.Parse(Console.ReadLine());
            return newMovie;
        }
    }
}
