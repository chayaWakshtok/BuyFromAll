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
    public class SearchesController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/Searches
        public IQueryable<search> Getsearches()
        {
            return db.searches;
        }

        // GET: api/Searches/5
        [ResponseType(typeof(search))]
        public IHttpActionResult Getsearch(int id)
        {
            search search = db.searches.Find(id);
            if (search == null)
            {
                return NotFound();
            }

            return Ok(search);
        }

        // PUT: api/Searches/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putsearch(int id, search search)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != search.Id)
            {
                return BadRequest();
            }

            db.Entry(search).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!searchExists(id))
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

        // POST: api/Searches
        [ResponseType(typeof(search))]
        public IHttpActionResult Postsearch(search search)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.searches.Add(search);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = search.Id }, search);
        }

        // DELETE: api/Searches/5
        [ResponseType(typeof(search))]
        public IHttpActionResult Deletesearch(int id)
        {
            search search = db.searches.Find(id);
            if (search == null)
            {
                return NotFound();
            }

            db.searches.Remove(search);
            db.SaveChanges();

            return Ok(search);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool searchExists(int id)
        {
            return db.searches.Count(e => e.Id == id) > 0;
        }
    }
}