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
using BuyWebSql.Models;

namespace BuyWebSql.Controllers
{
    public class SizesController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/Sizes
        public IQueryable<size> Getsizes()
        {
            return db.sizes;
        }

        // GET: api/Sizes/5
        [ResponseType(typeof(size))]
        public IHttpActionResult Getsize(int id)
        {
            size size = db.sizes.Find(id);
            if (size == null)
            {
                return NotFound();
            }

            return Ok(size);
        }

        // PUT: api/Sizes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putsize(int id, size size)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != size.Id)
            {
                return BadRequest();
            }

            db.Entry(size).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sizeExists(id))
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

        // POST: api/Sizes
        [ResponseType(typeof(size))]
        public IHttpActionResult Postsize(size size)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sizes.Add(size);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = size.Id }, size);
        }

        // DELETE: api/Sizes/5
        [ResponseType(typeof(size))]
        public IHttpActionResult Deletesize(int id)
        {
            size size = db.sizes.Find(id);
            if (size == null)
            {
                return NotFound();
            }

            db.sizes.Remove(size);
            db.SaveChanges();

            return Ok(size);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sizeExists(int id)
        {
            return db.sizes.Count(e => e.Id == id) > 0;
        }
    }
}