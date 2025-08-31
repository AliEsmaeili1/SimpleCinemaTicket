using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Infrastructure.CinemaTicketDataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    /// <summary>
    /// Represent base service repositoryto connect database
    /// </summary>
    public abstract class BaseRepository<TEntity> : IBaseRespository<TEntity>
        where TEntity : class, IEntity
    {
        protected readonly CinemaTicketDBcontext _dbContext;
        protected BaseRepository(CinemaTicketDBcontext dbContext)
        {
            _dbContext = dbContext;
        }
        protected DbSet<TEntity> _dbSet => _dbContext.Set<TEntity>();
        protected IQueryable<TEntity> _query => _dbSet.AsQueryable();
        public List<TEntity> GetAll()
        {
            return _query.ToList<TEntity>();    
        }
        public TEntity? Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _query.FirstOrDefault(predicate);
        }

        public TEntity Add(TEntity entity)
        {
            _dbSet.Entry(entity).State = EntityState.Added;
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public bool DeleteById(int? id)
        {
            TEntity? entity = _query.FirstOrDefault(item => item.Id == id);
            if (entity is null) return false;
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
            return true;
        }
        public TEntity Update(TEntity entity)
        {
            /*_dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();*/
            var existingInstansiated = _dbSet.Local.FirstOrDefault(u => u.Id == entity.Id);
            if (existingInstansiated != null)
            {
                _dbSet.Entry(existingInstansiated).State = EntityState.Detached;
            }
            _dbSet.Attach(entity);
            _dbSet.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }

        public List<TEntity>? GetMany(Expression<Func<TEntity, bool>> predicate)
        {
            return _query.Where(predicate).ToList();
        }
    }
}
