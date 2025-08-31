using Core.Domain.Entities;
using System;
using System.Net;

namespace Core.DTO.Request
{
    /// <summary>
    /// Seat Request DTO model
    /// </summary>
    public class SeatAddRequest
    {
        public int HallId { get; set; }
        public int SeatNo { get; set; }
        public int SeatRow { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsVip { get; set; }
        public decimal ExtraPrice { get; set; }

        public SeatAddRequest DeepCopy()
        {
            
            SeatAddRequest newRequest = (SeatAddRequest)this.MemberwiseClone();

            return newRequest;
        }

    }
}
