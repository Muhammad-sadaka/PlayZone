using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace PlayZone_DataAccess
{
    public class clsSpotTypesDataAccess
    {
        public static bool GetSpotTypeInfoBySpotTypeID(int SpotTypeID, ref string SpotTypeName, ref Decimal PricePerHour, ref string Image)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetSpotTypeByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SpotTypeID", SpotTypeID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                SpotTypeName = (string)reader["SpotTypeName"];
                                PricePerHour = Convert.ToDecimal(reader["PricePerHour"]);
                                if (reader["Image"] != DBNull.Value)
                                {
                                    Image = (string)reader["Image"];
                                }
                                else
                                {
                                    Image = "";
                                }
                            }
                            else
                            {
                                // The record was not found
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

        public static bool GetSpotTypeInfoByName(ref int SpotTypeID,string SpotTypeName, ref Decimal PricePerHour, ref string Image)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetSpotTypeByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SpotTypeName", SpotTypeName);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                SpotTypeID = (int)reader["SpotTypeID"];
                                PricePerHour = Convert.ToDecimal(reader["PricePerHour"]);
                                if (reader["Image"] != DBNull.Value)
                                {
                                    Image = (string)reader["Image"];
                                }
                                else
                                {
                                    Image = "";
                                }
                            }
                            else
                            {
                                // The record was not found
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

        public static int AddNewSpotType(string SpotName, Decimal PricePerHour, string Image)
        {
            int SpotTypeID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewSpotType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SpotTypeName", SpotName);
                        command.Parameters.AddWithValue("@PricePerHour", PricePerHour);

                        if (!string.IsNullOrEmpty(Image))
                            command.Parameters.AddWithValue("@Image", Image);
                        else
                            command.Parameters.AddWithValue("@Image", DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@NewSpotTypeID", SqlDbType.Int)
                        { 
                           Direction = ParameterDirection.Output,
                        };
                        command.Parameters.Add(outputIdParam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        if(outputIdParam.Value != DBNull.Value)
                           SpotTypeID = (int)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.EventLogCreate();
                EventLog.WriteEntry(clsDataAccessSettings.sourceName, "Error: " + ex.Message, EventLogEntryType.Error);
            }

            return SpotTypeID;
        }

        public static bool UpdateSpotType(int SpotTypeID,string SpotTypeName, Decimal PricePerHour, string Image)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateSpotType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SpotTypeID", SpotTypeID);
                        command.Parameters.AddWithValue("@SpotTypeName", SpotTypeName);
                        command.Parameters.AddWithValue("@PricePerHour", PricePerHour);

                        if (!string.IsNullOrEmpty(Image))
                            command.Parameters.AddWithValue("@Image", Image);
                        else
                            command.Parameters.AddWithValue("@Image", DBNull.Value);

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

            return (rowsAffected > 0);
        }

        public static DataTable GetAllSpotTypes()
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllSpotTypes", connection))
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

        public static bool DeleteSpotType(int SpotTypeID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteSpotTypeID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SpotTypeID", SpotTypeID);
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

        public static bool IsSpotTypeExist(int SpotTypeID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_CheckSpotTypeExists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SpotTypeID", SpotTypeID);

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

        public static bool IsSpotTypeExist(string SpotTypeName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_CheckSpotTypeExistsByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SpotTypeName", SpotTypeName);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
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
