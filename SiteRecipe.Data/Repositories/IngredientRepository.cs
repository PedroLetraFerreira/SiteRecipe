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
    public class IngredientRepository
    {
        private static string _cs = ConfigurationManager.ConnectionStrings["Recipes"].ConnectionString;
        private static int _colIngredientId = 0;
        private static int _colName = 1;
        private static int _colQuantity = 2;
        private static int _colMeasurementUnit = 3;

        public List<Ingredient> GetAll()
        {
            List<Ingredient> tempList = new List<Ingredient>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetAllIngredients";
                cmd.CommandType = CommandType.StoredProcedure;
                
                //string query = "SELECT * FROM Ingredients";
                //SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Ingredient ingredient = new Ingredient()
                    {
                        Id = dr.GetInt32(_colIngredientId),
                        Name = dr.GetString(_colName),
                        Quantity = dr.GetDouble(_colQuantity),
                        MeasurementUnit = dr.GetString(_colMeasurementUnit)
                    };
                    tempList.Add(ingredient);
                }
            }
            return tempList;
        }

        public Ingredient GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetByIdIngredient";
                cmd.CommandType = CommandType.StoredProcedure; 
                
                //string query = $"SELECT * FROM Ingredients WHERE IdIngredient = {id}";
                //SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Ingredient ingredient = new Ingredient()
                    {
                        Id = dr.GetInt32(_colIngredientId),
                        Name = dr.GetString(_colName),
                        Quantity = dr.GetDouble(_colQuantity),
                        MeasurementUnit = dr.GetString(_colMeasurementUnit)
                    };

                    return ingredient;
                }
            }

            throw new Exception("There is no ingredient with the id: " + id);
        }

        public void Add(Ingredient ingredient)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spAddIngredient";
                cmd.CommandType = CommandType.StoredProcedure;
                
                /*string query = $"INSERT INTO Ingredients " +
                               $"VALUES (@ingName, @ingQuantity, @ingMeasurementUnit);" +
                               $"SELECT cast(Scope_Identity() as int);";
                SqlCommand cmd = new SqlCommand(query, conn);*/

                SqlParameter nameParam = new SqlParameter();
                nameParam.ParameterName = "@Name";
                nameParam.Value = ingredient.Name;
                nameParam.Direction = ParameterDirection.Input;
                nameParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter quantityParam = new SqlParameter();
                quantityParam.ParameterName = "@Quantity";
                quantityParam.Value = ingredient.Quantity;
                quantityParam.Direction = ParameterDirection.Input;
                quantityParam.SqlDbType = SqlDbType.Real;

                SqlParameter measurementUnitParam = new SqlParameter();
                measurementUnitParam.ParameterName = "@MeasurementUnit";
                measurementUnitParam.Value = ingredient.MeasurementUnit;
                measurementUnitParam.Direction = ParameterDirection.Input;
                measurementUnitParam.SqlDbType = SqlDbType.NVarChar;

                cmd.Parameters.Add(nameParam);
                cmd.Parameters.Add(quantityParam);
                cmd.Parameters.Add(measurementUnitParam);

                conn.Open();
                int id = (int)cmd.ExecuteScalar();
                ingredient.Id = id;
            }
        }

        public void Update(Ingredient ingredient)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spUpdateIngredient";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", ingredient.Name);
                cmd.Parameters.AddWithValue("@Quantity", ingredient.Quantity);
                cmd.Parameters.AddWithValue("@MeasurementUnit", ingredient.MeasurementUnit);

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

                    cmd.CommandText = "spRemoveIngredient";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IngredientId", id);

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
