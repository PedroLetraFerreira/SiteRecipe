using SiteRecipe.Model.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Data.Repositories
{
    public class AccountRepository
    {
         private static string _cs = ConfigurationManager.ConnectionStrings["Recipes"].ConnectionString;
         private static int _colAccountId = 0;
         private static int _colUsername = 1;
         private static int _colPassword = 2;

        public List<Account> GetAll()
        {
            List<Account> tempList = new List<Account>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetAllAccounts";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Account account = new Account()
                    {
                        Id = dr.GetInt32(_colAccountId),
                        Username = dr.GetString(_colUsername),
                        Password = dr.GetString(_colPassword)
                    };
                    tempList.Add(account);
                }
            }
            return tempList;
        }

        public Account GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetByIdAccount";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Account account = new Account()
                    {
                        Id = dr.GetInt32(_colAccountId),
                        Username = dr.GetString(_colUsername),
                        Password = dr.GetString(_colPassword)
                    };

                    return account;
                }
            }

            throw new Exception("There is no account with the id: " + id);
        }

        public void Add(Account account)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spAddAccount";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter usernameParam = new SqlParameter();
                usernameParam.ParameterName = "@Username";
                usernameParam.Value = account.Username;
                usernameParam.Direction = ParameterDirection.Input;
                usernameParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter passwordParam = new SqlParameter();
                passwordParam.ParameterName = "@Password";
                passwordParam.Value = account.Password;
                passwordParam.Direction = ParameterDirection.Input;
                passwordParam.SqlDbType = SqlDbType.NVarChar;

                cmd.Parameters.Add(usernameParam);
                cmd.Parameters.Add(passwordParam);

                conn.Open();
                int id = (int)cmd.ExecuteScalar();
                account.Id = id;
            }
        }

        public void Update(Account account)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spUpdateAccount";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);

                conn.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows != 1)
                {
                    throw new Exception("It was not possible to make the update");
                }
            }
        }

        public void Remove(int id)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "spRemoveAccount";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AccountId", id);

                    conn.Open();

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows != 1)
                    {
                        throw new Exception("It was not possible to remove");
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("It was not possible to connect to DB");
                }
            }
        }
    }
}
