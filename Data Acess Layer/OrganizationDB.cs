using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineMinistriesContact.Data_Acess_Layer
{
    class OrganizationDB
    {

        //Populate List

        //TestPopulate
        //FOR UI TESTING
        public static List<Organization> TestPopulate()
        {
            var test = new List<Organization>();
            test.Add(new Organization("1", "Muhammadjon", "Sanaev", "Moon 365"));
            test.Add(new Organization("2", "James", "Bond", "USA"));
            test.Add(new Organization("3", "Yamaican", "Ford", "Out of Orbit"));
            return test;
        }

        //start here
        public static List<Organization> GetOrganization()
        {
            //this allows us to populate a list of all individuals 
            List<Organization> list = new List<Organization>();
            NpgsqlConnection conn = null;
            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;

            string sqlQuery = "SELECT * FROM organization ORDER BY id";

            try
            {
                using (conn = AccessData.GetConnection())
                {
                    conn.Open();
                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //We want to use the constructor from the business object version here, reading each
                                // of the parameters from the database by putting the column's name in the square brackets
                                Organization objOrganization = new Organization(reader["id"].ToString(), reader["name"].ToString(),
                                    reader["nickname"].ToString(), reader["address1"].ToString());

                                list.Add(objOrganization);
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
            finally
            {

            }

            return list;
        }


        //Create

        public static bool AddOrganization(Organization objOrganization)
        {

            //these are our variables to be used

            int rowsAffected = 0;
            NpgsqlConnection conn = null;
            NpgsqlCommand command = null;
            string sqlQuery;

            try
            {
                //using allows the program to shut the connection so that it's not constantly attatched to the database
                using (conn = AccessData.GetConnection())
                {
                    //open the connection to the database
                    conn.Open();
                    //this is where the SQL query to the database will be put in. the parameters ie '@ind_num' must match
                    // the table's column names to work properly
                    sqlQuery = "INSERT into individuals values (@org_num, @org_name, @org_nickname)";
                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        //this command will replace the parameter in the query string with the individual object's corresponding 
                        // property
                        command.Parameters.AddWithValue("@org_num", objOrganization.ID);
                        command.Parameters.AddWithValue("@org_name", objOrganization.FirstName);
                        command.Parameters.AddWithValue("@org_nickname", objOrganization.LastName);
                        //this is essentially our "did it work" kind of check
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    //if rows affected is greater than 0, then we know data was put into the database
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw ex;
            }
            finally
            {
                //Failsafe to make sure that the Database Connection is closed
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }

        //Read

        public static Organization GetOrganization(int org_Num)
        {

            Organization objOrganization = null;
            NpgsqlConnection conn = null;
            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;

            string sqlQuery = "SELECT * FROM organization WHERE id = @org_num";

            try
            {
                using (conn = AccessData.GetConnection())
                {
                    conn.Open();

                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@org_num", org_Num);

                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //inside the square brackets, the field must match the database perfectly for the reader to work
                                objOrganization = new Organization();
                                objOrganization.ID = reader["id"].ToString();
                                objOrganization.FirstName = reader["name"].ToString();
                                objOrganization.LastName = reader["nickname"].ToString();
                            }
                        }
                    }
                }
                return objOrganization;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //Update

        public static bool UpdateOrganization(Organization objOrganization)
        {
            int rowsAffected = 0;
            NpgsqlConnection conn = null;
            NpgsqlCommand command = null;
            string sqlQuery;

            try
            {
                using (conn = AccessData.GetConnection())
                {
                    conn.Open();

                    //the UPDATE syntax will be used in this case, and the format will match SQL query format so each
                    // column on a new line for clarity

                    sqlQuery = "UPDATE organization" + Environment.NewLine +
                        "set firstname = @org_name" + Environment.NewLine +
                        "lastname = @org_nickname" + Environment.NewLine +
                        "WHERE id = @org_num";
                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@org_num", objOrganization.ID);
                        command.Parameters.AddWithValue("@org_name", objOrganization.FirstName);
                        command.Parameters.AddWithValue("@org_nickname", objOrganization.LastName);
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }


        //Delete

        public static bool DeleteOrganization(Organization objOrganization)
        {
            int rowsAffected = 0;
            NpgsqlConnection conn = null;
            NpgsqlCommand command = null;
            string sqlQuery;

            try
            {
                using (conn = AccessData.GetConnection())
                {
                    conn.Open();

                    //DELETE syntax is much simpler, we only need to find the selected ID and delete it

                    sqlQuery = "DELETE organization WHERE id = @org_num";
                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@org_num", objOrganization.ID);
                        command.Parameters.AddWithValue("@org_name", objOrganization.FirstName);
                        command.Parameters.AddWithValue("@org_nickname", objOrganization.LastName);
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
