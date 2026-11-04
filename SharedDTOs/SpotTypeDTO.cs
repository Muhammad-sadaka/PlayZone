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
        public Decimal? PricePerHour { set; get; }
        [Column("Image Path")]
        public string ImagePath { set; get; }

        public SpotTypeDTO(int? SpotTypeID, string SpotTypeName, Decimal? PricePerHour, string ImagePath)
        {
            this.SpotTypeID = SpotTypeID;
            this.SpotTypeName = SpotTypeName;
            this.PricePerHour = PricePerHour;
            this.ImagePath = ImagePath;
        }
    }
}