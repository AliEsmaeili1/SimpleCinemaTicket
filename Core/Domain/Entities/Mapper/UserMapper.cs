using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert User Entity to Response for DTO
    /// </summary>
    public class UserMapper : IMapper<User, UserResponse>
    {

        public User ToEntity<TInput>(TInput input) where TInput : class
        {
            return input switch
            {
                UserAddRequest request => new User()
                {
                    FullName = request.FullName,
                    Email = request.Email
                },
                UserUpdateRequest update => new User()
                {
                    Id = update.Id,
                    FullName = update.FullName,
                    Email = update.Email,
                },
                _=> throw new ArgumentException($"Unsupported input type: {typeof(TInput).Name}")
            };
        }

        public UserResponse ToResponseDomain(User entity)
        {
            return new UserResponse
            {
                Id = entity.Id,
                FullName = entity.FullName,
                Email = entity.Email
            };
        }
    }
}
