using PlayZone_DataAccessEF.Data;
using SharedDTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayZone_Buisness
{
    public class clsReservation
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public ReservationDTO Dto => new ReservationDTO(this.ReservationID, this.CustomerName, this.StartDate, this.EndDate, this.Period, this.TotalPrice, this.SpotTypeID, this.IsActive);

        public int? ReservationID { get; set; }
        public string CustomerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TimeSpan? Period { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? SpotTypeID { get; set; }
        public bool? IsActive { get; set; }

        public clsReservation()
        {
            ReservationID = -1;
            CustomerName = string.Empty;
            StartDate = DateTime.Now;
            EndDate = null;
            Period = null;
            TotalPrice = 0;
            SpotTypeID = -1;
            IsActive = true;
            Mode = enMode.AddNew;
        }

        private clsReservation(ReservationDTO dto, enMode mode = enMode.Update)
        {
            ReservationID = dto.ReservationID;
            CustomerName = dto.CustomerName;
            StartDate = dto.StartDate;
            EndDate = dto.EndDate;
            Period = dto.Period;
            TotalPrice = dto.TotalPrice;
            SpotTypeID = dto.SpotTypeID;
            IsActive = dto.IsActive;
            Mode = mode;
        }

        private async Task<bool> _AddNewReservationAsync()
        {
            this.ReservationID = await ReservationData.AddAsync(this.Dto);
            return (this.ReservationID != -1);
        }

        private async Task<bool> _UpdateReservationAsync()
        {
            return await ReservationData.UpdateAsync(this.Dto);
        }

        public static async Task<clsReservation?> FindByIDAsync(int reservationID)
        {
            ReservationDTO? dto = await ReservationData.GetByIdAsync(reservationID);

            if (dto != null)
                return new clsReservation(dto, enMode.Update);
            else
                return null;
        }

        public async Task<bool> SaveAsync()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewReservationAsync())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return await _UpdateReservationAsync();
            }
            return false;
        }

        public static async Task<List<ReservationDTO>> GetAllReservationsAsync()
        {
            return await ReservationData.GetAllAsync();
        }

        public static async Task<List<ReservationDTO>> GetActiveReservationsAsync()
        {
            return await ReservationData.GetActiveReservationsAsync();
        }

        public static async Task<bool> DeleteReservationAsync(int reservationID)
        {
            return await ReservationData.DeleteAsync(reservationID);
        }

        public static async Task<bool> IsReservationExistAsync(int reservationID)
        {
            return await ReservationData.ExistsAsync(reservationID);
        }
    }
}