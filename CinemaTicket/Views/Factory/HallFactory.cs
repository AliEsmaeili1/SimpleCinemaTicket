using CinemaTicket.Views.Operations;

namespace CinemaTicket.Views.Factory
{
    public class HallFactory//:BaseFactory<IHallOperation>
    {
        //public HallFactory(IEnumerable<IHallOperation> strategies) : base(strategies) { }
        private readonly Dictionary<int, IHallOperation> _strategies;
        public HallFactory(IEnumerable<IHallOperation> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.OperationId);

        }
        public IHallOperation GetStrategy(int operationId)
        {
            if (_strategies.TryGetValue(operationId, out var strategy))
                return strategy;
            throw new ArgumentException($"Cinema strategy for operation {operationId} not found");
        }
    }
}
