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
    class ChurchDB
    {


        //Populate List

        //TestPopulate
        //FOR UI TESTING
        public static List<Church> TestPopulate()
        {
            var test = new List<Church>();
            test.Add(new Church("1", "St.", "Johns", "14510 Bray Dr"));
            test.Add(new Church("2", "Baptist", "Church", "14510 Bray Dr"));
            return test;
        }

        //start here
        public static List<Church> GetChurch()
        {
            //this allows us to populate a list of all individuals 
            List<Church> list = new List<Church>();
            NpgsqlConnection conn = null;
            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;

            string sqlQuery = "SELECT * FROM church ORDER BY id";

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
                                Church objChurch = new Church(reader["id"].ToString(), reader["first_name"].ToString(),
                                    reader["last_name"].ToString(), reader["address"].ToString());

                                list.Add(objChurch);
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

        public static bool AddChurch(Church objChurch)
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
                    sqlQuery = "INSERT into church values (@chu_num, @chu_fname, @chu_lname)";
                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        //this command will replace the parameter in the query string with the individual object's corresponding 
                        // property
                        command.Parameters.AddWithValue("@chu_num", objChurch.ID);
                        command.Parameters.AddWithValue("@chu_fname", objChurch.FirstName);
                        command.Parameters.AddWithValue("@chu_lname", objChurch.LastName);
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

        public static Church GetChurch(int chu_Num)
        {

            Church objChurch = null;
            NpgsqlConnection conn = null;
            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;

            string sqlQuery = "SELECT * FROM organization WHERE id = @ind_num";

            try
            {
                using (conn = AccessData.GetConnection())
                {
                    conn.Open();

                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@chu_num", chu_Num);

                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //inside the square brackets, the field must match the database perfectly for the reader to work
                                objChurch = new Church();
                                objChurch.ID = reader["id"].ToString();
                                objChurch.FirstName = reader["first_name"].ToString();
                                objChurch.LastName = reader["last_name"].ToString();
                            }
                        }
                    }
                }
                return objChurch;

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

        public static bool UpdateChurch(Church objChurch)
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

                    sqlQuery = "UPDATE church" + Environment.NewLine +
                        "set firstname = @chu_fname" + Environment.NewLine +
                        "lastname = @chu_lname" + Environment.NewLine +
                        "WHERE id = @chu_num";
                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@chu_num", objChurch.ID);
                        command.Parameters.AddWithValue("@chu_fname", objChurch.FirstName);
                        command.Parameters.AddWithValue("@chu_lname", objChurch.LastName);
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

        public static bool DeleteChurch(Church objChurch)
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

                    sqlQuery = "DELETE church WHERE id = @ind_num";
                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@chu_num", objChurch.ID);
                        command.Parameters.AddWithValue("@chu_fname", objChurch.FirstName);
                        command.Parameters.AddWithValue("@chu_lname", objChurch.LastName);
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

