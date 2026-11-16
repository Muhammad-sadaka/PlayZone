using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedDTOs
{
    public class ReservationDTO
    {
        [Column("Reservation ID")]
        public int? ReservationID { set; get; }

        [Column("Customer Name")]
        public string CustomerName { set; get; }

        [Column("Start Date")]
        public DateTime StartDate { set; get; }

        [Column("End Date")]
        public DateTime? EndDate { set; get; }

        [Column("Period")]
        public TimeSpan? Period { set; get; }

        [Column("Total Price")]
        public decimal? TotalPrice { set; get; }

        [Column("Spot Type ID")]
        public int? SpotTypeID { set; get; }

        [Column("Is Active")]
        public bool? IsActive { set; get; }

        public ReservationDTO(int? reservationID, string customerName, DateTime startDate, DateTime? endDate, TimeSpan? period, decimal? totalPrice, int? spotTypeID, bool? isActive)
        {
            ReservationID = reservationID;
            CustomerName = customerName;
            StartDate = startDate;
            EndDate = endDate;
            Period = period;
            TotalPrice = totalPrice;
            SpotTypeID = spotTypeID;
            IsActive = isActive;
        }
    }
}