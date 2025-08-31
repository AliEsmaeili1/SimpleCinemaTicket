using Core.BusinessLogicServices;

namespace CinemaTicket.Views.Operations
{
    public interface IMovieOperation
    {
        public int OperationId { get; }
        void Execute(MovieService serviceBl);
    }
}
