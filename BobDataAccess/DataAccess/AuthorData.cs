using BobDataAccess.Internal.DataAccess;
using BobDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobDataAccess.DataAccess
{
    public class AuthorData
    {
        public List<AuthorModel> GetAuthorById(int id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = id };

            var output = sql.LoadData<AuthorModel, dynamic>("dbo.spAuthorLookup", p, "DefaultConnection");

            return output;
        }

        public List<AuthorModel> GetAuthors()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<AuthorModel, dynamic>("dbo.spAuthor_GetAll", new { }, "DefaultConnection");

            return output;
        }
    }
}
