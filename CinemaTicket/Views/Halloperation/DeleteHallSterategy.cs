using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicContracts;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Views.Halloperation
{
    public class DeleteHallSterategy: IHallOperation
    {
        private readonly ISeatServiceContracts _seatSevice;
        public DeleteHallSterategy(ISeatServiceContracts seatSevice)
        {
            _seatSevice = seatSevice;
        }
        public int OperationId => 4;

        public void Execute(HallViewModel hallViewModel)
        {
            int idToDelete = GetInfoToDelete(hallViewModel.hallBl);
            HallResponse hall = hallViewModel.hallBl.GetById(idToDelete);
            if (_seatSevice.AllseatIsNotReserved(idToDelete).Count == hall.Capacity)
            {
                _seatSevice.DeleteMany(idToDelete);
                Console.WriteLine();
                hallViewModel.hallBl.DeleteById(idToDelete);
                //should delete seat and showTime
                Console.WriteLine("============================");
                Console.WriteLine("-------hall deleted------");
                Console.WriteLine("============================"); 
            }
            else
            {
                Console.WriteLine("can't delete when one or more seat is reserved ");
                return;
            }

        }
        /// <summary>
        /// get user to delete from list
        /// </summary>
        /// <param name="conBl"></param>
        /// <returns></returns>
        public int GetInfoToDelete(HallService hallBl)
        {
            Console.WriteLine("Insert hall id to delete?");
            int id_to_delete = int.Parse(Console.ReadLine());
            
            return id_to_delete;
        }
    }
}
