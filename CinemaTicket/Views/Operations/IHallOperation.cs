using CinemaTicket.Views.Factory;
using CinemaTicket.Views.ViewModel;
using Core.BusinessLogicServices;
namespace CinemaTicket.Views.Operations
{
    public interface IHallOperation
    {
        public int OperationId { get;}
        void Execute(HallViewModel hallViewModel);
    }
}
