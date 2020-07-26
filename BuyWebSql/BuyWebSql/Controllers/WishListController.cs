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
    public class WishListController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/WishList
        [Route("GetWishByUser")]
        public List<wish_list> Getwish_listByUser(int userId)
        {
            return db.wish_list.Where(p=>p.UserId==userId).ToList();
        }

        // GET: api/WishList/5
        [ResponseType(typeof(wish_list))]
        public IHttpActionResult Getwish_list(int id)
        {
            wish_list wish_list = db.wish_list.Find(id);
            if (wish_list == null)
            {
                return NotFound();
            }

            return Ok(wish_list);
        }

        // PUT: api/WishList/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putwish_list(int id, wish_list wish_list)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wish_list.Id)
            {
                return BadRequest();
            }

            db.Entry(wish_list).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!wish_listExists(id))
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

        // POST: api/WishList
        [ResponseType(typeof(wish_list))]
        public IHttpActionResult Postwish_list(wish_list wish_list)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.wish_list.Add(wish_list);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = wish_list.Id }, wish_list);
        }

        // DELETE: api/WishList/5
        [ResponseType(typeof(wish_list))]
        public IHttpActionResult Deletewish_list(int id)
        {
            wish_list wish_list = db.wish_list.Find(id);
            if (wish_list == null)
            {
                return NotFound();
            }

            db.wish_list.Remove(wish_list);
            db.SaveChanges();

            return Ok(wish_list);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool wish_listExists(int id)
        {
            return db.wish_list.Count(e => e.Id == id) > 0;
        }
    }
}