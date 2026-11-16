using PlayZone_DataAccessEF.Data;
using SharedDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayZone_Buisness
{
    public class clsReservationProduct
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public ReservationProductDTO Dto => new ReservationProductDTO(this.OrderProductID, this.ReservationID, this.ProductID, this.Quantity, this.TotalPrice);

        public int? OrderProductID { get; set; }
        public int? ReservationID { get; set; }
        public int? ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public clsReservationProduct()
        {
            OrderProductID = -1;
            ReservationID = -1;
            ProductID = -1;
            Quantity = 0;
            TotalPrice = 0;
            Mode = enMode.AddNew;
        }

        private clsReservationProduct(ReservationProductDTO dto, enMode mode = enMode.Update)
        {
            OrderProductID = dto.OrderProductID;
            ReservationID = dto.ReservationID;
            ProductID = dto.ProductID;
            Quantity = dto.Quantity;
            TotalPrice = dto.TotalPrice;
            Mode = mode;
        }

        private async Task<bool> _AddNewReservationProductAsync()
        {
            this.OrderProductID = await ReservationProductData.AddAsync(this.Dto);
            return (this.OrderProductID != -1);
        }

        private async Task<bool> _UpdateReservationProductAsync()
        {
            return await ReservationProductData.UpdateAsync(this.Dto);
        }

        public static async Task<clsReservationProduct?> FindByIDAsync(int orderProductID)
        {
            ReservationProductDTO? dto = await ReservationProductData.GetByIdAsync(orderProductID);

            if (dto != null)
                return new clsReservationProduct(dto, enMode.Update);
            else
                return null;
        }

        public async Task<bool> SaveAsync()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewReservationProductAsync())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return await _UpdateReservationProductAsync();
            }
            return false;
        }

        public static async Task<List<ReservationProductDTO>> GetAllReservationProductsAsync(int reservationId)
        {
            return await ReservationProductData.GetAllAsync(reservationId);
        }

        public static async Task<List<ReservationProductDTO>> GetByReservationIdAsync(int reservationId)
        {
            return await ReservationProductData.GetByReservationIdAsync(reservationId);
        }

        public static async Task<bool> DeleteReservationProductAsync(int orderProductID)
        {
            return await ReservationProductData.DeleteAsync(orderProductID);
        }

        public static async Task<bool> IsReservationProductExistAsync(int orderProductID)
        {
            return await ReservationProductData.ExistsAsync(orderProductID);
        }

        ///new
        //public static Task<List<ReservationProductDTO>> GetOrdersAsync(int reservationID)
        //    => ReservationProductData.GetByReservationAsync(reservationID);

        //public static Task<int?> AddOrderAsync(int reservationID, int? productID,
        //    string productName, int quantity, decimal unitPrice)
        //{
        //    var dto = new ReservationProductDTO(null, reservationID, productID,
        //        productName, quantity, unitPrice);
        //    return ReservationProductData.AddAsync(dto);
        //}
        
    }
}