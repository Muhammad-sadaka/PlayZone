using PlayZone_DataAccessEF.Data;
using SharedDTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayZone_Buisness
{
    public class clsShift
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public ShiftDTO Dto => new ShiftDTO(this.ShiftID, this.UserID, this.StartTime, this.EndTime, this.StartingCash, this.TotalSales, this.ExpectedCash, this.ActualCash);
        

        public int? ShiftID { get; set; }
        public int? UserID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal StartingCash { get; set; }
        public decimal TotalSales { get; set; }
        public decimal ExpectedCash { get; set; }
        public decimal? ActualCash { get; set; }

        public clsShift()
        {
            ShiftID = -1;
            UserID = -1;
            StartTime = DateTime.Now;
            EndTime = null;
            StartingCash = 0;
            TotalSales = 0;
            ExpectedCash = 0;
            ActualCash = null;
            Mode = enMode.AddNew;
        }

        private clsShift(ShiftDTO dto, enMode mode = enMode.Update)
        {
            ShiftID = dto.ShiftID;
            UserID = dto.UserID;
            StartTime = dto.StartTime;
            EndTime = dto.EndTime;
            StartingCash = dto.StartingCash;
            TotalSales = dto.TotalSales;
            ExpectedCash = dto.ExpectedCash;
            ActualCash = dto.ActualCash;
            Mode = mode;
        }

        private async Task<bool> _AddNewShiftAsync()
        {
            this.ShiftID = await ShiftData.AddAsync(this.Dto);
            return (this.ShiftID != -1);
        }

        private async Task<bool> _UpdateShiftAsync()
        {
            return await ShiftData.UpdateAsync(this.Dto);
        }

        public static async Task<clsShift?> FindByIDAsync(int shiftID)
        {
            ShiftDTO? dto = await ShiftData.GetByIdAsync(shiftID);

            if (dto != null)
                return new clsShift(dto, enMode.Update);
            else
                return null;
        }

        public static async Task<ShiftSummaryDTO?> GetSummaryAsync(int shiftID)
        {
            return await ShiftData.GetSummaryAsync(shiftID);
        }

        public async Task<bool> SaveAsync()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewShiftAsync())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return await _UpdateShiftAsync();
            }
            return false;
        }

        public static async Task<List<ShiftsListDTO>> GetAllShiftsAsync()
        {
            return await ShiftData.GetAllAsync();
        }

        public static async Task<List<SalesListDTO>> GetAllSalesAndIncomeAsync()
        {
            return await ShiftData.GetAllSalesAndIncomeAsync();
        }
        
        public static async Task<bool> DeleteShiftAsync(int shiftID)
        {
            return await ShiftData.DeleteAsync(shiftID);
        }

        public static async Task<bool> IsShiftExistAsync(int shiftID)
        {
            return await ShiftData.ExistsAsync(shiftID);
        }

        public static async Task<clsShift?> OpenNewShiftAsync(int userID, decimal startingCash)
        {
            clsShift shift = new clsShift
            {
                UserID = userID,
                StartingCash = startingCash,
                StartTime = DateTime.Now,
                TotalSales = 0,
                ExpectedCash = startingCash,
                Mode = enMode.AddNew
            };

            if (await shift.SaveAsync())
            {
                return shift;
            }

            return null;
        }

        public static async Task<bool> CloseShiftAsync(int shiftID,decimal closingCash)
        {
            clsShift shift = await clsShift.FindByIDAsync(shiftID);
            shift.ActualCash = closingCash;
            shift.EndTime = DateTime.Now;
            shift.TotalSales = await clsReservation.TotalReservationPerShiftAsync(shiftID);

            if (await shift.SaveAsync())
            {
                return true;
            }

            return false;
        }
    }
}