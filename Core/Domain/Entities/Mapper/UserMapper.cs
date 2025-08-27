using Core.DTO.Request;
using Core.DTO.Response;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert User Entity to Response for DTO
    /// </summary>
    public class UserMapper : IMapper<User, UserResponse, UserAddRequest>
    {

        public User ToEntity(UserAddRequest entity)
        {
            return new User
            {
                FullName = entity.FullName,
                Email = entity.Email
            };
        }
      
        public UserResponse ToResponseDomain(User entity)
        {
            return new UserResponse
            {
                FullName = entity.FullName,
                Email = entity.Email
            };
        }
    }
}
