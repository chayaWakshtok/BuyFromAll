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
    public class ManufacturersController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/Manufacturers
        public IQueryable<manufacturer> Getmanufacturers()
        {
            return db.manufacturers;
        }

        // GET: api/Manufacturers/5
        [ResponseType(typeof(manufacturer))]
        public IHttpActionResult Getmanufacturer(int id)
        {
            manufacturer manufacturer = db.manufacturers.Find(id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            return Ok(manufacturer);
        }

        // PUT: api/Manufacturers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putmanufacturer(int id, manufacturer manufacturer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != manufacturer.Id)
            {
                return BadRequest();
            }

            db.Entry(manufacturer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!manufacturerExists(id))
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

        // POST: api/Manufacturers
        [ResponseType(typeof(manufacturer))]
        public IHttpActionResult Postmanufacturer(manufacturer manufacturer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.manufacturers.Add(manufacturer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = manufacturer.Id }, manufacturer);
        }

        // DELETE: api/Manufacturers/5
        [ResponseType(typeof(manufacturer))]
        public IHttpActionResult Deletemanufacturer(int id)
        {
            manufacturer manufacturer = db.manufacturers.Find(id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            db.manufacturers.Remove(manufacturer);
            db.SaveChanges();

            return Ok(manufacturer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool manufacturerExists(int id)
        {
            return db.manufacturers.Count(e => e.Id == id) > 0;
        }
    }
}