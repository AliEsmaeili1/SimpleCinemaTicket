using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
using System.Net.Sockets;

namespace Core.BusinessLogicServices
{
    public class SeatService
        : BaseService<Seat, SeatAddRequest, SeatResponse, SeatUpdateRequest>
        ,ISeatServiceContracts
    {
        private readonly ISeatRepository _seatRepository;
        public SeatService(IMapper<Seat, SeatResponse>mapper, IBaseRespository<Seat> repository, ISeatRepository seatRepository)
            :base(mapper, repository) 
        {
            _seatRepository = seatRepository;
        }
        /// <summary>
        /// Represent given column as SeatNo and calculet system row as seatRow and 
        /// add all of seat number of row * column
        /// </summary>
        /// <param name="seatAddRequest">number of seat to add for hall</param>
        /// <exception cref="Exception"></exception>
        public void AddSeatMany(SeatAddRequest seatAddRequest)
        {
            SeatAddRequest seat = new SeatAddRequest();
            seat = seatAddRequest.DeepCopy();
            for (int i = 1; i <= seatAddRequest.SeatRow; i++)
            {
                for(int j = 1; j <= seatAddRequest.SeatNo; j++)
                {
                    if(i == 1)
                    {
                        seat.SeatNo = j;
                        seat.SeatRow = i;
                        seat.IsVip = true;
                        seat.IsAvailable = true;
                    }else
                    {
                        seat.SeatNo = j;
                        seat.SeatRow = i;
                        seat.IsVip = true;
                        seat.ExtraPrice = 0;
                    }
                    try
                    {
                        _repository.Add(_mapper.ToEntity(seat));
                    }
                    catch (Exception)
                    {

                        throw new Exception("Add seat is wrong");
                    }
                    
                }
            }
        }
        /// <summary>
        /// Represent delete all of seat in specific hall
        /// </summary>
        /// <param name="hallId"></param>
        /// <returns></returns>
        public bool DeleteMany(int hallId)
        {
            return _seatRepository.DeleteAll(hallId);
        }
        /// <summary>
        /// given hall id base on fet all information seat in hall
        /// </summary>
        /// <param name="hallId">base on search in hall list</param>
        /// <returns>all of seat in specific hall</returns>
        public List<SeatResponse> GetHallSeat(int hallId)
        {
            List<Seat> seats = _repository.GetMany(item => item.HallId == hallId).ToList();

            return seats.Select(se => _mapper.ToResponseDomain(se)).ToList();
        }
        /// <summary>
        /// Represent get seat include Tickets collection
        /// </summary>
        /// <param name="id">ticket seat id</param>
        /// <returns></returns>
        public SeatResponse? GetSeatWithTicket(int id)
        {
            Seat? seat = _repository.Get(item => item.Id == id);

            return _mapper.ToResponseDomain(seat);
        }
        /// <summary>
        /// Represent when user cancle ticket this method free seat to buy
        /// </summary>
        /// <param name="id">seat id based on sear in Seat list</param>
        /// <returns>seat is free</returns>
        public SeatResponse? SeatOutReserved(int id)
        {
            Seat? seat = _repository.Get(item => item.Id == id);
            seat.IsAvailable = true;
            _repository.Update(seat);
            return _mapper.ToResponseDomain(seat);
        }
        /// <summary>
        /// Represent when user buy ticket this method reserve seat 
        /// </summary>
        /// <param name="id">seat id based on search in seat list</param>
        /// <returns>seat was reserved</returns>
        public SeatResponse? SeatReserved(int id)
        {
            Seat? seat = _repository.Get(item => item.Id == id);
            seat.IsAvailable = false;
            _repository.Update(seat);
            return _mapper.ToResponseDomain(seat);
        }
        /// <summary>
        /// Represent return all seat are free to buy mean not reserve
        /// </summary>
        /// <param name="hallId">hall id based on search in hall list</param>
        /// <returns></returns>
        public List<SeatResponse>? AllseatIsNotReserved(int hallId)
        {
            List<Seat> seats = _repository.GetMany(item => item.HallId == hallId);

            List<SeatResponse> seatIsAvailable = seats
                                                 .Where(s => s.IsAvailable == true)
                                                 .Select(s => _mapper.ToResponseDomain(s)).ToList();
            return seatIsAvailable;
        }
       
    }
}
