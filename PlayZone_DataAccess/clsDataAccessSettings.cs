using System;
using System.Configuration;
using System.Diagnostics;

namespace PlayZone_DataAccess
{
    static class clsDataAccessSettings
    {
        public static string sourceName = "PlayZone";

        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public static void EventLogCreate()
        {
            if (!EventLog.SourceExists(sourceName)) EventLog.CreateEventSource(sourceName, "Application");
        }
    }
}
