using System.Linq.Expressions;

namespace Core.BusinessLogicContracts
{
    /// <summary>
    /// Base Gneric Class from Service Contracts
    /// </summary>
    /// <typeparam name="TRequest">AddRequest Entity DTO class </typeparam>
    /// <typeparam name="TResponse">Response Entity DTO class </typeparam>
    /// <typeparam name="TUpdate">Update request DTO Class</typeparam>
    public interface IBaseServiceContracts<TRequest, TResponse, TUpdate>
        where TRequest : class
        where TResponse : class
        where TUpdate : class
    {
        ICollection<TResponse> GetAll();
        TResponse GetById(int? id);
        TResponse Add(TRequest requst);
        TResponse Update(TUpdate entityUpdate);
        bool DeleteById(int? id);
    }
}
