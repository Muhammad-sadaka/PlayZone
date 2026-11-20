using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.Data.SqlClient;

namespace PlayZone_DataAccessEF.Data
{
    public static class UserData
    {
        public static async Task<List<UsersListDTO>> GetAllAsync()
        {
            using var context = new PlayZoneContext();
            return await context.Roles.Join(context.Users,
                   Roles => Roles.RoleId,
                   Users => Users.RoleId,
                    (Roles, Users) => new UsersListDTO
                    (
                        Users.UserId,
                        Users.Username,
                        Roles.RoleName,
                        Users.IsActive
                    )
                ).ToListAsync();
        }

        public static async Task<UserDTO?> GetByIdAsync(int id)
        {
            using var context = new PlayZoneContext();
            var u = await context.Users.FindAsync(id);
            if (u == null) return null;
            return new UserDTO(u.UserId, u.Username, u.PasswordHash, u.RoleId ,u.IsActive);
        }

        //public static async Task<UserDTO?> GetByUsernameAsync(string username)
        //{
        //    var u = await new PlayZoneContext().Users.FirstOrDefaultAsync(x => x.Username == username);
        //    if (u == null) return null;
        //    return new UserDTO(u.UserId, u.Username, u.PasswordHash, u.RoleId, u.IsActive);
        //}

        public static async Task<UserDTO?> GetByUsernameAsync(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(AppContext.BaseDirectory, "appsettings.json"), optional: false, reloadOnChange: true)
                .Build().GetConnectionString("DefaultConnection")))
                {
                    using (SqlCommand command = new SqlCommand("[SP_GetUserByUserName]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", (object)username ?? DBNull.Value);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new UserDTO(
                                    reader["UserID"] == DBNull.Value ? null : (int?)reader["UserID"],
                                    reader["Username"] == DBNull.Value ? null : (string)reader["Username"],
                                    reader["PasswordHash"] == DBNull.Value ? null : (string)reader["PasswordHash"],
                                    reader["RoleID"] == DBNull.Value ? -1 : (int)reader["RoleID"],
                                    (bool)reader["IsActive"]
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public static async Task<int?> AddAsync(UserDTO dto)
        {
            using var context = new PlayZoneContext();
            var user = new User
            {
                Username = dto.Username,
                PasswordHash = dto.PasswordHash,
                RoleId = dto.RoleID,
                IsActive = dto.IsActive
            };

            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return user.UserId;
        }

        public static async Task<bool> UpdateAsync(UserDTO dto)
        {
            using var context = new PlayZoneContext();
            var existing = await context.Users.FindAsync(dto.UserID);
            if (existing == null) return false;

            existing.Username = dto.Username;
            existing.PasswordHash = dto.PasswordHash;
            existing.RoleId = dto.RoleID;
            existing.IsActive = dto.IsActive;

            context.Users.Update(existing);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            using var context = new PlayZoneContext();
            var user = await context.Users.FindAsync(id);
            if (user == null) return false;

            context.Users.Remove(user);
            return await context.SaveChangesAsync() > 0;
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            using var context = new PlayZoneContext();
            return await context.Users.AnyAsync(u => u.UserId == id);
        }
    }
}