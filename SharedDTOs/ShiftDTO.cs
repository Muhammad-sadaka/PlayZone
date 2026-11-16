using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedDTOs
{
    public class ShiftDTO
    {
        [Column("Shift ID")]
        public int? ShiftID { set; get; }

        [Column("User ID")]
        public int? UserID { set; get; }

        [Column("Start Time")]
        public DateTime StartTime { set; get; }

        [Column("End Time")]
        public DateTime? EndTime { set; get; }

        [Column("Starting Cash")]
        public decimal StartingCash { set; get; }

        [Column("Total Sales")]
        public decimal TotalSales { set; get; }

        [Column("Expected Cash")]
        public decimal ExpectedCash { set; get; }

        [Column("Actual Cash")]
        public decimal? ActualCash { set; get; }

        public ShiftDTO(int? shiftID, int? userID, DateTime startTime, DateTime? endTime, decimal startingCash, decimal totalSales, decimal expectedCash, decimal? actualCash)
        {
            ShiftID = shiftID;
            UserID = userID;
            StartTime = startTime;
            EndTime = endTime;
            StartingCash = startingCash;
            TotalSales = totalSales;
            ExpectedCash = expectedCash;
            ActualCash = actualCash;
        }
    }
}