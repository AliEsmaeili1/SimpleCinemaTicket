using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Helper;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Response;
using System.Data;

namespace CinemaTicket.Views.SeatOperation
{
    public class ShowSeatStrategy:ISeatOperation
    {
        public int OperationId => 1;

        public void Execute(SeatService seatBl, SeatFactory seatSterategyFactory, HallResponse hall)
        {
            ShowInfo(seatBl.GetHallSeat(hall.Id));
        }
        /// <summary>
        /// Show all of user store in list
        /// </summary>
        /// <param name="users"></param>
        public void ShowInfo(ICollection<SeatResponse> seats)
        {
            DataTable table = new DataTable("Movies");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("SeatNo", typeof(int));
            table.Columns.Add("SeatRow", typeof(int));
            table.Columns.Add("IsAvailable", typeof(bool));
            table.Columns.Add("IsVip", typeof(bool));
            table.Columns.Add("Extera Price", typeof(decimal));

            foreach (var item in seats)
            {
                table.Rows.Add(item.Id, item.SeatNo, item.SeatRow, item.IsAvailable, item.IsVip, item.ExtraPrice);
            }
            Print.PrintTable(table);
        }
    }
}
