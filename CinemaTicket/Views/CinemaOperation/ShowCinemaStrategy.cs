using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Helper;
using CinemaTicket.Views.Operations;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using System.Data;
namespace CinemaTicket.Views.CinemaOperation
{
    public class ShowCinemaStrategy : ICinemaOperation
    {
        public int OperationId => 1;

        public void Execute(CinemaViewModel cinemaViewModel)
        {
            ShowInfo(cinemaViewModel.cinemaBL.GetAll());
        }
        /// <summary>
        /// Show all of user store in list
        /// </summary>
        /// <param name="users"></param>
        public static void ShowInfo(ICollection<CinemaResponse> cinemas)
        {
            DataTable table = new DataTable("Cinema");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Addres", typeof(string));

            foreach (var item in cinemas)
            {
                table.Rows.Add(item.Id, item.Name, item.Address);
            }
            Print.PrintTable(table);
        }
    }
}
