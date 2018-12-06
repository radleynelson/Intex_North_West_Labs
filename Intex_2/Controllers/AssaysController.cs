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
    public class AssaysController : ApiController
    {
        private DefaultConnection db = new DefaultConnection();

        // GET: api/Assays
        public IQueryable<Assays> GetAssays()
        {
            return db.Assays;
        }

        // GET: api/Assays/5
        [ResponseType(typeof(Assays))]
        public IHttpActionResult GetAssays(int id)
        {
            Assays assays = db.Assays.Find(id);
            if (assays == null)
            {
                return NotFound();
            }

            return Ok(assays);
        }

        // PUT: api/Assays/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAssays(int id, Assays assays)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != assays.assayID)
            {
                return BadRequest();
            }

            db.Entry(assays).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssaysExists(id))
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

        // POST: api/Assays
        [ResponseType(typeof(Assays))]
        public IHttpActionResult PostAssays(Assays assays)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Assays.Add(assays);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = assays.assayID }, assays);
        }

        // DELETE: api/Assays/5
        [ResponseType(typeof(Assays))]
        public IHttpActionResult DeleteAssays(int id)
        {
            Assays assays = db.Assays.Find(id);
            if (assays == null)
            {
                return NotFound();
            }

            db.Assays.Remove(assays);
            db.SaveChanges();

            return Ok(assays);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AssaysExists(int id)
        {
            return db.Assays.Count(e => e.assayID == id) > 0;
        }
    }
}