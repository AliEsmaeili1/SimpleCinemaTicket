using CinemaTicket.Views.Factory;
using Core.BusinessLogicServices;


namespace CinemaTicket.Views.ViewModel
{
    public class CinemaViewModel
    {
        
        public CinemaService cinemaBL { get; set; }
        public HallService hallBl { get; set; }
        public SeatService seatBl { get; set; }
        public MovieService movieBl { get; set; }
        public ShowTimeService showTimeBl { get; set; }
        public CinemaFactory cinemaStrategyFactory { get; set; }
        public HallFactory hallStrategyFactory { get; set; }
        public SeatFactory seatStrategyFactory { get; set; }
        public ShowTimeFactory showTimeSterategyFactory { get; set; }
        public MovieFactory movieSterategyFactory { get; set; }
    }
}
