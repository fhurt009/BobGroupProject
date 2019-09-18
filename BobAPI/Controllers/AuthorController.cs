using BobDataAccess.DataAccess;
using BobDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BobAPI.Controllers
{
    public class AuthorController : ApiController
    {
        // GET: api/Author Dayana Sucks
        public List<AuthorModel> Get()
        {
            AuthorData data = new AuthorData();

            return data.GetAuthors();
        }

        // GET: api/Author/5
        public List<AuthorModel> GetById(int id)
        {

            AuthorData data = new AuthorData();

            return data.GetAuthorById(id);
        }

        // POST: api/Author
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Author/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Author/5
        public void Delete(int id)
        {
        }
    }
}
