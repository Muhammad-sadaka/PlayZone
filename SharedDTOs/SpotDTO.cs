using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedDTOs
{
    public class SpotDTO
    {
        [Column("Spot ID")]
        public int? SpotID { set; get; }

        [Column("Spot Name")]
        public string SpotName { set; get; }

        [Column("Spot Type ID")]
        public int SpotTypeId { set; get; }

        [Column("Spot Type ID")]
        public bool Active { set; get; }

        [Column("SpotType Name")]
        public string SpotTypeName { set; get; }

        [Column("Price Per Hour")]
        public decimal? PricePerHour { set; get; }

        [Column("Image Path")]
        public string ImagePath { set; get; }

        public SpotDTO(int? spotID, string spotName, int spotTypeId, bool active)
        {
            SpotID = spotID;
            SpotName = spotName;
            SpotTypeId = spotTypeId;
            Active = active;
        }

        public SpotDTO(int? spotID, string spotName, int spotTypeID,bool active, string spotTypeName, decimal? pricePerHour, string imagePath)
        {
            SpotID = spotID;
            SpotName = spotName;
            SpotTypeId = spotTypeID;
            Active = active;
            SpotTypeName = spotTypeName;
            PricePerHour = pricePerHour;
            ImagePath = imagePath;
        }

    }
}