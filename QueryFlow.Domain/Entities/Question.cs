using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QueryFlow.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public required string QuestionContent { get; set; }
    }
}
