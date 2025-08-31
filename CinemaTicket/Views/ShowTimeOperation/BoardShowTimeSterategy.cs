using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using CinemaTicket.Views.Helper;
using System.Data;
using CinemaTicket.Views.Factory;
using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.Domain.Entities.Mapper;

namespace CinemaTicket.Views.ShowTimeOperation
{
    public class BoardShowTimeSterategy:IShowTimeOperation
    {
        private readonly ICinemaServiceContracts _cinemaServiceContracts;
        private readonly IMovieServiceContracts _moviServiceContracts;
        private readonly IHallServiceContracts _HallService;
        public BoardShowTimeSterategy(IMovieServiceContracts moviServiceContracts, 
            ICinemaServiceContracts cinemaServiceContracts,
            IHallServiceContracts hallService)
        {
            _cinemaServiceContracts = cinemaServiceContracts;
            _moviServiceContracts = moviServiceContracts;
            _HallService = hallService;
        }
        public int OperationId => 1;

        public void Execute(int HallId, ShowTimeService showTimeBl, MovieService movieBl,
            ShowTimeFactory showTimeStrategyFactory, MovieFactory movieSterategyFactory)
        {
            ShowInfo(showTimeBl.GetAll());
        }
        /// <summary>
        /// Show all of user store in list
        /// </summary>
        /// <param name="users"></param>
        public void ShowInfo(ICollection<ShowTimeResponse> Board)
        {
            DataTable table = new DataTable("People");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("cinema", typeof(string));
            table.Columns.Add("Hall", typeof(int));
            table.Columns.Add("Movie", typeof(string));
            table.Columns.Add("BasePrice", typeof(decimal));
            table.Columns.Add("Duration", typeof(TimeSpan));
            table.Columns.Add("Start At", typeof(DateTime));

            foreach (var item in Board)
            {
                CinemaResponse cinema = _cinemaServiceContracts.GetById(_HallService.GetById(item.HallId).CinemaId);
                MovieResponse movie = _moviServiceContracts.GetById(item.MovieId);
                table.Rows.Add(item.Id,cinema.Name, item.HallId, movie.Title, item.BasePrice, movie.Duration, item.StartAt);
            }
            Print.PrintTable(table);
        }
    }
}
