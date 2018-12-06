using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Intex_2.DAL;
using Intex_2.Models;

namespace Intex_2.Controllers
{
    public class TestsController : ApiController
    {
        private DefaultConnection db = new DefaultConnection();

        // GET: api/Tests
        public IQueryable<Tests> GetTests()
        {
            return db.Tests;
        }

        // GET: api/Tests/5
        [ResponseType(typeof(Tests))]
        public IHttpActionResult GetTests(int id)
        {
            Tests tests = db.Tests.Find(id);
            if (tests == null)
            {
                return NotFound();
            }

            return Ok(tests);
        }

        // PUT: api/Tests/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTests(int id, Tests tests)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tests.testID)
            {
                return BadRequest();
            }

            db.Entry(tests).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Tests
        [ResponseType(typeof(Tests))]
        public IHttpActionResult PostTests(Tests tests)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tests.Add(tests);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tests.testID }, tests);
        }

        // DELETE: api/Tests/5
        [ResponseType(typeof(Tests))]
        public IHttpActionResult DeleteTests(int id)
        {
            Tests tests = db.Tests.Find(id);
            if (tests == null)
            {
                return NotFound();
            }

            db.Tests.Remove(tests);
            db.SaveChanges();

            return Ok(tests);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TestsExists(int id)
        {
            return db.Tests.Count(e => e.testID == id) > 0;
        }
    }
}