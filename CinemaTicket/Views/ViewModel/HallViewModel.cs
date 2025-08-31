using CinemaTicket.Views.Factory;
using Core.BusinessLogicServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Views.ViewModel
{
    public class HallViewModel
    {
        public int CinemaId { get; set; }
        public CinemaService cinemaBL {  get; set; }
        public HallService hallBl { get; set; }
        public SeatService seatBl { get; set; }
        public CinemaFactory cinemaStrategyFactory {  get; set; }
        public HallFactory hallstrategyFactory {  get; set; }
        public SeatFactory seatSterategyFactory { get; set; }
    }
}
