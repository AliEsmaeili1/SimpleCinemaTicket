using CinemaTicket.Views.Operations;

namespace CinemaTicket.Views.Factory
{
    public class SeatFactory//:BaseFactory<ISeatOperation>
    {
        private readonly Dictionary<int, ISeatOperation> _strategies;
        public SeatFactory(IEnumerable<ISeatOperation> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.OperationId);

        }
        public ISeatOperation GetStrategy(int operationId)
        {
            if (_strategies.TryGetValue(operationId, out var strategy))
                return strategy;
            throw new ArgumentException($"Cinema strategy for operation {operationId} not found");
        }
    }
}
