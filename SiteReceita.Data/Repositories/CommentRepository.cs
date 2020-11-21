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
    public class CommentRepository
    {
        private static string _cs = ConfigurationManager.ConnectionStrings["Recipes"].ConnectionString;
        private static int _colCommentId = 0;
        private static int _colCommentContent = 1;
        private static int _colCommentDate = 2;
        private static int _colIsValidated = 3;

        public List<Comment> GetAll()
        {
            List<Comment> tempList = new List<Comment>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetAllComments";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Comment comment = new Comment()
                    {
                        Id = dr.GetInt32(_colCommentId),
                        CommentContent = dr.GetString(_colCommentContent),
                        CommentDate = dr.GetDateTime(_colCommentDate),
                        IsValidated = dr.GetBoolean(_colIsValidated)
                    };
                    tempList.Add(comment);
                }
            }
            return tempList;
        }

        public Comment GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spGetByIdComment";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Comment comment = new Comment()
                    {
                        Id = dr.GetInt32(_colCommentId),
                        CommentContent = dr.GetString(_colCommentContent),
                        CommentDate = dr.GetDateTime(_colCommentDate),
                        IsValidated = dr.GetBoolean(_colIsValidated)
                    };

                    return comment;
                }
            }

            throw new Exception("There is no comment with the id: " + id);
        }

        public void Add(Comment comment)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spAddComment";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter cContentParam = new SqlParameter();
                cContentParam.ParameterName = "@CommentContent";
                cContentParam.Value = comment.CommentContent;
                cContentParam.Direction = ParameterDirection.Input;
                cContentParam.SqlDbType = SqlDbType.NVarChar;

                SqlParameter cDateParam = new SqlParameter();
                cDateParam.ParameterName = "@CommentDate";
                cDateParam.Value = comment.CommentDate;
                cDateParam.Direction = ParameterDirection.Input;
                cDateParam.SqlDbType = SqlDbType.Date;

                SqlParameter isValidParam = new SqlParameter();
                isValidParam.ParameterName = "@IsValidated";
                isValidParam.Value = comment.IsValidated;
                isValidParam.Direction = ParameterDirection.Input;
                isValidParam.SqlDbType = SqlDbType.Bit;

                cmd.Parameters.Add(cContentParam);
                cmd.Parameters.Add(cDateParam);
                cmd.Parameters.Add(isValidParam);

                conn.Open();
                int id = (int)cmd.ExecuteScalar();
                comment.Id = id;
            }
        }

        public void Update(Comment comment)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spUpdateComment";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CommentContent", comment.CommentContent);
                cmd.Parameters.AddWithValue("@CommentDate", comment.CommentDate);
                cmd.Parameters.AddWithValue("@IsValidated", comment.IsValidated);

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

                    cmd.CommandText = "spRemoveComment";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CommentId", id);

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
