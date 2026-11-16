using System.ComponentModel.DataAnnotations.Schema;

namespace SharedDTOs
{
    public class ReservationProductDTO
    {
        [Column("Order Product ID")]
        public int? OrderProductID { set; get; }

        [Column("Reservation ID")]
        public int? ReservationID { set; get; }

        [Column("Product ID")]
        public int? ProductID { set; get; }

        [Column("Quantity")]
        public int Quantity { set; get; }

        [Column("Total Price")]
        public decimal TotalPrice { set; get; }

        public ReservationProductDTO(int? orderProductID, int? reservationID, int? productID, int quantity, decimal totalPrice)
        {
            OrderProductID = orderProductID;
            ReservationID = reservationID;
            ProductID = productID;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }
    }
}