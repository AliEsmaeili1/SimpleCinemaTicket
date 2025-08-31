using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using Core.DTO.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Views.Halloperation 
{
    internal class UpdateHallSterategy:IHallOperation
    {
        public int OperationId => 3;
        public void Execute(HallViewModel hallViewModel)
        {
            Console.WriteLine("Insert hall id to update?");
            int id = int.Parse(Console.ReadLine());

            var updateRequest = GetInfoTUpdate(hallViewModel.hallBl, id);
            hallViewModel.hallBl.Update(updateRequest);
            Console.WriteLine("============================");
            Console.WriteLine("-------Hall Updated---------");
            Console.WriteLine("============================");
        }

        public static HallUpdateRequest GetInfoTUpdate(HallService hallBl, int id_to_update)
        {
            HallResponse? oldHall = hallBl.GetById(id_to_update);
            HallUpdateRequest newHall = new HallUpdateRequest();
            newHall.Id = oldHall.Id;
            Console.WriteLine("Old Opacity: " + oldHall.Capacity);
            Console.WriteLine("New Capacity");
            newHall.Capacity = int.Parse(Console.ReadLine());
            return newHall;
        }
    }
}
