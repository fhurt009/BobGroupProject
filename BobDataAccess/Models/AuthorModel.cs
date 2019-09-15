using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobDataAccess.Models
{
    public class AuthorModel
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
