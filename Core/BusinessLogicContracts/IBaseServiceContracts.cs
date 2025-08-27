namespace Core.BusinessLogicContracts
{
    /// <summary>
    /// Base Gneric Class from Service Contracts
    /// </summary>
    /// <typeparam name="TRequst">AddRequest Entity DTO class </typeparam>
    /// <typeparam name="TResponse">Response Entity DTO class </typeparam>
    /// <typeparam name="TUpdate">Update request DTO Class</typeparam>
    public interface IBaseServiceContracts<TRequest, TResponse, TUpdate>
        where TRequest : class
        where TResponse : class
        where TUpdate : class
    {
        ICollection<TResponse> GetAll();
        TResponse GetById(int id);
        TResponse Add(TRequest requst);
        TResponse Update(TUpdate update);
        TResponse DeleteById(int id);
    }
}
