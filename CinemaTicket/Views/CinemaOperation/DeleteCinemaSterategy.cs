using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;
using Core.Domain.Entities;
using Core.DTO.Request;

namespace CinemaTicket.Views.CinemaOperation
{
    public class DeleteCinemaStrategy : ICinemaOperation
    {
        public int OperationId => 3;

        public void Execute(CinemaViewModel cinemaViewModel)
        {
            int idToDelete = GetInfoToDlete(cinemaViewModel.cinemaBL);
            cinemaViewModel.cinemaBL.DeleteById(idToDelete);
            //should hall of cinema and seat and showTime deleted
            Console.WriteLine("============================");
            Console.WriteLine("-------Cinema deleted------");
            Console.WriteLine("============================");
        }
        /// <summary>
        /// get user to delete from list
        /// </summary>
        /// <param name="conBl"></param>
        /// <returns></returns>
        public static int GetInfoToDlete(CinemaService cinemaBL)
        {
            Console.WriteLine("Insert cinema id to delete?");
            int id_to_delete = int.Parse(Console.ReadLine());
            return id_to_delete;
        }
    }
}
