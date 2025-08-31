using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;
using Core.Domain.Entities;
using Core.DTO.Request;

namespace CinemaTicket.Views.CinemaOperation
{
    public class AddCinemaStrategy:ICinemaOperation
    {
        public int OperationId => 2;

        public void Execute(CinemaViewModel cinemaViewModel)
        {
            var cinemaAddRequest = GetInfoToAdd();
            cinemaViewModel.cinemaBL.Add(cinemaAddRequest);
            Console.WriteLine("============================");
            Console.WriteLine("-------New User Add---------");
            Console.WriteLine("============================");
        }
        /// <summary>
        /// get data from user and add to list
        /// </summary>
        /// <returns>user to add</returns>
        public static CinemaAddRequst GetInfoToAdd()
        {
            CinemaAddRequst newCinema = new CinemaAddRequst();
            Console.WriteLine("Cinema Name");
            newCinema.Name= Console.ReadLine();
            Console.WriteLine("Address");
            newCinema.Address = Console.ReadLine();
            return newCinema;
        }
    }
}
