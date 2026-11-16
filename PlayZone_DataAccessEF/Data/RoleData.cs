using Microsoft.EntityFrameworkCore;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayZone_DataAccessEF.Data
{
    public static class RoleData
    {
        public static async Task<List<RoleDTO>> GetAllAsync()
        {
            return await new PlayZoneContext().Roles
                .Where(r => r.RoleName != "Owner")
                .Select(r => new RoleDTO(r.RoleId, r.RoleName))
                .ToListAsync();
        }

        public static async Task<RoleDTO?> GetByIdAsync(int id)
        {
            using var context = new PlayZoneContext();
            var r = await context.Roles.FindAsync(id);
            if (r == null) return null;
            return new RoleDTO(r.RoleId, r.RoleName);
        }

        public static async Task<int?> AddAsync(RoleDTO dto)
        {
            using var context = new PlayZoneContext();
            var role = new Role
            {
                RoleName = dto.RoleName
            };

            await context.Roles.AddAsync(role);
            await context.SaveChangesAsync();
            return role.RoleId;
        }

        public static async Task<bool> UpdateAsync(RoleDTO dto)
        {
            using var context = new PlayZoneContext();
            var existing = await context.Roles.FindAsync(dto.RoleID);
            if (existing == null) return false;

            existing.RoleName = dto.RoleName;

            context.Roles.Update(existing);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            using var context = new PlayZoneContext();
            var role = await context.Roles.FindAsync(id);
            if (role == null) return false;

            context.Roles.Remove(role);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            using var context = new PlayZoneContext();
            return await context.Roles.AnyAsync(r => r.RoleId == id);
        }
    }
}