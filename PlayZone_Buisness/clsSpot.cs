using PlayZone_DataAccessEF.Data;
using PlayZone_DataAccessEF.Models;
using SharedDTOs;
using System.Collections.Generic;
using System.Management;
using System.Threading.Tasks;

namespace PlayZone_Buisness
{
    public class clsSpot
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public SpotDTO Dto => new SpotDTO(this.SpotID, this.SpotName, this.SpotTypeID,this.Active);

        public int? SpotID { get; set; }
        public string SpotName { get; set; }
        public int SpotTypeID { get; set; }
        public bool Active { get; set; }
        public clsSpotType SpotType { get; set; }

        public clsSpot()
        {
            SpotID = -1;
            SpotName = string.Empty;
            SpotTypeID = -1;
            Active = false;
            SpotType = null;
            Mode = enMode.AddNew;
        }

        private clsSpot(SpotDTO dto, clsSpotType spotType, enMode mode = enMode.Update)
        {
            SpotID = dto.SpotID;
            SpotName = dto.SpotName;
            SpotTypeID = dto.SpotTypeId;
            Active = dto.Active;
            SpotType = spotType;
            Mode = mode;
        }

        private async Task<bool> _AddNewSpotAsync()
        {
            this.SpotID = await SpotData.AddAsync(this.Dto);
            return (this.SpotID != -1);
        }

        private async Task<bool> _UpdateSpotAsync()
        {
            return await SpotData.UpdateAsync(this.Dto);
        }

        public static async Task<clsSpot?> FindByIDAsync(int spotID)
        {
            SpotDTO? dto = await SpotData.GetByIdAsync(spotID);

            if (dto != null)
            {
                clsSpotType? spotType = await clsSpotType.FindByIDAsync(dto.SpotTypeId);
                return new clsSpot(dto, spotType, enMode.Update);
            }
            else
                return null;
        }

        public static async Task<clsSpot?> FindBySpotNameAsync(string spotName)
        {
            SpotDTO? dto = await SpotData.GetBySpotNameAsync(spotName);

            if (dto != null)
            {
                clsSpotType? spotType = await clsSpotType.FindByIDAsync(dto.SpotTypeId);
                return new clsSpot(dto, spotType, enMode.Update);
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> SaveAsync()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewSpotAsync())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return await _UpdateSpotAsync();
            }
            return false;
        }

        public static async Task<List<SpotDTO>> GetAllSpotsAsync()
        {
            return await SpotData.GetAllAsync();
        }

        public static async Task<bool> DeleteSpotAsync(int spotID)
        {
            return await SpotData.DeleteAsync(spotID);
        }

        public static async Task<bool> IsSpotExistAsync(int spotID)
        {
            return await SpotData.ExistsAsync(spotID);
        }

        public static async Task<bool> UpdateSpotTypeAsync(int spotID, int spotTypeID,bool active)
        {
            return await SpotData.UpdateSpotTypeAsync(spotID, spotTypeID, active);
        }

    }
}