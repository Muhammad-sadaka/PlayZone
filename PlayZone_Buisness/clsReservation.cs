using System;
using System.Data;
using PlayZone_DataAccess;

namespace PlayZone_Buisness
{
    public class clsReservation
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int? ReservationID { set; get; }
        public string CustomerName { set; get; }
        public DateTime? StartDate { set; get; }
        public DateTime? EndDate { set; get; }
        public TimeSpan? Period { set; get; }
        public decimal? TotalPrice { set; get; }
        public int? SpotTypeID { set; get; }

        public clsReservation()
        {
            this.ReservationID = null;
            this.CustomerName = "";
            this.StartDate = null;
            this.EndDate = null;
            this.Period = null;
            this.TotalPrice = null;
            this.SpotTypeID = null;

            Mode = enMode.AddNew;
        }

        private clsReservation(int? ReservationID, string CustomerName, DateTime? StartDate, DateTime? EndDate, TimeSpan? Period, decimal? TotalPrice, int? SpotTypeID)
        {
            this.ReservationID = ReservationID;
            this.CustomerName = CustomerName;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Period = Period;
            this.TotalPrice = TotalPrice;
            this.SpotTypeID = SpotTypeID;

            Mode = enMode.Update;
        }

        private bool _AddNewReservation()
        {
            this.ReservationID = clsReservationsDataAccess.AddNewReservation(this.CustomerName, this.StartDate, this.EndDate, this.Period, this.TotalPrice, this.SpotTypeID);
            return (this.ReservationID != null);
        }

        private bool _UpdateReservation()
        {
            return clsReservationsDataAccess.UpdateReservation(this.ReservationID, this.CustomerName, this.StartDate, this.EndDate, this.Period, this.TotalPrice, this.SpotTypeID) ?? false;
        }

        public static clsReservation FindByID(int? ReservationID)
        {
            if (ReservationID == null) return null;

            string CustomerName = "";
            DateTime? StartDate = null;
            DateTime? EndDate = null;
            TimeSpan? Period = null;
            decimal? TotalPrice = null;
            int? SpotTypeID = null;

            bool? IsFound = clsReservationsDataAccess.GetReservationInfoByID(ReservationID, ref CustomerName, ref StartDate, ref EndDate, ref Period, ref TotalPrice, ref SpotTypeID);

            if (IsFound == true)
                return new clsReservation(ReservationID, CustomerName, StartDate, EndDate, Period, TotalPrice, SpotTypeID);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewReservation())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateReservation();
            }
            return false;
        }

        public static DataTable GetAllReservations()
        {
            return clsReservationsDataAccess.GetAllReservations();
        }

        public static bool DeleteReservation(int? ReservationID)
        {
            return clsReservationsDataAccess.DeleteReservation(ReservationID);
        }

        public static bool IsReservationExist(int? ReservationID)
        {
            return clsReservationsDataAccess.IsReservationExist(ReservationID) ?? false;
        }
    }
}

