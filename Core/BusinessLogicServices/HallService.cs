using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class HallService: 
        BaseService<Hall, HallAddRequest, HallResponse, HallUpdateRequest>,
        IHallServiceContracts
    {
        public HallService(IMapper<Hall, HallResponse, HallAddRequest>mapper)
            : base(mapper) { }
    }
}
