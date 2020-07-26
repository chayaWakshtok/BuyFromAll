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
    public class FeaturesController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/Features
        public IQueryable<feature> Getfeatures()
        {
            return db.features;
        }

        // GET: api/Features/5
        [ResponseType(typeof(feature))]
        public IHttpActionResult Getfeature(int id)
        {
            feature feature = db.features.Find(id);
            if (feature == null)
            {
                return NotFound();
            }

            return Ok(feature);
        }

        // PUT: api/Features/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putfeature(int id, feature feature)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != feature.Id)
            {
                return BadRequest();
            }

            db.Entry(feature).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!featureExists(id))
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

        // POST: api/Features
        [ResponseType(typeof(feature))]
        public IHttpActionResult Postfeature(feature feature)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.features.Add(feature);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = feature.Id }, feature);
        }

        // DELETE: api/Features/5
        [ResponseType(typeof(feature))]
        public IHttpActionResult Deletefeature(int id)
        {
            feature feature = db.features.Find(id);
            if (feature == null)
            {
                return NotFound();
            }

            db.features.Remove(feature);
            db.SaveChanges();

            return Ok(feature);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool featureExists(int id)
        {
            return db.features.Count(e => e.Id == id) > 0;
        }
    }
}