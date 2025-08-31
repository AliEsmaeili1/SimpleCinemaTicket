using Core.Domain.Entities;
using Core.Domain.RepositoryContacts;
using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
namespace Core.BusinessLogicContracts
{
    /// <summary>
    /// Cinema Service Contracts
    /// </summary>
    public interface ICinemaServiceContracts
        :IBaseServiceContracts<CinemaAddRequst, CinemaResponse, CinemUpdateRequest>
    {
        bool ValidCinema(int cinemaId);
    }
}
