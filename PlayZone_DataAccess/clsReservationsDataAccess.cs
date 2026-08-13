using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PlayZone_DataAccess
{
    public class clsReservationsDataAccess
    {
        public static bool? GetReservationInfoByID(int? ReservationID, ref string CustomerName, ref DateTime? StartDate, ref DateTime? EndDate, ref TimeSpan? Period, ref decimal? TotalPrice, ref int? SpotTypeID)
        {
            bool? isFound = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetReservationByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReservationID", (object)ReservationID ?? DBNull.Value);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                CustomerName = reader["CustomerName"] == DBNull.Value ? null : (string)reader["CustomerName"];
                                StartDate = reader["StartDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["StartDate"]);
                                EndDate = reader["EndDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["EndDate"]);
                                Period = reader["Period"] == DBNull.Value ? (TimeSpan?)null : (TimeSpan)reader["Period"];
                                TotalPrice = reader["TotalPrice"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["TotalPrice"]);
                                SpotTypeID = reader["SpotTypeID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["SpotTypeID"]);
                            }
                            else
                            {
                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.EventLogCreate();
                EventLog.WriteEntry(clsDataAccessSettings.sourceName, "Error: " + ex.Message, EventLogEntryType.Error);
                isFound = false;
            }
            return isFound;
        }

        public static int? AddNewReservation(string CustomerName, DateTime? StartDate, DateTime? EndDate, TimeSpan? Period, decimal? TotalPrice, int? SpotTypeID)
        {
            int? ReservationID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewReservation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CustomerName", (object)CustomerName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StartDate", (object)StartDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EndDate", (object)EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Period", (object)Period ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalPrice", (object)TotalPrice ?? DBNull.Value);
                        command.Parameters.AddWithValue("@SpotTypeID", (object)SpotTypeID ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@NewReservationID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        connection.Open();
                        command.ExecuteNonQuery();

                        if (outputIdParam.Value != DBNull.Value)
                            ReservationID = (int)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.EventLogCreate();
                EventLog.WriteEntry(clsDataAccessSettings.sourceName, "Error: " + ex.Message, EventLogEntryType.Error);
            }

            return ReservationID;
        }

        public static bool? UpdateReservation(int? ReservationID, string CustomerName, DateTime? StartDate, DateTime? EndDate, TimeSpan? Period, decimal? TotalPrice, int? SpotTypeID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateReservation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ReservationID", (object)ReservationID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CustomerName", (object)CustomerName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StartDate", (object)StartDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EndDate", (object)EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Period", (object)Period ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TotalPrice", (object)TotalPrice ?? DBNull.Value);
                        command.Parameters.AddWithValue("@SpotTypeID", (object)SpotTypeID ?? DBNull.Value);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.EventLogCreate();
                EventLog.WriteEntry(clsDataAccessSettings.sourceName, "Error: " + ex.Message, EventLogEntryType.Error);
                return false;
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllReservations()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllReservations", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.EventLogCreate();
                EventLog.WriteEntry(clsDataAccessSettings.sourceName, "Error: " + ex.Message, EventLogEntryType.Error);
            }

            return dt;
        }

        public static bool DeleteReservation(int? ReservationID)
        {
            int? rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteReservation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReservationID", (object)ReservationID ?? DBNull.Value);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.EventLogCreate();
                EventLog.WriteEntry(clsDataAccessSettings.sourceName, "Error: " + ex.Message, EventLogEntryType.Error);
            }
            return (rowsAffected > 0);
        }

        public static bool? IsReservationExist(int? ReservationID)
        {
            bool? isFound = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_CheckReservationExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReservationID", (object)ReservationID ?? DBNull.Value);

                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        command.Parameters.Add(returnParameter);

                        connection.Open();
                        command.ExecuteNonQuery();

                        if (returnParameter.Value != null)
                        {
                            isFound = (int)returnParameter.Value == 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.EventLogCreate();
                EventLog.WriteEntry(clsDataAccessSettings.sourceName, "Error: " + ex.Message, EventLogEntryType.Error);
                isFound = false;
            }

            return isFound;
        }
    }
}

