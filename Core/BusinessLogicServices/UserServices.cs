using Core.BusinessLogicContracts;
using Core.Domain.Entities;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.BusinessLogicServices
{
    public class UserServices: BaseService<User, UserAddRequest, UserResponse, UserUpdateRequest>
                               ,IUserServiceContracts
    {
        public UserServices(IMapper<User, UserResponse, UserAddRequest> mapper) : base(mapper) { }
    }
}
