using Microsoft.EntityFrameworkCore;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace PlayZone_DataAccessEF.Data
{
    public static class ReservationData
    {
        public static async Task<List<ReservationListDTO>> GetAllAsync()
        {
            using var context = new PlayZoneContext();

            var report =
            from r in context.Reservations
            join sh in context.Shifts on r.ShiftId equals sh.ShiftId
            join s in context.Spots on r.SpotId equals s.SpotId
            join st in context.SpotTypes on s.SpotTypeId equals st.SpotTypeId
            select new ReservationListDTO
            (
                 r.ReservationId,
                 r.CustomerName,
                 st.SpotTypeName,
                 s.SpotName,
                 r.StartDate,
                 r.EndDate,
                 r.Period,
                 r.TotalPrice
            );
            return await report.ToListAsync();
        }

        public static async Task<ReservationDTO?> GetByIdAsync(int id)
        {
            using var context = new PlayZoneContext();
            var r = await context.Reservations.FindAsync(id);
            if (r == null) return null;
            return new ReservationDTO(r.ReservationId, r.CustomerName, r.StartDate, r.EndDate, r.Period,r.SessionRevenue,r.SessionRevenue, r.TotalPrice, r.SpotId,r.ShiftId);
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
                SessionRevenue = dto.SessionRevenue,
                CafeteriaRevenue = dto.CafeteriaRevenue,
                TotalPrice = dto.TotalPrice,
                SpotId = dto.SpotID,
                ShiftId = dto.ShiftID
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
            existing.SessionRevenue = dto.SessionRevenue;
            existing.CafeteriaRevenue = dto.CafeteriaRevenue;
            existing.TotalPrice = dto.TotalPrice;
            existing.SpotId = dto.SpotID;
            existing.ShiftId = dto.ShiftID;

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

        public static async Task<decimal> TotalReservationPerShiftAsync(int shiftID)
        {
            using var context = new PlayZoneContext();

            return await context.Reservations
                .Where(r => r.ShiftId == shiftID)
                .SumAsync(r => (decimal?)r.TotalPrice) ?? 0m;
        }
    }
}