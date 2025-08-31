using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Helper;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;
using Core.Domain.Entities;
using Core.DTO.Response;
using System.Data;

namespace CinemaTicket.Views.Halloperation
{
    public class ShowHallStrategy: IHallOperation
    {
        public int OperationId => 1;


        public void Execute(HallViewModel hallViewModel)
        {
            ShowInfo(hallViewModel.hallBl.GetAll());
        }
        /// <summary>
        /// Show all of user store in list
        /// </summary>
        /// <param name="users"></param>
        public static void ShowInfo(ICollection<HallResponse> halls)
        {
            DataTable table = new DataTable("People");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Capacity", typeof(int));
            

            foreach (var item in halls)
            {
                table.Rows.Add(item.Id, item.Capacity);
            }
            Print.PrintTable(table);
        }

      
    }
}
