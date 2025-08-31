using CinemaTicket.Views.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Views.Factory
{
    public abstract class BaseFactory<TinterfaceOperation>
        where TinterfaceOperation : class, IOperation
    {
        private readonly Dictionary<int, TinterfaceOperation> _strategies;
        public BaseFactory(IEnumerable<TinterfaceOperation> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.OperationId);
            
        }
        public TinterfaceOperation GetStrategy(int operationId)
        {
            if (_strategies.TryGetValue(operationId, out var strategy))
                return strategy;
            throw new ArgumentException($"Cinema strategy for operation {operationId} not found");
        }
    }
}
