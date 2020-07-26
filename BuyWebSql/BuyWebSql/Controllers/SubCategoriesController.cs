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
    public class SubCategoriesController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/SubCategories
        public IQueryable<sub_categories> Getsub_categories()
        {
            return db.sub_categories;
        }

        // GET: api/SubCategories/5
        [ResponseType(typeof(sub_categories))]
        public IHttpActionResult Getsub_categories(int id)
        {
            sub_categories sub_categories = db.sub_categories.Find(id);
            if (sub_categories == null)
            {
                return NotFound();
            }

            return Ok(sub_categories);
        }

        // PUT: api/SubCategories/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putsub_categories(int id, sub_categories sub_categories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sub_categories.Id)
            {
                return BadRequest();
            }

            db.Entry(sub_categories).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sub_categoriesExists(id))
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

        // POST: api/SubCategories
        [ResponseType(typeof(sub_categories))]
        public IHttpActionResult Postsub_categories(sub_categories sub_categories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sub_categories.Add(sub_categories);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sub_categories.Id }, sub_categories);
        }

        // DELETE: api/SubCategories/5
        [ResponseType(typeof(sub_categories))]
        public IHttpActionResult Deletesub_categories(int id)
        {
            sub_categories sub_categories = db.sub_categories.Find(id);
            if (sub_categories == null)
            {
                return NotFound();
            }

            db.sub_categories.Remove(sub_categories);
            db.SaveChanges();

            return Ok(sub_categories);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sub_categoriesExists(int id)
        {
            return db.sub_categories.Count(e => e.Id == id) > 0;
        }
    }
}