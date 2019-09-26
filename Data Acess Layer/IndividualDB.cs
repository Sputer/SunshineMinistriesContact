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
    class IndividualDB
    {

        //Populate List

            //TestPopulate
            //FOR UI TESTING
        public static List<Individual> TestPopulate()
        {
            var test = new List<Individual>();
            test.Add(new Individual("1", "John", "Doe"));
            test.Add(new Individual("2", "Jane", "Doe"));
            return test;
        }

        //start here
        public static List<Individual> GetIndividuals()
        {
            //this allows us to populate a list of all individuals 
            List<Individual> list = new List<Individual>();
            NpgsqlConnection conn = null;
            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;

            string sqlQuery = "SELECT * FROM individual ORDER BY id";

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
                                Individual objIndividual = new Individual(reader["id"].ToString(), reader["first_name"].ToString(),
                                    reader["last_name"].ToString());

                                list.Add(objIndividual);
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

        public static bool AddIndividual(Individual objIndividual)
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
                    sqlQuery = "INSERT into individuals values (@ind_num, @ind_fname, @ind_lname)";
                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        //this command will replace the parameter in the query string with the individual object's corresponding 
                        // property
                        command.Parameters.AddWithValue("@ind_num", objIndividual.ID);
                        command.Parameters.AddWithValue("@ind_fname", objIndividual.FirstName);
                        command.Parameters.AddWithValue("@ind_lname", objIndividual.LastName);
                        //this is essentially our "did it work" kind of check
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    //if rows affected is greater than 0, then we know data was put into the database
                    if (rowsAffected > 0)
                    {
                        return true;
                    } else
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

        public static Individual GetIndividual(int ind_Num)
        {

            Individual objIndividual = null;
            NpgsqlConnection conn = null;
            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;

            string sqlQuery = "SELECT * FROM individual WHERE id = @ind_num";

            try
            {
                using (conn = AccessData.GetConnection())
                {
                    conn.Open();

                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@ind_num", ind_Num);

                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //inside the square brackets, the field must match the database perfectly for the reader to work
                                objIndividual = new Individual();
                                objIndividual.ID = reader["id"].ToString();
                                objIndividual.FirstName = reader["first_name"].ToString();
                                objIndividual.LastName = reader["last_name"].ToString();
                            }
                        }
                    }
                }
                return objIndividual;
                
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

        public static bool UpdateIndividual(Individual objIndividual)
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

                    sqlQuery = "UPDATE individual" + Environment.NewLine +
                        "set firstname = @ind_fname" + Environment.NewLine +
                        "lastname = @ind_lname" + Environment.NewLine +
                        "WHERE id = @ind_num";
                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@ind_num", objIndividual.ID);
                        command.Parameters.AddWithValue("@ind_fname", objIndividual.FirstName);
                        command.Parameters.AddWithValue("@ind_lname", objIndividual.LastName);
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

        public static bool DeleteIndividual(Individual objIndividual)
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

                    sqlQuery = "DELETE individual WHERE id = @ind_num";
                    using (command = new NpgsqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@ind_num", objIndividual.ID);
                        command.Parameters.AddWithValue("@ind_fname", objIndividual.FirstName);
                        command.Parameters.AddWithValue("@ind_lname", objIndividual.LastName);
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
