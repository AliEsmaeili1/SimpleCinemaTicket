using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;
using Core.DTO.Request;

namespace CinemaTicket.Views.Halloperation
{
    public class AddHallSterategy:IHallOperation
    {
        public int OperationId => 2;

        public void Execute(HallViewModel hallViewModel)
        {
            var HallAddRequest = GetInfoToAdd(hallViewModel.CinemaId);
            hallViewModel.hallBl.Add(HallAddRequest);
            Console.WriteLine("============================");
            Console.WriteLine("-------New Hall Add---------");
            Console.WriteLine("============================");
        }
        /// <summary>
        /// get data from user and add to list
        /// </summary>
        /// <returns>user to add</returns>
        public static HallAddRequest GetInfoToAdd(int cinemaId)
        {
            HallAddRequest newHall = new HallAddRequest();
            newHall.CinemaId = cinemaId;
            Console.WriteLine("Opacity");
            newHall.Capacity = int.Parse(Console.ReadLine());
           
            return newHall;
        }
    }
}
