using CinemaTicket.Views.Factory;
using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;
using Core.DTO.Request;
using Core.DTO.Response;

namespace CinemaTicket.Views.SeatOperation
{
    public class AddSeatSterategy:ISeatOperation
    {
        public int OperationId => 2;

        public void Execute(SeatService seatBl, SeatFactory seatSterategyFactory, HallResponse hall)
        {
            SeatAddRequest seatAddRequest = GetInfoToAdd(hall);
            
            seatBl.AddSeatMany(seatAddRequest);

            Console.WriteLine("============================");
            Console.WriteLine($"-------New seat {hall.Capacity} Add---------");
            Console.WriteLine("============================");
        }
        /// <summary>
        /// get data from user and add to list
        /// </summary>
        /// <returns>user to add</returns>
        public SeatAddRequest GetInfoToAdd(HallResponse hall)
        {
            //total Seat = column * row

            SeatAddRequest newSeat = new SeatAddRequest();
            newSeat.HallId = hall.Id;
            Console.WriteLine("Column");
            newSeat.SeatNo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Row");
            newSeat.SeatRow =  hall.Capacity / newSeat.SeatNo;
            Console.WriteLine("Extra price for vip seat");
            newSeat.ExtraPrice = int.Parse(Console.ReadLine());

            return newSeat;
        }
    }
}
