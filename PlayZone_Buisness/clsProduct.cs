using PlayZone_DataAccessEF.Data;
using SharedDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayZone_Buisness
{
    public class clsProduct
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public ProductDTO Dto => new ProductDTO(this.ProductID, this.ProductName, this.Price, this.StockQuantity, this.ImagePath);

        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? StockQuantity { get; set; }
        public string ImagePath { get; set; }

        public clsProduct()
        {
            ProductID = -1;
            ProductName = string.Empty;
            Price = 0;
            StockQuantity = 0;
            ImagePath = string.Empty;
            Mode = enMode.AddNew;
        }

        private clsProduct(ProductDTO dto, enMode mode = enMode.Update)
        {
            ProductID = dto.ProductID;
            ProductName = dto.ProductName;
            Price = dto.Price;
            StockQuantity = dto.StockQuantity;
            ImagePath = dto.ImagePath;
            Mode = mode;
        }

        private async Task<bool> _AddNewProductAsync()
        {
            this.ProductID = await ProductData.AddAsync(this.Dto);
            return (this.ProductID != -1);
        }

        private async Task<bool> _UpdateProductAsync()
        {
            return await ProductData.UpdateAsync(this.Dto);
        }

        public static async Task<clsProduct?> FindByIDAsync(int productID)
        {
            ProductDTO? dto = await ProductData.GetByIdAsync(productID);

            if (dto != null)
                return new clsProduct(dto, enMode.Update);
            else
                return null;
        }

        public async Task<bool> SaveAsync()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewProductAsync())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return await _UpdateProductAsync();
            }
            return false;
        }

        public static async Task<List<ProductDTO>> GetAllProductsAsync()
        {
            return await ProductData.GetAllAsync();
        }

        public static async Task<bool> DeleteProductAsync(int productID)
        {
            return await ProductData.DeleteAsync(productID);
        }

        public static async Task<bool> IsProductExistAsync(int productID)
        {
            return await ProductData.ExistsAsync(productID);
        }
    }
}