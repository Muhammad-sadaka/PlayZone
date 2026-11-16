using PlayZone_DataAccessEF.Data;
using SharedDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayZone_Buisness
{
    public class clsRole
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public RoleDTO Dto => new RoleDTO(this.RoleID, this.RoleName);

        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public clsRole()
        {
            RoleID = -1;
            RoleName = string.Empty;
            Mode = enMode.AddNew;
        }

        private clsRole(RoleDTO dto, enMode mode = enMode.Update)
        {
            RoleID = dto.RoleID;
            RoleName = dto.RoleName;
            Mode = mode;
        }

        private async Task<bool> _AddNewRoleAsync()
        {
            var newId = await RoleData.AddAsync(this.Dto);
            if (newId.HasValue)
            {
                this.RoleID = newId.Value;
                return true;
            }
            return false;
        }

        private async Task<bool> _UpdateRoleAsync()
        {
            return await RoleData.UpdateAsync(this.Dto);
        }

        public static async Task<clsRole?> FindByIDAsync(int roleID)
        {
            RoleDTO? dto = await RoleData.GetByIdAsync(roleID);

            if (dto != null)
                return new clsRole(dto, enMode.Update);
            else
                return null;
        }

        public async Task<bool> SaveAsync()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewRoleAsync())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return await _UpdateRoleAsync();
            }
            return false;
        }

        public static async Task<List<RoleDTO>> GetAllRolesAsync()
        {
            return await RoleData.GetAllAsync();
        }

        public static async Task<bool> DeleteRoleAsync(int roleID)
        {
            return await RoleData.DeleteAsync(roleID);
        }

        public static async Task<bool> IsRoleExistAsync(int roleID)
        {
            return await RoleData.ExistsAsync(roleID);
        }
    }
}