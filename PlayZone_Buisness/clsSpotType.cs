using PlayZone_DataAccessEF.Data;
using SharedDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayZone_Buisness
{
    public class clsSpotType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public SpotTypeDTO Dto => new SpotTypeDTO(this.SpotTypeID, this.SpotTypeName, this.PricePerHour, this.ImagePath);

        public int? SpotTypeID { get; set; }
        public string SpotTypeName { get; set; }
        public decimal? PricePerHour { get; set; }
        public string ImagePath { get; set; }

        public clsSpotType()
        {
            SpotTypeID = -1;
            SpotTypeName = string.Empty;
            PricePerHour = 0;
            ImagePath = string.Empty;
            Mode = enMode.AddNew;
        }

        private clsSpotType(SpotTypeDTO dto, enMode mode = enMode.Update)
        {
            SpotTypeID = dto.SpotTypeID;
            SpotTypeName = dto.SpotTypeName;
            PricePerHour = dto.PricePerHour;
            ImagePath = dto.ImagePath;
            Mode = mode;
        }

        private async Task<bool> _AddNewSpotTypeAsync()
        {
            this.SpotTypeID = await SpotTypeData.AddAsync(this.Dto);
            return (this.SpotTypeID != -1);
        }

        private async Task<bool> _UpdateSpotTypeAsync()
        {
            return await SpotTypeData.UpdateAsync(this.Dto);
        }

        public static async Task<clsSpotType?> FindByIDAsync(int spotTypeID)
        {
            SpotTypeDTO? dto = await SpotTypeData.GetByIdAsync(spotTypeID);

            if (dto != null)
                return new clsSpotType(dto, enMode.Update);
            else
                return null;
        }

        public async Task<bool> SaveAsync()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewSpotTypeAsync())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return await _UpdateSpotTypeAsync();
            }
            return false;
        }

        public static async Task<List<SpotTypeDTO>> GetAllSpotTypesAsync()
        {
            return await SpotTypeData.GetAllAsync();
        }

        public static async Task<bool> DeleteSpotTypeAsync(int spotTypeID)
        {
            return await SpotTypeData.DeleteAsync(spotTypeID);
        }

        public static async Task<bool> IsSpotTypeExistAsync(int spotTypeID)
        {
            return await SpotTypeData.ExistsAsync(spotTypeID);
        }
    }
}

///how to use the clsSpotType class in an ASP.NET Core Web API controller:
//[ApiController]
//[Route("api/[controller]")]
//public class SpotTypesController : ControllerBase
//{
//    private readonly SpotTypeData _spotTypeData;

//    public SpotTypesController(SpotTypeData spotTypeData)
//    {
//        _spotTypeData = spotTypeData; // يتم حقنها تلقائياً من الـ Program.cs
//    }

//    [HttpGet]
//    public async Task<IActionResult> GetAll()
//    {
//        var list = await clsSpotType.GetAllSpotTypesAsync(_spotTypeData);
//        return Ok(list);
//    }
//}