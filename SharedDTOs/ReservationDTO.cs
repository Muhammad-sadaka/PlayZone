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
        
        [Column("Session Revenue")]
        public decimal? SessionRevenue { set; get; }

        [Column("Cafeteria Revenue")]
        public decimal? CafeteriaRevenue { set; get; }

        [Column("Total Price")]
        public decimal? TotalPrice { set; get; }

        [Column("Spot Type ID")]
        public int? SpotID { set; get; }

        [Column("ShiftID")]
        public int ShiftID { set; get; }

        public ReservationDTO(int? reservationID, string customerName, DateTime startDate, DateTime? endDate, TimeSpan? period, decimal? sessionRevenue, decimal? cafeteriaRevenue, decimal? totalPrice, int? spotID, int shiftID )
        {
            ReservationID = reservationID;
            CustomerName = customerName;
            StartDate = startDate;
            EndDate = endDate;
            Period = period;
            SessionRevenue = sessionRevenue;
            CafeteriaRevenue = cafeteriaRevenue;
            TotalPrice = totalPrice;
            SpotID = spotID;
            ShiftID = shiftID;
        }
    }

    public class ReservationListDTO
    {
        public int? ReservationID { set; get; }
        public string CustomerName { set; get; }
        public string SpotTypeName { set; get; }
        public string SpotNumber { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime? EndDate { set; get; }
        public TimeSpan? Period { set; get; }
        public decimal? TotalPrice { set; get; }

        public ReservationListDTO(int? reservationID, string customerName,string spotTypeName,string spotNumber, DateTime startDate, DateTime? endDate, TimeSpan? period, decimal? totalPrice)
        {
            ReservationID = reservationID;
            CustomerName = customerName;
            SpotTypeName = spotTypeName;
            SpotNumber = spotNumber;
            StartDate = startDate;
            EndDate = endDate;
            Period = period;
            TotalPrice = totalPrice;
        }
    }
}