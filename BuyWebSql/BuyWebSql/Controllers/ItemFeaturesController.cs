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
    public class ItemFeaturesController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/ItemFeatures
        public IQueryable<item_features> Getitem_features()
        {
            return db.item_features;
        }

        // GET: api/ItemFeatures/5
        [ResponseType(typeof(item_features))]
        public IHttpActionResult Getitem_features(int id)
        {
            item_features item_features = db.item_features.Find(id);
            if (item_features == null)
            {
                return NotFound();
            }

            return Ok(item_features);
        }

        // PUT: api/ItemFeatures/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putitem_features(int id, item_features item_features)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != item_features.Id)
            {
                return BadRequest();
            }

            db.Entry(item_features).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!item_featuresExists(id))
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

        // POST: api/ItemFeatures
        [ResponseType(typeof(item_features))]
        public IHttpActionResult Postitem_features(item_features item_features)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.item_features.Add(item_features);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = item_features.Id }, item_features);
        }

        // DELETE: api/ItemFeatures/5
        [ResponseType(typeof(item_features))]
        public IHttpActionResult Deleteitem_features(int id)
        {
            item_features item_features = db.item_features.Find(id);
            if (item_features == null)
            {
                return NotFound();
            }

            db.item_features.Remove(item_features);
            db.SaveChanges();

            return Ok(item_features);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool item_featuresExists(int id)
        {
            return db.item_features.Count(e => e.Id == id) > 0;
        }
    }
}