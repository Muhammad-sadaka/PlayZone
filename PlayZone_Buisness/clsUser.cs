using PlayZone_DataAccessEF.Data;
using SharedDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayZone_Buisness
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public UserDTO Dto => new UserDTO(this.UserID, this.Username, this.PasswordHash, this.RoleID ,this.IsActive);

        public int? UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int RoleID { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            UserID = -1;
            Username = string.Empty;
            PasswordHash = string.Empty;
            RoleID = -1;
            IsActive = false;
            Mode = enMode.AddNew;
        }

        private clsUser(UserDTO dto, enMode mode = enMode.Update)
        {
            UserID = dto.UserID;
            Username = dto.Username;
            PasswordHash = dto.PasswordHash;
            RoleID = dto.RoleID;
            IsActive = dto.IsActive;
            Mode = mode;
        }

        private async Task<bool> _AddNewUserAsync()
        {
            this.UserID = await UserData.AddAsync(this.Dto);
            return (this.UserID != -1);
        }

        private async Task<bool> _UpdateUserAsync()
        {
            return await UserData.UpdateAsync(this.Dto);
        }

        public static async Task<clsUser?> FindByIDAsync(int userID)
        {
            UserDTO? dto = await UserData.GetByIdAsync(userID);

            if (dto != null)
                return new clsUser(dto, enMode.Update);
            else
                return null;
        }

        public static async Task<clsUser?> FindByUsernameAsync(string username)
        {
            UserDTO? dto = await UserData.GetByUsernameAsync(username);

            if (dto != null)
                return new clsUser(dto, enMode.Update);
            else
                return null;
        }

        public async Task<bool> SaveAsync()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewUserAsync())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return await _UpdateUserAsync();
            }
            return false;
        }

        public static async Task<List<UsersListDTO>> GetAllUsersAsync()
        {
            return await UserData.GetAllAsync();
        }

        public static async Task<bool> DeleteUserAsync(int userID)
        {
            return await UserData.DeleteAsync(userID);
        }

        public static async Task<bool> IsUserExistAsync(int userID)
        {
            return await UserData.ExistsAsync(userID);
        }

        public static async Task<clsUser?> AuthenticateAsync(string username, string plainPassword)
        {
            clsUser? user = await FindByUsernameAsync(username);

            if (user == null)
                return null;

            if (BCrypt.Net.BCrypt.Verify(plainPassword, user.PasswordHash))
                return user;

            return null;
        }
    }
}