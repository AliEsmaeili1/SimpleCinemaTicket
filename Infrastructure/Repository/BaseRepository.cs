using Core.Domain.RepositoryContacts;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    /// <summary>
    /// Represent base service repositoryto connect database
    /// </summary>
    public abstract class BaseRepository<TEntity> : IBaseRespository<TEntity>
        where TEntity : class
    {
        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
        public TEntity? Get(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public bool DeleteById(int? id)
        {
            throw new NotImplementedException();
        }
        public TEntity Update(TEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
