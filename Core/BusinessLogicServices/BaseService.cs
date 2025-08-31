using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Core.DTO.Request;
using System.Reflection;

namespace Core.BusinessLogicServices
{
    public abstract class BaseService<TEntity, TRequest, TResponse, TUpdate> 
        : IBaseServiceContracts<TRequest, TResponse, TUpdate>
        where TEntity : class, IEntity
        where TRequest : class
        where TResponse : class
        where TUpdate : class
    {
        protected readonly IMapper<TEntity, TResponse> _mapper;
        protected readonly IBaseRespository<TEntity> _repository;
        
        public BaseService
            (IMapper<TEntity, TResponse> mapper,
            IBaseRespository<TEntity> repository) 
            :base()
        {
            _mapper = mapper;
            _repository = repository;
        }

        public ICollection<TResponse> GetAll()
        {
            List<TEntity> result = _repository.GetAll();

            return result.Select(r => _mapper.ToResponseDomain(r)).ToList();
        }
        public TResponse GetById(int? id)
        {
            if(id is null)
                throw new ArgumentNullException("id");
            TEntity? entity = _repository.Get(item => item.Id == id);
            if(entity is null)
                throw new ArgumentNullException(nameof(entity));    
            return _mapper.ToResponseDomain(entity);
        }
        public TResponse Add(TRequest request)
        {
            //Validation: if request is not null
            if(request is null)
                throw new ArgumentNullException(nameof(request));
            TEntity entity = _mapper.ToEntity(request);

            _repository.Add(entity);
            
            return _mapper.ToResponseDomain(entity);//(TResponse)(object)domainObject;
        }
        public TResponse Update(TUpdate entityUpdate)
        {
            TEntity entity_to_update = _mapper.ToEntity(entityUpdate);
            if(entity_to_update is null)
                throw new ArgumentNullException(nameof (entity_to_update));
            TEntity entity_updated = _repository.Update(entity_to_update);

            return _mapper.ToResponseDomain(entity_updated);
        }
        public bool DeleteById(int? id)
        {
            if(id is null)
                throw new ArgumentNullException("id");
            return _repository.DeleteById(id);
        }
    }
}
