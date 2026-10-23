using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System.Data;
using System.Diagnostics;

namespace PlayZone_DataAccessEF.Data
{
    public static class SpotTypeData
    {
        public static async Task<List<SpotTypeDTO>> GetAllAsync()
        {
            using var context = new PlayZoneContext();
            return await context.SpotTypes
                .Select(s => new SpotTypeDTO(s.SpotTypeId, s.SpotTypeName, (int)s.PricePerHour, s.Image))
                .ToListAsync();
        }

        public static async Task<SpotTypeDTO?> GetByIdAsync(int id)
        {
            using var context = new PlayZoneContext();
            var s = await context.SpotTypes.FindAsync(id);
            if (s == null) return null;
            return new SpotTypeDTO(s.SpotTypeId, s.SpotTypeName, s.PricePerHour, s.Image);
        }

        public static async Task<int?> AddAsync(SpotTypeDTO dto)
        {
            using var context = new PlayZoneContext();
            var spotType = new SpotType
            {
                SpotTypeName = dto.SpotTypeName,
                PricePerHour = dto.PricePerHour,
                Image = dto.ImagePath
            };

            await context.SpotTypes.AddAsync(spotType);
            await context.SaveChangesAsync();
            return spotType.SpotTypeId;
        }

        public static async Task<bool> UpdateAsync(SpotTypeDTO dto)
        {
            using var context = new PlayZoneContext();
            var existing = await context.SpotTypes.FindAsync(dto.SpotTypeID);
            if (existing == null) return false;

            existing.SpotTypeName = dto.SpotTypeName;
            existing.PricePerHour = dto.PricePerHour;
            existing.Image = dto.ImagePath;

            context.SpotTypes.Update(existing);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            using var context = new PlayZoneContext();
            var spotType = await context.SpotTypes.FindAsync(id);
            if (spotType == null) return false;

            context.SpotTypes.Remove(spotType);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            using var context = new PlayZoneContext();
            return await context.SpotTypes.AnyAsync(s => s.SpotTypeId == id);
        }
    }
}