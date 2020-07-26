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
    public class VatsController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/Vats
        public IQueryable<vat> Getvats()
        {
            return db.vats;
        }

        // GET: api/Vats/5
        [ResponseType(typeof(vat))]
        public IHttpActionResult Getvat(int id)
        {
            vat vat = db.vats.Find(id);
            if (vat == null)
            {
                return NotFound();
            }

            return Ok(vat);
        }

        // PUT: api/Vats/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putvat(int id, vat vat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vat.Id)
            {
                return BadRequest();
            }

            db.Entry(vat).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!vatExists(id))
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

        // POST: api/Vats
        [ResponseType(typeof(vat))]
        public IHttpActionResult Postvat(vat vat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.vats.Add(vat);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vat.Id }, vat);
        }

        // DELETE: api/Vats/5
        [ResponseType(typeof(vat))]
        public IHttpActionResult Deletevat(int id)
        {
            vat vat = db.vats.Find(id);
            if (vat == null)
            {
                return NotFound();
            }

            db.vats.Remove(vat);
            db.SaveChanges();

            return Ok(vat);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool vatExists(int id)
        {
            return db.vats.Count(e => e.Id == id) > 0;
        }
    }
}