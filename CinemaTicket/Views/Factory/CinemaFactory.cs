using CinemaTicket.Views.Operations;
using Microsoft.Extensions.DependencyInjection;
namespace CinemaTicket.Views.Factory
{
    public class CinemaFactory// : BaseFactory<ICinemaOperation> 
    {
        //public CinemaFactory(IEnumerable<ICinemaOperation> strategies):base(strategies) { }
        private readonly Dictionary<int, ICinemaOperation> _strategies;
        public CinemaFactory(IEnumerable<ICinemaOperation> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.OperationId);

        }
        public ICinemaOperation GetStrategy(int operationId)
        {
            if (_strategies.TryGetValue(operationId, out var strategy))
                return strategy;
            throw new ArgumentException($"Cinema strategy for operation {operationId} not found");
        }
    }

}
