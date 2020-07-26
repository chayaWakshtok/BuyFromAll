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
    public class ColorsController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/Colors
        public IQueryable<color> Getcolors()
        {
            return db.colors;
        }

        // GET: api/Colors/5
        [ResponseType(typeof(color))]
        public IHttpActionResult Getcolor(int id)
        {
            color color = db.colors.Find(id);
            if (color == null)
            {
                return NotFound();
            }

            return Ok(color);
        }

        // PUT: api/Colors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putcolor(int id, color color)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != color.Id)
            {
                return BadRequest();
            }

            db.Entry(color).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!colorExists(id))
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

        // POST: api/Colors
        [ResponseType(typeof(color))]
        public IHttpActionResult Postcolor(color color)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.colors.Add(color);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = color.Id }, color);
        }

        // DELETE: api/Colors/5
        [ResponseType(typeof(color))]
        public IHttpActionResult Deletecolor(int id)
        {
            color color = db.colors.Find(id);
            if (color == null)
            {
                return NotFound();
            }

            db.colors.Remove(color);
            db.SaveChanges();

            return Ok(color);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool colorExists(int id)
        {
            return db.colors.Count(e => e.Id == id) > 0;
        }
    }
}