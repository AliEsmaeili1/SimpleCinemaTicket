namespace Core.Domain.Entities
{
    public interface IMapper<TEntity, TResponse>
        where TEntity : class
        where TResponse : class
    {
        /// <summary>
        /// mapping Entity to ResponseEntity
        /// </summary>
        /// <param name="entity">Entity to mapping</param>
        /// <returns>converted entity</returns>
        TResponse ToResponseDomain(TEntity entity);
        /// <summary>
        /// we can replace the two ToEntity methods with one 
        /// generic method that handles both TRequest and TUpdate using runtime
        /// </summary>
        /// <param name="request">EntityAddRequest</param>
        /// <returns>Model Entity</returns>
        TEntity ToEntity<TInput>(TInput input) where TInput : class;
    }
}
