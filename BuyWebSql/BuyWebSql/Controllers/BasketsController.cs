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
    public class BasketsController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/baskets
        public IQueryable<basket> Getbaskets()
        {
            return db.baskets;
        }

        // GET: api/baskets/5
        [ResponseType(typeof(basket))]
        public IHttpActionResult Getbasket(int id)
        {
            basket basket = db.baskets.Find(id);
            if (basket == null)
            {
                return NotFound();
            }

            return Ok(basket);
        }

        // PUT: api/baskets/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putbasket(int id, basket basket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != basket.Id)
            {
                return BadRequest();
            }

            db.Entry(basket).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!basketExists(id))
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

        // POST: api/baskets
        [ResponseType(typeof(basket))]
        public IHttpActionResult Postbasket(basket basket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.baskets.Add(basket);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = basket.Id }, basket);
        }

        // DELETE: api/baskets/5
        [ResponseType(typeof(basket))]
        public IHttpActionResult Deletebasket(int id)
        {
            basket basket = db.baskets.Find(id);
            if (basket == null)
            {
                return NotFound();
            }

            db.baskets.Remove(basket);
            db.SaveChanges();

            return Ok(basket);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool basketExists(int id)
        {
            return db.baskets.Count(e => e.Id == id) > 0;
        }
    }
}