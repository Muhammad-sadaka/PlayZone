using PlayZone_DataAccessEF.Data;
using SharedDTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayZone_Buisness
{
    public class clsReservation
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int ReservationID { set; get; }
        public string CustomerName { set; get; }
        public DateTime? StartDate { set; get; }
        public DateTime? EndDate { set; get; }
        public TimeSpan? Period { set; get; }
        public decimal? TotalPrice { set; get; }
        public int SpotTypeID { set; get; }

        public ReservationDTO Dto => new ReservationDTO(
            this.ReservationID,
            this.CustomerName,
            this.StartDate,
            this.EndDate,
            this.Period,
            this.TotalPrice,
            this.SpotTypeID,
            string.Empty, // اسم نوع البقعة يتم جلبه تلقائياً في الاستعلامات المركبة
            0
        );



        public clsReservation()
        {
            this.ReservationID = 0;
            this.CustomerName = string.Empty;
            this.StartDate = null;
            this.EndDate = null;
            this.Period = null;
            this.TotalPrice = null;
            this.SpotTypeID = 0;

            Mode = enMode.AddNew;
        }

        private clsReservation(ReservationDTO dto, enMode mode = enMode.Update)
        {
            this.ReservationID = dto.ReservationId;
            this.CustomerName = dto.CustomerName;
            this.StartDate = dto.StartDate;
            this.EndDate = dto.EndDate;
            this.Period = dto.Period;
            this.TotalPrice = dto.TotalPrice;
            this.SpotTypeID = dto.SpotTypeId;

            Mode = mode;
        }

        private async Task<bool> _AddNewReservationAsync()
        {
            this.ReservationID = await ReservationData.AddAsync(this.Dto);
            return (this.ReservationID > 0);
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

        public static async Task<List<ReservationListDTO>> GetAllReservationsAsync()
        {
            return await ReservationData.GetAllAsync();
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