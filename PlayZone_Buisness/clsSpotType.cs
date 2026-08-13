using System;
using System.Data;
using PlayZone_DataAccess;

namespace PlayZone_Buisness
{
    public class clsSpotType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int SpotTypeID { set; get; }
        public string SpotTypeName { set; get; }
        public Decimal PricePerHour { set; get; }
        public string ImagePath { set; get; }


        public clsSpotType()
        {
            this.SpotTypeID = -1;
            this.SpotTypeName = "";
            this.PricePerHour = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;

        }

        private clsSpotType(int SpotTypeID, string SpotName, Decimal PricePerHour, string ImagePath)
        {
            this.SpotTypeID = SpotTypeID;
            this.SpotTypeName = SpotName;
            this.PricePerHour = PricePerHour;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        private bool _AddNewSpotType()
        {
            //call DataAccess Layer 

            this.SpotTypeID = clsSpotTypesDataAccess.AddNewSpotType(this.SpotTypeName,this.PricePerHour,this.ImagePath);

            return (this.SpotTypeID != -1);
        }

        private bool _UpdateSpotType()
        {
            return clsSpotTypesDataAccess.UpdateSpotType(this.SpotTypeID, this.SpotTypeName, this.PricePerHour, this.ImagePath);
        }

        public static clsSpotType FindByID(int SpotTypeID)
        {
            string ImagePath = "";
            Decimal PricePerHour = -1;
            string SpotName = "";

            bool IsFound = clsSpotTypesDataAccess.GetSpotTypeInfoBySpotTypeID( SpotTypeID, ref SpotName, ref PricePerHour, ref ImagePath);

            if (IsFound)
                return new clsSpotType(SpotTypeID, SpotName, PricePerHour, ImagePath);
            else
                return null;

        }

        public static clsSpotType FindByName(string SpotName)
        {
            string ImagePath = "";
            Decimal PricePerHour = -1;
            int SpotTypeID = -1;

            bool IsFound = clsSpotTypesDataAccess.GetSpotTypeInfoByName(ref SpotTypeID, SpotName, ref PricePerHour, ref ImagePath);
            if (IsFound)
                return new clsSpotType(SpotTypeID, SpotName, PricePerHour, ImagePath);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSpotType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateSpotType();
            }
            return false;
        }

        public static DataTable GetAllSpotType()
        {
            return clsSpotTypesDataAccess.GetAllSpotTypes();
        }

        public static bool DeleteSpotType(int SpotTypeID)
        {
            return clsSpotTypesDataAccess.DeleteSpotType(SpotTypeID);
        }

        public static bool IsSpotTypeExist(int SpotTypeID)
        {
            return clsSpotTypesDataAccess.IsSpotTypeExist(SpotTypeID);
        }

        public static bool IsSpotTypeExist(string SpotName)
        {
            return clsSpotTypesDataAccess.IsSpotTypeExist(SpotName);
        }

    }
}
