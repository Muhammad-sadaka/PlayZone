using Microsoft.EntityFrameworkCore;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayZone_DataAccessEF.Data
{
    public static class ReservationData
    {
        public static async Task<List<ReservationDTO>> GetAllAsync()
        {
            using var context = new PlayZoneContext();
            return await context.Reservations
                .Select(r => new ReservationDTO(r.ReservationId, r.CustomerName, r.StartDate, r.EndDate, r.Period, r.TotalPrice, r.SpotTypeId, r.IsActive))
                .ToListAsync();
        }

        public static async Task<ReservationDTO?> GetByIdAsync(int id)
        {
            using var context = new PlayZoneContext();
            var r = await context.Reservations.FindAsync(id);
            if (r == null) return null;
            return new ReservationDTO(r.ReservationId, r.CustomerName, r.StartDate, r.EndDate, r.Period, r.TotalPrice, r.SpotTypeId, r.IsActive);
        }

        public static async Task<List<ReservationDTO>> GetActiveReservationsAsync()
        {
            using var context = new PlayZoneContext();
            return await context.Reservations
                .Where(r => r.IsActive.Value)
                .Select(r => new ReservationDTO(r.ReservationId, r.CustomerName, r.StartDate, r.EndDate, r.Period, r.TotalPrice, r.SpotTypeId, r.IsActive))
                .ToListAsync();
        }

        public static async Task<int?> AddAsync(ReservationDTO dto)
        {
            using var context = new PlayZoneContext();
            var reservation = new Reservation
            {
                CustomerName = dto.CustomerName,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Period = dto.Period,
                TotalPrice = dto.TotalPrice,
                SpotTypeId = dto.SpotTypeID,
                IsActive = dto.IsActive
            };

            await context.Reservations.AddAsync(reservation);
            await context.SaveChangesAsync();
            return reservation.ReservationId;
        }

        public static async Task<bool> UpdateAsync(ReservationDTO dto)
        {
            using var context = new PlayZoneContext();
            var existing = await context.Reservations.FindAsync(dto.ReservationID);
            if (existing == null) return false;

            existing.CustomerName = dto.CustomerName;
            existing.StartDate = dto.StartDate;
            existing.EndDate = dto.EndDate;
            existing.Period = dto.Period;
            existing.TotalPrice = dto.TotalPrice;
            existing.SpotTypeId = dto.SpotTypeID;
            existing.IsActive = dto.IsActive;

            context.Reservations.Update(existing);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            using var context = new PlayZoneContext();
            var reservation = await context.Reservations.FindAsync(id);
            if (reservation == null) return false;

            context.Reservations.Remove(reservation);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            using var context = new PlayZoneContext();
            return await context.Reservations.AnyAsync(r => r.ReservationId == id);
        }
    }
}