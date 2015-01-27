using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace BattleShipService
{
    public class DB
    {
        private MySqlConnection conn;
        private string connectionString;

        public DB()
        {
            conn = new MySqlConnection();

            string server = "athena01.fhict.local";
            string database = "dbi270138";
            string uid = "dbi270138";
            string password = "1Lec9taGvr";

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            conn.ConnectionString = connectionString;
        }


        /// <summary>
        /// This method determines if the username and password combination is sufficient
        /// for creating a Player object on the server with its appropriate callbacks.
        /// A return of 1 means player exists, make a log in. 0 means user and password have no match.
        /// -1 means database-related error.
        /// </summary>
        /// <param name="playername"></param>
        /// <param name="password"></param>
        /// <returns>0, 1 or -1.</returns>
        public int CheckLogin(string name, string passwd)
        {
            if (CheckUserExist(name) == 1)
            {
                try
                {
                    String sql = "SELECT username, password FROM mdwpro WHERE username = '" + name + "' AND password = '" + passwd + "';";
                    MySqlCommand command = new MySqlCommand(sql, conn);

                    conn.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    string nm = "";
                    string pss = "";

                    while (reader.Read())
                    {
                        nm = Convert.ToString(reader[0]);
                        pss = Convert.ToString(reader[1]);
                    }

                    if (name == nm && passwd == pss)
                    {
                        return 1;
                    }
                    return 0;
                }
                catch (MySqlException)
                {
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (CheckUserExist(name) == -1)
            {
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Registers the player in the database. Does not equate to being logged in.
        /// A return of false means the playerusername already exists in the database.
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="playername"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Number of records changed. -1 means unsuccessful execution of try-block.</returns>
        public bool UserRegister(string name, string passwd)
        {
            if (this.CheckUserExist(name) == 0)
            {
                String sql = "INSERT INTO mdwpro (username, password) VALUES ('" + name + "','" + passwd + "');";
                MySqlCommand command = new MySqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    int nrOfRecordsChanged = command.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }

        /// <summary>
        /// Returns the number player in database. Return of 0 means does not exist.
        /// Should not return more than 1.
        /// </summary>
        /// <param name="playername"></param>
        /// <returns>Successfully either 0 or 1</returns>
        public int CheckUserExist(string name)
        {
            try
            {
                String sql = ("SELECT username FROM mdwpro WHERE username = '" + name + "';");
                MySqlCommand command = new MySqlCommand(sql, conn);

                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count++;
                }
                return count;
            }
            catch (MySqlException)
            {
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// This method checks if the player name is exist in the database or not. And reset the new password in the database.
        /// </summary>
        /// <param name="name">Player name</param>
        /// <param name="passwd">Player password</param>
        /// <returns>true or false</returns>
        public bool CheckResetPassword(string name, string passwd)
        {
            if (this.CheckUserExist(name) == 1)
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand cmd;
                connection.Open();

                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE mdwpro SET password=@passwd WHERE username=@name";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@passwd", passwd);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
