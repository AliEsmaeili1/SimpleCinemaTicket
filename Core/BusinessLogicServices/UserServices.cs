using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
using System.Runtime.CompilerServices;

namespace Core.BusinessLogicServices
{
    public class UserServices: BaseService<User, UserAddRequest, UserResponse, UserUpdateRequest>
                               ,IUserServiceContracts
    {
        private readonly ISeatServiceContracts _seatService;
        private readonly ITicketServiceContracts _ticketService;
        private readonly IShowTimeContracts _showTimeService;
        private readonly IMovieServiceContracts _movieService;
        private readonly ICinemaServiceContracts _cinemaService;
        private readonly IHallServiceContracts _hallService;
        public UserServices
            (IMapper<User, UserResponse> mapper,
            IBaseRespository<User> repository,
            ISeatServiceContracts seatService,
            ITicketServiceContracts ticketService, 
            IShowTimeContracts showTimeService,
            IMovieServiceContracts movieService,
            ICinemaServiceContracts cinemaService,
            IHallServiceContracts hallService) 
            : base(mapper, repository) 
        {
            _seatService = seatService;
            _ticketService = ticketService;
            _showTimeService = showTimeService;
            _movieService = movieService;
            _cinemaService = cinemaService;
            _hallService = hallService;
        }
        /// <summary>
        /// Buy Ticket Service from user request
        /// </summary>
        /// <param name="ticket">ticket to issuing</param>
        /// <exception cref="ArgumentNullException">if seat in hall not exist</exception>
        /// <exception cref="Exception">ticket is unique and not issuing twice</exception>
        public bool BuyTicket(TicketAddRequest ticket, int userId)
        {
            //Check Capacity of Hall
            ShowTimeResponse showTime = _showTimeService.GetById(ticket.ShowTimeId);
            int seatNotReserved = _seatService.AllseatIsNotReserved(showTime.HallId).Count;
            if (seatNotReserved == 0) return false;

            //Get All Ticket Of user to check user can't twice same movie
            List<TicketResponse> ticketUser = _ticketService.GetManyTicektUser(userId);
            //seat include ticekts
            SeatResponse? seatResponse = _seatService.GetSeatWithTicket(ticket.SeatId);
            //get show time base on seat id of hall's cinema
            ShowTimeResponse showTimeTicket = _showTimeService.GetById(ticket.ShowTimeId);
            if (seatResponse is null)
                throw new ArgumentNullException("this seat is not existed");
            if (ticketUser.Any(t=> t.ShowTimeId == ticket.ShowTimeId))
                throw new Exception("this ticket is already issuing");
            //should seat reserved 
            _seatService.SeatReserved(ticket.SeatId);
            //issuing Ticket if be seat is vip sum ExtraPrice for vip to purchase
            if(seatResponse.IsVip)
                ticket.Payment = $"Price: {showTimeTicket.BasePrice} + {seatResponse.ExtraPrice} ";
            else
                ticket.Payment = $"Price: {showTimeTicket.BasePrice}";

            _ticketService.Add(ticket);

            Console.WriteLine("Your Ticket is Issuing");
            return true;
        }
        /// <summary>
        /// Cancel Ticket from user
        /// </summary>
        /// <param name="userId">for security: any user doesn't cancle any ticket</param>
        /// <param name="ticketId">matches with this ticket</param>
        public void CancleTicket(int userId, int ticketId)
        {
            //Delte Ticket
            TicketResponse ticket_to_delete = _ticketService.GetTicektUser(ticketId, userId);
            if(_ticketService.DeleteById(ticket_to_delete.Id))
                 //Seat Should free
                _seatService.SeatOutReserved(ticket_to_delete.SeatId);
        }
        /*public List<TicketResponse> GetAllTicketUser(int userId)
        {
            List<TicketResponse> tickets_user = _ticketService.GetManyTicektUser(userId);
            return tickets_user;
        }*/
        /// <summary>
        /// any ticket of user has been bought
        /// </summary>
        /// <param name="userId">base on user</param>
        public void ShowTicket(int userId)
        {
            List<TicketResponse> tickets_user = _ticketService.GetManyTicektUser(userId);
            Console.WriteLine("===============================================================================================================\n");
            foreach (var item in tickets_user)
            {
                SeatResponse seat = _seatService.GetById(item.SeatId);
                ShowTimeResponse showTime = _showTimeService.GetById(item.ShowTimeId);
                MovieResponse movie = _movieService.GetById(showTime.MovieId);
                HallResponse hall = _hallService.GetById(seat.HallId);
                CinemaResponse cinema = _cinemaService.GetById(hall.CinemaId);
                Console.Write(item.Id + " "+ "Cinema: "+ cinema.Name + " seatNo: " +seat.SeatNo +""+ seat.SeatRow +" Hall " + showTime.HallId + 
                    " MovieName: " + movie.Title + " MovieDuration: " + movie.Duration + " Price: " + showTime.BasePrice +"\n");
            }
            Console.WriteLine("===============================================================================================================\n");
        }
    }
}
