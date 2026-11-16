using Microsoft.EntityFrameworkCore;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PlayZone_DataAccessEF.Data
{
    public static class SpotData
    {
        public static async Task<List<SpotDTO>> GetAllAsync()
        {
            using var context = new PlayZoneContext();
            return await context.Spots
                .Select(s => new SpotDTO(s.SpotId, s.SpotName, s.SpotTypeId,s.Active))
                .ToListAsync();
        }

        public static async Task<SpotDTO?> GetByIdAsync(int id)
        {
            using var context = new PlayZoneContext();
            var s = await context.Spots.FindAsync(id);
            if (s == null) return null;
            return new SpotDTO(s.SpotId, s.SpotName, s.SpotTypeId,s.Active);
        }


        public static async Task<SpotDTO?> GetBySpotNameAsync(string spotName)
        {
            using var context = new PlayZoneContext();

            var s = await context.SpotTypes.Join(context.Spots,
                          spotType => spotType.SpotTypeId,
                          spot => spot.SpotTypeId,
                          (spotType, spot) => new
                          {
                              spot.SpotId,
                              spot.SpotName,
                              spot.SpotTypeId,
                              spot.Active,
                              spotType.SpotTypeName,
                              spotType.PricePerHour,
                              spotType.Image
                          }).Where(spot => spot.SpotName == spotName).FirstOrDefaultAsync();


            if (s == null) return null;
            return new SpotDTO(s.SpotId, s.SpotName, s.SpotTypeId,s.Active,s.SpotTypeName,s.PricePerHour,s.Image);
        }

        //public static async Task<SpotDTO?> GetBySpotNameAsync(string spotName)
        //{
        //    using var context = new PlayZoneContext();

        //    var s = await context.Spots
        //        .Where(spot => spot.SpotName == spotName)
        //        .Join(context.SpotTypes,
        //              spot => spot.SpotTypeId,        
        //              spotType => spotType.SpotTypeId,
        //              (spot, spotType) => new
        //              {
        //                  spot.SpotId,
        //                  spot.SpotName,
        //                  spot.SpotTypeId,
        //                  spotType.SpotTypeName,
        //                  spotType.PricePerHour,
        //                  spotType.Image
        //              })
        //        .FirstOrDefaultAsync();

        //    if (s == null) return null;
        //    return new SpotDTO(s.SpotId, s.SpotName, s.SpotTypeId, s.SpotTypeName, s.PricePerHour, s.Image);
        //}

        public static async Task<int?> AddAsync(SpotDTO dto)
        {
            using var context = new PlayZoneContext();
            var spot = new Spot
            {
                SpotName = dto.SpotName,
                SpotTypeId = dto.SpotTypeId
            };

            await context.Spots.AddAsync(spot);
            await context.SaveChangesAsync();
            return spot.SpotId;
        }

        public static async Task<bool> UpdateAsync(SpotDTO dto)
        {
            using var context = new PlayZoneContext();
            var existing = await context.Spots.FindAsync(dto.SpotID);
            if (existing == null) return false;

            existing.SpotName = dto.SpotName;
            existing.SpotTypeId = dto.SpotTypeId;

            context.Spots.Update(existing);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            using var context = new PlayZoneContext();
            var spot = await context.Spots.FindAsync(id);
            if (spot == null) return false;

            context.Spots.Remove(spot);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            using var context = new PlayZoneContext();
            return await context.Spots.AnyAsync(s => s.SpotId == id);
        }

        public static async Task<bool> UpdateSpotTypeAsync(int spotId, int spotTypeId,bool active)
        {
            using var context = new PlayZoneContext();
            var existing = await context.Spots.FindAsync(spotId);
            if (existing == null) return false;

            // لا حاجة لـ Update() لأن الكائن متتبَّع من الـ context
            existing.SpotTypeId = spotTypeId;
            existing.Active = active;
            await context.SaveChangesAsync();
            return true;
        }
    }
}