using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.Domain.Enums;
using Core.DTO.Request;


namespace CinemaTicket.Views.MovieOperation
{
    public class AddMovieSterategy:IMovieOperation
    {
        public int OperationId => 2;


        public void Execute(MovieService movieBl)
        {
            MovieAddRequest movieAddRequest = GetInfoToAdd(movieBl);

            movieBl.Add(movieAddRequest);

            Console.WriteLine("============================");
            Console.WriteLine($"-------New Movie Add---------");
            Console.WriteLine("============================");
        }
        /// <summary>
        /// get data from user and add to list
        /// </summary>
        /// <returns>user to add</returns>
        public static MovieAddRequest GetInfoToAdd(MovieService movieBl)
        {
            //total Seat = column * row

            MovieAddRequest newMovie = new MovieAddRequest();
            Console.WriteLine("Title");
            newMovie.Title = Console.ReadLine();
            
            string input;
            GenerEnums status;

            do
            {
                Console.WriteLine("please valid Genere (Action/Drama)");
                input = Console.ReadLine();
            } while (Enum.TryParse(input, out status));

            newMovie.Gener = status;

            Console.WriteLine("please valid Time Span");
            newMovie.Duration = TimeSpan.Parse(Console.ReadLine());

            return newMovie;
        }
    }
}
