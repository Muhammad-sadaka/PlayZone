using System.ComponentModel.DataAnnotations.Schema;

namespace SharedDTOs
{

    public class ReservationDTO
    {
        public int ReservationId { get; set; }

        [Column("Customer Name")]
        public string CustomerName { get; set; }

        [Column("Start Date")]
        public DateTime? StartDate { get; set; }

        [Column("End Date")]
        public DateTime? EndDate { get; set; }

        public TimeSpan? Period { get; set; }

        [Column("Total Price")]
        public decimal? TotalPrice { get; set; }

        public int SpotTypeId { get; set; }

        [Column("Spot Type")]
        public string SpotType { get; set; }

        [Column("Price Per Hour")]
        public decimal? PricePerHour { get; set; }

        public ReservationDTO() { }

        public ReservationDTO(int reservationId, string customerName, DateTime? startDate, DateTime? endDate, TimeSpan? period, decimal? totalPrice, int spotTypeId, string spotType, decimal? pricePerHour)
        {
            ReservationId = reservationId;
            CustomerName = customerName;
            StartDate = startDate;
            EndDate = endDate;
            Period = period;
            TotalPrice = totalPrice;
            SpotTypeId = spotTypeId;
            SpotType = spotType;
            PricePerHour = pricePerHour;
        }
    }
    public class ReservationListDTO
    {

        [Column("Customer Name")]
        public string CustomerName { get; set; }

        [Column("Start Date")]
        public DateTime? StartDate { get; set; }

        [Column("End Date")]
        public DateTime? EndDate { get; set; }

        public TimeSpan? Period { get; set; }

        [Column("Total Price")]
        public decimal? TotalPrice { get; set; }

        [Column("Spot Type")]
        public string SpotType { get; set; }

        [Column("Price Per Hour")]
        public decimal? PricePerHour { get; set; }
        public ReservationListDTO( string customerName, DateTime? startDate, DateTime? endDate, TimeSpan? period, decimal? totalPrice, string spotType, decimal? pricePerHour)
        {
            CustomerName = customerName;
            StartDate = startDate;
            EndDate = endDate;
            Period = period;
            TotalPrice = totalPrice;
            SpotType = spotType;
            PricePerHour = pricePerHour;
        }
    } 

}


