using System.Linq.Expressions;

namespace Core.Domain.RepositoryContacts
{
    /// <summary>
    /// Base repository service to connect database
    /// </summary>
    /// <typeparam name="TEntity">model entity</typeparam>
    public interface IBaseRespository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Get All Object store in list
        /// </summary>
        /// <returns>list of objects</returns>
        List<TEntity> GetAll();
        /// <summary>
        /// given object based on matches by id
        /// </summary>
        /// <param name="predicate">expressin to matches object list</param>
        /// <returns></returns>
        TEntity? Get(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// get all of object matches by id
        /// </summary>
        /// <param name="predicate">expressin to matches object list</param>
        /// <returns></returns>
        List<TEntity>? GetMany(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// Add new object into list
        /// </summary>
        /// <param name="number">object to add</param>
        /// <returns></returns>
        TEntity Add(TEntity entity);
        /// <summary>
        /// Update object based on given object for new data
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        TEntity Update(TEntity entity);
        /// <summary>
        /// Delete object base on id
        /// </summary>
        /// <param name="id">search object</param>
        /// <returns>true id delete successful</returns>
        bool DeleteById(int? id);
    }
}
