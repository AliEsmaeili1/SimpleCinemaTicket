using CinemaTicket.Views.Factory;
using Core.BusinessLogicServices;
using Core.Domain.Entities;

namespace CinemaTicket.Views.Operations
{
    public interface IShowTimeOperation
    {
        public int OperationId { get;}
        void Execute(int HallId, ShowTimeService showTimeBl, MovieService movieBl,
            ShowTimeFactory showTimeStrategyFactory, MovieFactory movieSterategyFactory);
    }
}
