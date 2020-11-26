using SiteRecipe.Data.Repositories;
using SiteRecipe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Services.Services
{
    public class CommentService
    {
        private CommentRepository _repo;

        public CommentService()
        {
            _repo = new CommentRepository();
        }

        public List<Comment> GetAll()
        {
            return _repo.GetAll();
        }

        public Comment GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Comment comment)
        {
            _repo.Add(comment);
        }

        public void Update(Comment comment)
        {
            _repo.Update(comment);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
