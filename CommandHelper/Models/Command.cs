using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandHelper.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string CMDSnippet { get; set; }
        public string Platform { get; set; }
    }
}
