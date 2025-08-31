using CinemaTicket.Views.Operations;
using Microsoft.Extensions.DependencyInjection;
namespace CinemaTicket.Views.Factory
{
    public class UserFactory //: BaseFactory<IUserOperation> 
    {
        private readonly Dictionary<int, IUserOperation> _strategies;
        public UserFactory(IEnumerable<IUserOperation> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.OperationId);

        }
        public IUserOperation GetStrategy(int operationId)
        {
            if (_strategies.TryGetValue(operationId, out var strategy))
                return strategy;
            throw new ArgumentException($"Cinema strategy for operation {operationId} not found");
        }
    }
}
