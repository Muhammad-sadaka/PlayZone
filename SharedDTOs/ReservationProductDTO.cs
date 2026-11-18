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

        [Column("Product Name")]
        public string? ProductName { set; get; }

        public ReservationProductDTO(int? orderProductID, int? reservationID, int? productID, int quantity, decimal totalPrice, string? productName)
        {
            OrderProductID = orderProductID;
            ReservationID = reservationID;
            ProductID = productID;
            Quantity = quantity;
            TotalPrice = totalPrice;
            ProductName = productName;
        }
    }

    public class ReservationProductListDTO
    {
        [Column("Order Product ID")]
        public int? OrderProductID { set; get; }

        [Column("Product Name")]
        public string? ProductName { set; get; }

        [Column("Quantity")]
        public int Quantity { set; get; }

        [Column("Total Price")]
        public decimal TotalPrice { set; get; }

        [Column("Unit Price")]
        public decimal UnitPrice { set; get; }
        public ReservationProductListDTO(int? orderProductID, string? productName, int quantity, decimal unitPrice, decimal totalPrice )
        {
            OrderProductID = orderProductID;
            UnitPrice = unitPrice;
            Quantity = quantity;
            TotalPrice = totalPrice;
            ProductName = productName;
        }
    }
    
}