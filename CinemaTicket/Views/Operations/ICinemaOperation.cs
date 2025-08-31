using CinemaTicket.Views.Factory;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;

namespace CinemaTicket.Views.Operations
{
    public interface ICinemaOperation
    {
        public int OperationId { get;}
        void Execute(CinemaViewModel cinemaViewModel);
    }
}
