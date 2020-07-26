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
    public class ShippingsController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/Shippings
        public IQueryable<shipping> Getshippings()
        {
            return db.shippings;
        }

        // GET: api/Shippings/5
        [ResponseType(typeof(shipping))]
        public IHttpActionResult Getshipping(int id)
        {
            shipping shipping = db.shippings.Find(id);
            if (shipping == null)
            {
                return NotFound();
            }

            return Ok(shipping);
        }

        // PUT: api/Shippings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putshipping(int id, shipping shipping)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shipping.Id)
            {
                return BadRequest();
            }

            db.Entry(shipping).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!shippingExists(id))
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

        // POST: api/Shippings
        [ResponseType(typeof(shipping))]
        public IHttpActionResult Postshipping(shipping shipping)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.shippings.Add(shipping);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = shipping.Id }, shipping);
        }

        // DELETE: api/Shippings/5
        [ResponseType(typeof(shipping))]
        public IHttpActionResult Deleteshipping(int id)
        {
            shipping shipping = db.shippings.Find(id);
            if (shipping == null)
            {
                return NotFound();
            }

            db.shippings.Remove(shipping);
            db.SaveChanges();

            return Ok(shipping);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool shippingExists(int id)
        {
            return db.shippings.Count(e => e.Id == id) > 0;
        }
    }
}