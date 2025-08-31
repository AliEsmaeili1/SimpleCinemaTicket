using Core.BusinessLogicServices;

namespace CinemaTicket.Views.Operations
{
    public interface ITicketOperation
    {
        public int OperationId { get; set; }
        void Execute(TicketService serviceBl);
    }
}
