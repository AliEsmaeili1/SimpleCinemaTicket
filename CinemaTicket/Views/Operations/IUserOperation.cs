using Core.BusinessLogicServices;

namespace CinemaTicket.Views.Operations
{
    public interface IUserOperation
    {
        public int OperationId { get; }
        void Execute(UserServices userBl);
    }
}
