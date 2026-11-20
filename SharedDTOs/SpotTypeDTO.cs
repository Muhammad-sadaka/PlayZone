using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedDTOs
{
    public class SpotTypeDTO
    {
        [Column("SpotType ID")]
        public int? SpotTypeID { set; get; }

        [Column("SpotType Name")]
        public string SpotTypeName { set; get; }

        [Column("Price Per Hour")]
        public decimal? PricePerHour { set; get; }

        [Column("Image Path")]
        public string ImagePath { set; get; }

        public SpotTypeDTO(int? spotTypeID, string spotTypeName, decimal? pricePerHour, string imagePath)
        {
            SpotTypeID = spotTypeID;
            SpotTypeName = spotTypeName;
            PricePerHour = pricePerHour;
            ImagePath = imagePath;
        }
    }

    public class SpotTypesListDTO
    {
        public int? SpotTypeID { set; get; }
        public string SpotTypeName { set; get; }
        public decimal? PricePerHour { set; get; }
        public int? SpotsCount { set; get; }

        public SpotTypesListDTO(int? spotTypeID, string spotTypeName, decimal? pricePerHour, int? spotsCount)
        {
            SpotTypeID = spotTypeID;
            SpotTypeName = spotTypeName;
            PricePerHour = pricePerHour;
            SpotsCount = spotsCount;
        }
    }
}