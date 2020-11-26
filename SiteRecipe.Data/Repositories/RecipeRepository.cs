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
    public class RecipeRepository
    {
        private static string _cs = ConfigurationManager.ConnectionStrings["Recipes"].ConnectionString;
        private static int _colRecipeId = 0;
        private static int _colName = 1;
        private static int _colRating = 2;
        private static int _colDifficulty = 3;
        private static int _colDescription = 4;
        private static int _colCookingTime = 5;
        private static int _colIsValidated = 6;

        public List<Recipe> GetAll()
        {
            List<Recipe> tempList = new List<Recipe>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetAllRecipes";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipe recipe = new Recipe()
                    {
                        Id = dr.GetInt32(_colRecipeId),
                        Name = dr.GetString(_colName),
                        //Rating = (Model.Model.Util.Rating)dr.GetByte(_colRating),
                        //Difficulty = (Model.Model.Util.Difficulty)dr.GetByte(_colDifficulty),
                        Description = dr.GetString(_colDescription),
                        CookingTime = dr.GetTimeSpan(_colCookingTime ),
                        IsValidated = dr.GetBoolean(_colIsValidated) 
                    };
                    tempList.Add(recipe);
                }
            }
            return tempList;
        }

        public Recipe GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetByIdRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipe recipe = new Recipe()
                    {
                        Id = dr.GetInt32(_colRecipeId),
                        Name = dr.GetString(_colName),
                        //Rating = (Model.Model.Util.Rating)dr.GetByte(_colRating),
                        //Difficulty = (Model.Model.Util.Difficulty)dr.GetByte(_colDifficulty),
                        Description = dr.GetString(_colDescription),
                        CookingTime = dr.GetTimeSpan(_colCookingTime),
                        IsValidated = dr.GetBoolean(_colIsValidated)
                    };

                    return recipe;
                }
            }

            throw new Exception("There is no recipe with the id: " + id);
        }

        public void Add(Recipe recipe)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spAddRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter();
                nameParam.ParameterName = "@Name";
                nameParam.Value = recipe.Name;
                nameParam.Direction = ParameterDirection.Input;
                nameParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter ratingParam = new SqlParameter();
                ratingParam.ParameterName = "@Rating";
                ratingParam.Value = recipe.Rating;
                ratingParam.Direction = ParameterDirection.Input;
                ratingParam.SqlDbType = SqlDbType.TinyInt;

                SqlParameter difficultyParam = new SqlParameter();
                difficultyParam.ParameterName = "@Difficulty";
                difficultyParam.Value = recipe.Difficulty;
                difficultyParam.Direction = ParameterDirection.Input;
                difficultyParam.SqlDbType = SqlDbType.TinyInt;

                SqlParameter descriptionParam = new SqlParameter();
                descriptionParam.ParameterName = "@Description";
                descriptionParam.Value = recipe.Description;
                descriptionParam.Direction = ParameterDirection.Input;
                descriptionParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter cookingTimeParam = new SqlParameter();
                cookingTimeParam.ParameterName = "@CookingTime";
                cookingTimeParam.Value = recipe.CookingTime;
                cookingTimeParam.Direction = ParameterDirection.Input;
                cookingTimeParam.SqlDbType = SqlDbType.Time;

                SqlParameter isValidParam = new SqlParameter();
                isValidParam.ParameterName = "@IsValidated";
                isValidParam.Value = recipe.IsValidated;
                isValidParam.Direction = ParameterDirection.Input;
                isValidParam.SqlDbType = SqlDbType.Bit;

                cmd.Parameters.Add(nameParam);
                cmd.Parameters.Add(ratingParam);
                cmd.Parameters.Add(difficultyParam);
                cmd.Parameters.Add(descriptionParam);
                cmd.Parameters.Add(cookingTimeParam);
                cmd.Parameters.Add(isValidParam);

                conn.Open();
                int id = (int)cmd.ExecuteScalar();
                recipe.Id = id;
            }
        }

        public void Update(Recipe recipe)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spUpdateRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", recipe.Name);
                cmd.Parameters.AddWithValue("@Rating", recipe.Rating);
                cmd.Parameters.AddWithValue("@Difficulty", recipe.Difficulty);
                cmd.Parameters.AddWithValue("@Description", recipe.Description);
                cmd.Parameters.AddWithValue("@CookingTime", recipe.CookingTime);
                cmd.Parameters.AddWithValue("@IsValidated", recipe.IsValidated);

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

                    cmd.CommandText = "spRemoveRecipe";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RecipeId", id);

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
