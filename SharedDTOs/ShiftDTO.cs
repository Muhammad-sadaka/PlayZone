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


public class ShiftSummaryDTO
{
    public int ShiftID { get; set; }
    public string CashierName { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public decimal StartingCash { get; set; }
    public decimal SessionsRevenue { get; set; }
    public decimal CafeteriaRevenue { get; set; }
    public decimal TotalSales { get; set; }
    public decimal ExpectedCash { get; set; }

    public ShiftSummaryDTO() { }

    public ShiftSummaryDTO(int shiftID, string cashierName, DateTime startTime,
        decimal startingCash, decimal sessionsRevenue, decimal cafeteriaRevenue,decimal totalSales,decimal expectedCash)
    {
        ShiftID = shiftID;
        CashierName = cashierName;
        StartTime = startTime;
        StartingCash = startingCash;
        SessionsRevenue = sessionsRevenue;
        CafeteriaRevenue = cafeteriaRevenue;
        TotalSales = totalSales;
        ExpectedCash = expectedCash;
    }
}



public class ShiftsListDTO
{
    public int ShiftID { get; set; }
    public string CashierName { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { set; get; }
    public decimal StartingCash { get; set; }
    public decimal? ActualCash { set; get; }
    public decimal ExpectedCash { get; set; }
    public decimal Difference { set; get; }

    public ShiftsListDTO() { }

    public ShiftsListDTO(int shiftID, string cashierName, DateTime startTime,DateTime? endTime,
        decimal startingCash, decimal? actualCash,  decimal expectedCash, decimal difference)
    {
        ShiftID = shiftID;
        CashierName = cashierName;
        StartTime = startTime;
        EndTime = endTime;
        StartingCash = startingCash;
        ActualCash = actualCash;
        ExpectedCash = expectedCash;
        Difference = difference;
    }
}

public class SalesListDTO
{
    public DateTime Date { get; set; }
    public int SessionCount { get; set; }
    public decimal SessionsRevenue { get; set; }
    public decimal CafeteriaRevenue { get; set; }
    public decimal TotalSales { get; set; }

    public SalesListDTO() { }

    public SalesListDTO(DateTime date, int sessionCount, decimal sessionsRevenue, decimal cafeteriaRevenue, decimal totalSales)
    {
        Date = date;
        SessionCount = sessionCount;
        SessionsRevenue = sessionsRevenue;
        CafeteriaRevenue = cafeteriaRevenue;
        TotalSales = totalSales;
    }
}