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
    public class Work_OrdersController : ApiController
    {
        private DefaultConnection db = new DefaultConnection();

        // GET: api/Work_Orders
        public IQueryable<Work_Orders> GetWork_Orders()
        {
            return db.Work_Orders;
        }

        // GET: api/Work_Orders/5
        [ResponseType(typeof(Work_Orders))]
        public IHttpActionResult GetWork_Orders(int id)
        {
            Work_Orders work_Orders = db.Work_Orders.Find(id);
            if (work_Orders == null)
            {
                return NotFound();
            }

            return Ok(work_Orders);
        }

        // PUT: api/Work_Orders/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWork_Orders(int id, Work_Orders work_Orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != work_Orders.workOrderID)
            {
                return BadRequest();
            }

            db.Entry(work_Orders).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Work_OrdersExists(id))
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

        // POST: api/Work_Orders
        [ResponseType(typeof(Work_Orders))]
        public IHttpActionResult PostWork_Orders(Work_Orders work_Orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Work_Orders.Add(work_Orders);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = work_Orders.workOrderID }, work_Orders);
        }

        // DELETE: api/Work_Orders/5
        [ResponseType(typeof(Work_Orders))]
        public IHttpActionResult DeleteWork_Orders(int id)
        {
            Work_Orders work_Orders = db.Work_Orders.Find(id);
            if (work_Orders == null)
            {
                return NotFound();
            }

            db.Work_Orders.Remove(work_Orders);
            db.SaveChanges();

            return Ok(work_Orders);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Work_OrdersExists(int id)
        {
            return db.Work_Orders.Count(e => e.workOrderID == id) > 0;
        }
    }
}