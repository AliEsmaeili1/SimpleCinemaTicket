using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Response;


namespace CinemaTicket.Views.SeatOperation
{
    public class DeleteSeatSterategy:ISeatOperation
    {
        public int OperationId => 4;

        public void Execute(SeatService seatBl, SeatFactory seatSterategyFactory, HallResponse hall)
        {
            int idToDelete = GetInfoToDelete(seatBl);
            seatBl.DeleteMany(idToDelete);
            //should delete seat
            Console.WriteLine("============================");
            Console.WriteLine("-------seat deleted------");
            Console.WriteLine("============================");
        }
        /// <summary>
        /// get user to delete from list
        /// </summary>
        /// <param name="conBl"></param>
        /// <returns></returns>
        public static int GetInfoToDelete(SeatService hallBl)
        {
            Console.WriteLine("Insert hall id to delete?");
            int id_to_delete = int.Parse(Console.ReadLine());
            return id_to_delete;
        }
    }
}
