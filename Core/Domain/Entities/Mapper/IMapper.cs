namespace Core.Domain.Entities
{
    public interface IMapper<TEntity, TResponse, TRequest>
        where TEntity : class
        where TResponse : class
        where TRequest : class
    {
        /// <summary>
        /// mapping Entity to ResponseEntity
        /// </summary>
        /// <param name="entity">Entity to mapping</param>
        /// <returns>converted entity</returns>
        TResponse ToResponseDomain(TEntity entity);
        /// <summary>
        /// mapping entity add request to Entity object
        /// </summary>
        /// <param name="request">EntityAddRequest</param>
        /// <returns>Model Entity</returns>
        TEntity ToEntity(TRequest request);
    }
}
