using Microsoft.EntityFrameworkCore;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayZone_DataAccessEF.Data
{
    public static class ProductData
    {
        public static async Task<List<ProductDTO>> GetAllAsync()
        {
            using var context = new PlayZoneContext();
            return await context.Products
                .Select(p => new ProductDTO(p.ProductId, p.ProductName, p.Price, p.StockQuantity, p.Image))
                .ToListAsync();
        }

        public static async Task<ProductDTO?> GetByIdAsync(int id)
        {
            using var context = new PlayZoneContext();
            var p = await context.Products.FindAsync(id);
            if (p == null) return null;
            return new ProductDTO(p.ProductId, p.ProductName, p.Price, p.StockQuantity, p.Image);
        }

        public static async Task<int?> AddAsync(ProductDTO dto)
        {
            using var context = new PlayZoneContext();
            var product = new Product
            {
                ProductName = dto.ProductName,
                Price = dto.Price ?? 0,
                StockQuantity = dto.StockQuantity ?? 0,
                Image = dto.ImagePath
            };

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
            return product.ProductId;
        }

        public static async Task<bool> UpdateAsync(ProductDTO dto)
        {
            using var context = new PlayZoneContext();
            var existing = await context.Products.FindAsync(dto.ProductID);
            if (existing == null) return false;

            existing.ProductName = dto.ProductName;
            existing.Price = dto.Price ?? 0;
            existing.StockQuantity = dto.StockQuantity ?? 0;
            existing.Image = dto.ImagePath;

            context.Products.Update(existing);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            using var context = new PlayZoneContext();
            var product = await context.Products.FindAsync(id);
            if (product == null) return false;

            context.Products.Remove(product);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            using var context = new PlayZoneContext();
            return await context.Products.AnyAsync(p => p.ProductId == id);
        }
    }
}