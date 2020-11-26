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
    public class UserRepository
    {
        private static string _cs = ConfigurationManager.ConnectionStrings["Recipes"].ConnectionString;
        private static int _colUserId = 0;
        private static int _colFirstName = 1;
        private static int _colLastName = 2;
        private static int _colCountry = 3;
        private static int _colGender = 4;
        private static int _colEmail = 5;
        private static int _colBirthDate = 6;
        private static int _colIsAdministrator = 7;

        public List<User> GetAll()
        {
            List<User> tempList = new List<User>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetAllUsers";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User()
                    {
                        Id = dr.GetInt32(_colUserId),
                        FirstName = dr.GetString(_colFirstName),
                        LastName = dr.GetString(_colLastName),
                        Country = dr.GetString(_colCountry),
                        //Gender = (Model.Model.Util.Gender)dr.GetByte(_colGender),
                        Email = dr.GetString(_colEmail),
                        BirthDate = dr.GetDateTime(_colBirthDate),
                        IsAdministrator = dr.GetBoolean(_colIsAdministrator)
                    };
                    tempList.Add(user);
                }
            }  
            return tempList;
        }

        public User GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetByIdUser";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User user = new User()
                    {
                        Id = dr.GetInt32(_colUserId),
                        FirstName = dr.GetString(_colFirstName),
                        LastName = dr.GetString(_colLastName),
                        Country = dr.GetString(_colCountry),
                        //Gender = (Model.Model.Util.Gender)dr.GetByte(_colGender),
                        Email = dr.GetString(_colEmail),
                        BirthDate = dr.GetDateTime(_colBirthDate),
                        IsAdministrator = dr.GetBoolean(_colIsAdministrator)
                    };

                    return user;
                }
            }

            throw new Exception("There is no user with the id: " + id);
        }

        public void Add(User user)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spAddUser";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter fNameParam = new SqlParameter();
                fNameParam.ParameterName = "@FirstName";
                fNameParam.Value = user.FirstName;
                fNameParam.Direction = ParameterDirection.Input;
                fNameParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter lNameParam = new SqlParameter();
                lNameParam.ParameterName = "@LastName";
                lNameParam.Value = user.LastName;
                lNameParam.Direction = ParameterDirection.Input;
                lNameParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter countryParam = new SqlParameter();
                countryParam.ParameterName = "@Country";
                countryParam.Value = user.Country;
                countryParam.Direction = ParameterDirection.Input;
                countryParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter genderParam = new SqlParameter();
                genderParam.ParameterName = "@Gender";
                genderParam.Value = user.Gender;
                genderParam.Direction = ParameterDirection.Input;
                genderParam.SqlDbType = SqlDbType.TinyInt;

                SqlParameter emailParam = new SqlParameter();
                emailParam.ParameterName = "@Email";
                emailParam.Value = user.Email;
                emailParam.Direction = ParameterDirection.Input;
                emailParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter birthDateParam = new SqlParameter();
                birthDateParam.ParameterName = "@BirthDate";
                birthDateParam.Value = user.BirthDate;
                birthDateParam.Direction = ParameterDirection.Input;
                birthDateParam.SqlDbType = SqlDbType.Date;

                SqlParameter isAdminParam = new SqlParameter();
                isAdminParam.ParameterName = "@IsAdministrator";
                isAdminParam.Value = user.IsAdministrator;
                isAdminParam.Direction = ParameterDirection.Input;
                isAdminParam.SqlDbType = SqlDbType.Bit;

                cmd.Parameters.Add(fNameParam);
                cmd.Parameters.Add(lNameParam);
                cmd.Parameters.Add(countryParam);
                cmd.Parameters.Add(genderParam);
                cmd.Parameters.Add(emailParam);
                cmd.Parameters.Add(birthDateParam);
                cmd.Parameters.Add(isAdminParam);

                conn.Open();
                int id = (int)cmd.ExecuteScalar();
                user.Id = id;
            }
        }

        public void Update(User user)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spUpdateUser";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Country", user.Country);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                cmd.Parameters.AddWithValue("@IsAdministrator", user.IsAdministrator);

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

                    cmd.CommandText = "spRemoveUser";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserId", id);

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
