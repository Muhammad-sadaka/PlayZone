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
        public static async Task<List<ShiftsListDTO>> GetAllAsync()
        {
            using var context = new PlayZoneContext();

             var report =
            from s in context.Shifts
            join u in context.Users
                on s.UserId equals u.UserId
                into ShiftGroup
                from u in ShiftGroup
            select new ShiftsListDTO
            (
                s.ShiftId,
                u.Username,
                s.StartTime,
                s.EndTime,
                s.StartingCash,
                s.ActualCash,
                s.ExpectedCash,
                s.ExpectedCash - s.StartingCash + s.TotalSales 
            );
             return await report.ToListAsync();
        }

        public static async Task<List<SalesListDTO>> GetAllSalesAndIncomeAsync()
        {
            //SalesListDTO
            using var context = new PlayZoneContext();
            return null;
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

        public static async Task<ShiftSummaryDTO?> GetSummaryAsync(int shiftId)
        {
            using var context = new PlayZoneContext();

            // الخطوة 1: مجموع الجلسات لكل وردية (كأنه CTE)
            var sessionsPerShift =
                from r in context.Reservations
                where r.EndDate != null
                group r by r.ShiftId into g
                select new { ShiftId = g.Key, Revenue = g.Sum(x => x.TotalPrice) };

            // الخطوة 2: مجموع الكافتيريا لكل وردية
            var cafeteriaPerShift =
                from rp in context.ReservationProducts
                join r in context.Reservations on rp.ReservationId equals r.ReservationId
                group rp by r.ShiftId into g
                select new { ShiftId = g.Key, Revenue = g.Sum(x => x.TotalPrice) };

            // الخطوة 3: الربط (LEFT JOIN = into + DefaultIfEmpty)
            var query =
                from s in context.Shifts
                where s.ShiftId == shiftId
                join u in context.Users on s.UserId equals u.UserId
                join sp in sessionsPerShift on s.ShiftId equals sp.ShiftId into spGroup
                from sp in spGroup.DefaultIfEmpty()
                join cp in cafeteriaPerShift on s.ShiftId equals cp.ShiftId into cpGroup
                from cp in cpGroup.DefaultIfEmpty()
                select new ShiftSummaryDTO
                {
                    ShiftID = s.ShiftId,
                    CashierName = u.Username,
                    StartTime = s.StartTime,
                    StartingCash = s.StartingCash,
                    SessionsRevenue = sp == null ? 0m : (sp.Revenue ?? 0m),
                    CafeteriaRevenue = cp == null ? 0m : cp.Revenue
                };

            return await query.FirstOrDefaultAsync();
        }
        //public static async Task<ShiftSummaryDTO?> GetSummaryAsync(int shiftId)
        //{
        //    using var context = new PlayZoneContext();

        //    // 1) الوردية + الكاشير (LEFT JOIN على المستخدم حتى لا تختفي الوردية)
        //    var shift = await (
        //        from s in context.Shifts
        //        where s.ShiftId == shiftId
        //        join u in context.Users on s.UserId equals u.UserId into uGroup
        //        from u in uGroup.DefaultIfEmpty()
        //        select new
        //        {
        //            s.ShiftId,
        //            s.StartTime,
        //            s.StartingCash,
        //            CashierName = u == null ? "Unknown" : u.Username
        //        }).FirstOrDefaultAsync();

        //    if (shift == null) return null;

        //    // 2) إيراد الجلسات: نحوّل إلى decimal? ثم ?? 0 فلا يفشل عند عدم وجود صفوف
        //    decimal sessions = await context.Reservations
        //        .Where(r => r.ShiftId == shiftId && r.EndDate != null)
        //        .SumAsync(r => (decimal?)r.TotalPrice) ?? 0m;

        //    // 3) إيراد الكافتيريا
        //    decimal cafeteria = await (
        //        from rp in context.ReservationProducts
        //        join r in context.Reservations on rp.ReservationId equals r.ReservationId
        //        where r.ShiftId == shiftId
        //        select (decimal?)(rp.Quantity * rp.UnitPrice))
        //        .SumAsync() ?? 0m;

        //    return new ShiftSummaryDTO(shift.ShiftId, shift.CashierName,
        //        shift.StartTime, shift.StartingCash, sessions, cafeteria);
        //}
    }
}