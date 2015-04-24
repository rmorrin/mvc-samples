using MVCSamples.DataAccess;
using MVCSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCSamples.Controllers.Api
{
    public class PersonController : ApiController
    {
        private static readonly Database _database = new Database();

        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            return _database.People;
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            return _database.People.FirstOrDefault(p => p.Id == id);
        }

        // POST: api/Person
        public string Post([FromBody]Person data)
        {
            return string.Format("Message from server: Hello {0} {1}!", data.FirstName, data.Surname);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]Person data)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
