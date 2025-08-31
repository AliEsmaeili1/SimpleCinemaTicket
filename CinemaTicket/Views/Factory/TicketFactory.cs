using CinemaTicket.Views.Operations;


namespace CinemaTicket.Views.Factory
{
    public class TicketFactory//:BaseFactory<ITicketOperation>
    {
        private readonly Dictionary<int, ITicketOperation> _strategies;
        public TicketFactory(IEnumerable<ITicketOperation> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.OperationId);

        }
        public ITicketOperation GetStrategy(int operationId)
        {
            if (_strategies.TryGetValue(operationId, out var strategy))
                return strategy;
            throw new ArgumentException($"Cinema strategy for operation {operationId} not found");
        }
    }
}
