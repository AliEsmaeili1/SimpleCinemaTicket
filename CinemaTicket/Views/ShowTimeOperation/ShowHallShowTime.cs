using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Helper;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicContracts;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using System;
using System.Collections.Generic;
using System.Data;


namespace CinemaTicket.Views.ShowTimeOperation
{
    public class ShowHallShowTime : IShowTimeOperation
    {
        private readonly IMovieServiceContracts _movieService;

        public ShowHallShowTime(IMovieServiceContracts movieService)
        {
            _movieService= movieService;
        }

        public int OperationId => 2;

        public void Execute(int HallId, ShowTimeService showTimeBl,
            MovieService movieBl, ShowTimeFactory showTimeStrategyFactory, 
            MovieFactory movieSterategyFactory)
        {
            ShowInfo(showTimeBl.AllShowTimeHall(HallId));
        }

        public void ShowInfo(ICollection<ShowTimeResponse> showTime)
        {
            DataTable table = new DataTable("Show Time");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("MoieName", typeof(string));
            table.Columns.Add("StartAt", typeof(DateTime));
            table.Columns.Add("BasePrice", typeof(decimal));

            foreach (var item in showTime)
            {
                MovieResponse movie = _movieService.GetById(item.MovieId);
                table.Rows.Add(item.Id, movie.Title, item.StartAt, item.BasePrice);
            }
            Print.PrintTable(table);
        }
    }
}
