using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using CinemaTicket.Views.Helper;
using System.Data;
using Core.Domain.Enums;

namespace CinemaTicket.Views.MovieOperation
{
    public class ShowMovieStrategy:IMovieOperation
    {
        public int OperationId => 1;

        public void Execute(MovieService movieBl)
        {
            ShowInfo(movieBl.GetAll());
        }
        /// <summary>
        /// Show all of user store in list
        /// </summary>
        /// <param name="users"></param>
        public static void ShowInfo(ICollection<MovieResponse> movies)
        {
            DataTable table = new DataTable("Movies");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Genere", typeof(GenerEnums));
            table.Columns.Add("Duration", typeof(TimeSpan));
            
            foreach (var item in movies)
            {
                table.Rows.Add(item.Id, item.Title, item.Gener, item.Duration);
            }
            Print.PrintTable(table);
        }
    }
}
