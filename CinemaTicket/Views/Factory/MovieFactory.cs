using CinemaTicket.Views.Operations;
using Core.BusinessLogicServices;

namespace CinemaTicket.Views.Factory
{
    public class MovieFactory//:BaseFactory<IMovieOperation>
    {
        private readonly Dictionary<int, IMovieOperation> _strategies;
        public MovieFactory(IEnumerable<IMovieOperation> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.OperationId);

        }
        public IMovieOperation GetStrategy(int operationId)
        {
            if (_strategies.TryGetValue(operationId, out var strategy))
                return strategy;
            throw new ArgumentException($"Cinema strategy for operation {operationId} not found");
        }
    }
}
