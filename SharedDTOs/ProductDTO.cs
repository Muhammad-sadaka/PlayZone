using System.ComponentModel.DataAnnotations.Schema;

namespace SharedDTOs
{
    public class ProductDTO
    {
        [Column("Product ID")]
        public int? ProductID { set; get; }

        [Column("Product Name")]
        public string ProductName { set; get; }

        [Column("Price")]
        public decimal? Price { set; get; }

        [Column("Stock Quantity")]
        public int? StockQuantity { set; get; }

        public ProductDTO(int? ProductID, string ProductName, decimal? Price, int? StockQuantity)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
            this.StockQuantity = StockQuantity;
        }
    }
}