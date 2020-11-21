using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Model.Model
{
    public class Comment
    {
        public int Id { get; set; }

        public string CommentContent { get; set; }

        public DateTime CommentDate { get; set; }

        public bool IsValidated { get; set; }

        public User User { get; set; }

        public Recipe Recipe { get; set; }

        public Comment()
        {
        }

        public Comment(string commentContent, DateTime commentDate, bool isValidated)
        {
            CommentContent = commentContent;
            CommentDate = commentDate;
            IsValidated = isValidated;
        }
    }
}
