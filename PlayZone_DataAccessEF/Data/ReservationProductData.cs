using Microsoft.EntityFrameworkCore;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayZone_DataAccessEF.Data
{
    public static class ReservationProductData
    {
        public static async Task<List<ReservationProductDTO>> GetAllAsync(int reservationId)
        {
            using var context = new PlayZoneContext();
            return await context.ReservationProducts
                .Where(rp => rp.ReservationId == reservationId)
                .Select(rp => new ReservationProductDTO(rp.OrderProductId, rp.ReservationId, rp.ProductId, rp.Quantity, rp.TotalPrice))
                .ToListAsync();
        }

        public static async Task<List<ReservationProductDTO>> GetByReservationIdAsync(int reservationId)
        {
            using var context = new PlayZoneContext();
            return await context.ReservationProducts
                .Where(rp => rp.ReservationId == reservationId)
                .Select(rp => new ReservationProductDTO(rp.OrderProductId, rp.ReservationId, rp.ProductId, rp.Quantity, rp.TotalPrice))
                .ToListAsync();
        }

        public static async Task<ReservationProductDTO?> GetByIdAsync(int id)
        {
            using var context = new PlayZoneContext();
            var rp = await context.ReservationProducts.FindAsync(id);
            if (rp == null) return null;
            return new ReservationProductDTO(rp.OrderProductId, rp.ReservationId, rp.ProductId, rp.Quantity, rp.TotalPrice);
        }

        public static async Task<int?> AddAsync(ReservationProductDTO dto)
        {
            using var context = new PlayZoneContext();
            var reservationProduct = new ReservationProduct
            {
                ReservationId = dto.ReservationID,
                ProductId = dto.ProductID,
                Quantity = dto.Quantity,
                TotalPrice = dto.TotalPrice
            };

            await context.ReservationProducts.AddAsync(reservationProduct);
            await context.SaveChangesAsync();
            return reservationProduct.OrderProductId;
        }

        public static async Task<bool> UpdateAsync(ReservationProductDTO dto)
        {
            using var context = new PlayZoneContext();
            var existing = await context.ReservationProducts.FindAsync(dto.OrderProductID);
            if (existing == null) return false;

            existing.ReservationId = dto.ReservationID;
            existing.ProductId = dto.ProductID;
            existing.Quantity = dto.Quantity;
            existing.TotalPrice = dto.TotalPrice;

            context.ReservationProducts.Update(existing);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            using var context = new PlayZoneContext();
            var rp = await context.ReservationProducts.FindAsync(id);
            if (rp == null) return false;

            context.ReservationProducts.Remove(rp);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            using var context = new PlayZoneContext();
            return await context.ReservationProducts.AnyAsync(rp => rp.OrderProductId == id);
        }
        ///new
        //public static async Task<List<ReservationProductDTO>> GetByReservationAsync(int reservationId)
        //{
        //    using var context = new PlayZoneContext();
        //    return await context.ReservationProducts
        //        .Where(r => r.ReservationId == reservationId)
        //        .Select(r => new ReservationProductDTO(
        //            r.ReservationProductId, r.ReservationId, r.ProductId,
        //            r.ProductName, r.Quantity, r.UnitPrice))
        //        .ToListAsync();
        //}

        //public static async Task<int?> AddAsync(ReservationProductDTO dto)
        //{
        //    using var context = new PlayZoneContext();
        //    var entity = new ReservationProduct
        //    {
        //        ReservationId = dto.ReservationID,
        //        ProductId = dto.ProductID,
        //        ProductName = dto.ProductName,
        //        Quantity = dto.Quantity,
        //        UnitPrice = dto.UnitPrice
        //    };

        //    await context.ReservationProducts.AddAsync(entity);
        //    await context.SaveChangesAsync();
        //    return entity.ReservationProductId;
        //}

      
        
    }
}