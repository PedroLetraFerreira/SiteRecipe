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
    public class CategoryRepository
    {
        private static string _cs = ConfigurationManager.ConnectionStrings["Recipes"].ConnectionString;
        private static int _colCategoryId = 0;
        private static int _colCategoryName = 1;

        public List<Category> GetAll()
        {
            List<Category> tempList = new List<Category>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetAllCategories";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category category = new Category()
                    {
                        Id = dr.GetInt32(_colCategoryId),
                        CategoryName = dr.GetString(_colCategoryName),
                    };
                    tempList.Add(category);
                }
            }
            return tempList;
        }

        public Category GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetByIdCategory";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category category = new Category()
                    {
                        Id = dr.GetInt32(_colCategoryId),
                        CategoryName = dr.GetString(_colCategoryName),
                    };

                    return category;
                }
            }

            throw new Exception("There is no category with the id: " + id);
        }

        public void Add(Category category)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spAddCategory";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter catNameParam = new SqlParameter();
                catNameParam.ParameterName = "@CategoryName";
                catNameParam.Value = category.CategoryName;
                catNameParam.Direction = ParameterDirection.Input;
                catNameParam.SqlDbType = SqlDbType.NVarChar;

                cmd.Parameters.Add(catNameParam);

                conn.Open();
                int id = (int)cmd.ExecuteScalar();
                category.Id = id;
            }
        }

        public void Update(Category category)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spUpdateCategory";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);

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

                    cmd.CommandText = "spRemoveCategory";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CategoryId", id);

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
