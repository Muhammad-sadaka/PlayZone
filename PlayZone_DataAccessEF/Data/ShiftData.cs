using Microsoft.EntityFrameworkCore;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayZone_DataAccessEF.Data
{
    public static class ShiftData
    {
        public static async Task<List<ShiftDTO>> GetAllAsync()
        {
            using var context = new PlayZoneContext();
            return await context.Shifts
                .Select(s => new ShiftDTO(s.ShiftId, s.UserId, s.StartTime, s.EndTime, s.StartingCash, s.TotalSales, s.ExpectedCash, s.ActualCash))
                .ToListAsync();
        }

        public static async Task<ShiftDTO?> GetByIdAsync(int id)
        {
            using var context = new PlayZoneContext();
            var s = await context.Shifts.FindAsync(id);
            if (s == null) return null;
            return new ShiftDTO(s.ShiftId, s.UserId, s.StartTime, s.EndTime, s.StartingCash, s.TotalSales, s.ExpectedCash, s.ActualCash);
        }

        public static async Task<int?> AddAsync(ShiftDTO dto)
        {
            using var context = new PlayZoneContext();
            var shift = new Shift
            {
                UserId = dto.UserID,
                StartTime = dto.StartTime,
                EndTime = dto.EndTime,
                StartingCash = dto.StartingCash,
                TotalSales = dto.TotalSales,
                ExpectedCash = dto.ExpectedCash,
                ActualCash = dto.ActualCash
            };

            await context.Shifts.AddAsync(shift);
            await context.SaveChangesAsync();
            return shift.ShiftId;
        }

        public static async Task<bool> UpdateAsync(ShiftDTO dto)
        {
            using var context = new PlayZoneContext();
            var existing = await context.Shifts.FindAsync(dto.ShiftID);
            if (existing == null) return false;

            existing.UserId = dto.UserID;
            existing.StartTime = dto.StartTime;
            existing.EndTime = dto.EndTime;
            existing.StartingCash = dto.StartingCash;
            existing.TotalSales = dto.TotalSales;
            existing.ExpectedCash = dto.ExpectedCash;
            existing.ActualCash = dto.ActualCash;

            context.Shifts.Update(existing);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            using var context = new PlayZoneContext();
            var shift = await context.Shifts.FindAsync(id);
            if (shift == null) return false;

            context.Shifts.Remove(shift);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            using var context = new PlayZoneContext();
            return await context.Shifts.AnyAsync(s => s.ShiftId == id);
        }
    }
}