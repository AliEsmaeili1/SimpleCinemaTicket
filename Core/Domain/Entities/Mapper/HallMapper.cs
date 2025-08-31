using Core.DTO.Request;
using Core.DTO.Response;
using Core.DTO.Update;
using System;

namespace Core.Domain.Entities.Mapper
{
    /// <summary>
    /// Represent Convert Hall Entity to Response for DTO
    /// </summary>
    public class HallMapper : IMapper<Hall, HallResponse>
    {
        public Hall ToEntity<TInput>(TInput input) where TInput : class
        {
            return input switch
            {
                HallAddRequest request => new Hall()
                {
                    CinemaId = request.CinemaId,
                    Capacity = request.Capacity
                },
                HallUpdateRequest update => new Hall()
                {
                    Id = update.Id,
                    CinemaId = update.CinemaId,
                    Capacity = update.Capacity
                },
                _ => throw new ArgumentException($"Unsupported input type: {typeof(TInput).Name}")
            };
        }

        public HallResponse ToResponseDomain(Hall entity)
        {
            return new HallResponse
            {
                Id = entity.Id,
                Capacity = entity.Capacity,
                CinemaId = entity.CinemaId,
                ShowTimes = entity.ShowTimes,
                Seats = entity.Seats
            };
        }
    }
}
