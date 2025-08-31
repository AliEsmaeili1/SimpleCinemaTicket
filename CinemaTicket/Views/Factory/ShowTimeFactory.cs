using CinemaTicket.Views.Operations;

namespace CinemaTicket.Views.Factory
{
    public class ShowTimeFactory //:BaseFactory<IShowTimeOperation>
    {
        //public ShowTimeFactory(IEnumerable<IShowTimeOperation> strategies) : base(strategies) { }

        private readonly Dictionary<int, IShowTimeOperation> _strategies;
        public ShowTimeFactory(IEnumerable<IShowTimeOperation> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.OperationId);

        }
        public IShowTimeOperation GetStrategy(int operationId)
        {
            if (_strategies.TryGetValue(operationId, out var strategy))
                return strategy;
            throw new ArgumentException($"Cinema strategy for operation {operationId} not found");
        }
    }
}
