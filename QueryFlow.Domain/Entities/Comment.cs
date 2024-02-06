using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryFlow.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public required string CommentContent { get; set; }
        public string CommentedBy { get; set; }
        public Comment Parent { get; set; }
        public Question ParentQuestion { get; set; }
    }
}
