using Core.Domain.Entities;

namespace Core.Domain.RepositoryContacts
{
    /// <summary>
    /// Domain Repository hall
    /// </summary>
    public interface IHallRepository : IBaseRespository<Hall> 
    {
        Hall? GetByIdAndShowTime(int hall_id);
    }

}
