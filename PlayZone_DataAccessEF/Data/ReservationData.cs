using Microsoft.EntityFrameworkCore;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;

namespace PlayZone_DataAccessEF.Data
{
    public static class ReservationData
    {
        public static async Task<List<ReservationListDTO>> GetAllAsync()
        {
            using var context = new PlayZoneContext();
            return await context.Reservations
                .Select(r => new ReservationListDTO(
                    r.CustomerName,
                    r.StartDate,
                    r.EndDate,
                    r.Period,
                    Convert.ToInt32(r.TotalPrice),
                    r.SpotType.SpotTypeName,
                    Convert.ToInt32(r.SpotType.PricePerHour)
                ))
                .ToListAsync();
        }

        public static async Task<ReservationDTO?> GetByIdAsync(int id)
        {
            using var context = new PlayZoneContext();
            var r = await context.Reservations
                .Include(res => res.SpotType)
                .FirstOrDefaultAsync(res => res.ReservationId == id);

            if (r == null) return null;

            return new ReservationDTO(
                r.ReservationId,
                r.CustomerName,
                r.StartDate,
                r.EndDate,
                r.Period,
                r.TotalPrice,
                r.SpotTypeId,
                r.SpotType?.SpotTypeName,
                r.SpotType?.PricePerHour ?? 0
            );
        }

        public static async Task<int> AddAsync(ReservationDTO dto)
        {
            using var context = new PlayZoneContext();
            var reservation = new Reservation
            {
                CustomerName = dto.CustomerName,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Period = dto.Period,
                TotalPrice = dto.TotalPrice,
                SpotTypeId = dto.SpotTypeId
            };

            await context.Reservations.AddAsync(reservation);
            await context.SaveChangesAsync();
            return reservation.ReservationId;
        }

        public static async Task<bool> UpdateAsync(ReservationDTO dto)
        {
            using var context = new PlayZoneContext();
            var existing = await context.Reservations.FindAsync(dto.ReservationId);
            if (existing == null) return false;

            existing.CustomerName = dto.CustomerName;
            existing.StartDate = dto.StartDate;
            existing.EndDate = dto.EndDate;
            existing.Period = dto.Period;
            existing.TotalPrice = dto.TotalPrice;
            existing.SpotTypeId = dto.SpotTypeId;

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