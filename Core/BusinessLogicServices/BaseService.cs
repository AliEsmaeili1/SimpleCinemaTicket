using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.DTO.Request;
using System.Reflection;

namespace Core.BusinessLogicServices
{
    public abstract class BaseService<TEntity, TRequest, TResponse, TUpdate> 
        : IBaseServiceContracts<TRequest, TResponse, TUpdate>
        where TEntity : class
        where TRequest : class
        where TResponse : class
        where TUpdate : class
    {
        private readonly IMapper<TEntity, TResponse, TRequest> _mapper;
        protected BaseService(IMapper<TEntity, TResponse, TRequest> mapper) :base()
        {
            _mapper = mapper;
        }

        public ICollection<TResponse> GetAll()
        {
            throw new NotImplementedException();
        }
        public TResponse GetById(int id)
        {
            throw new NotImplementedException();
        }
        public TResponse Add(TRequest request)
        {
            //Validation: if request is not null
            if(request is null)
                throw new ArgumentNullException(nameof(request));
            TEntity domainObject = _mapper.ToEntity(request);

            //Implement save to repository

            return _mapper.ToResponseDomain(domainObject);//(TResponse)(object)domainObject;
        }
        public TResponse Update(TUpdate update)
        {
            throw new NotImplementedException();
        }
        public TResponse DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
