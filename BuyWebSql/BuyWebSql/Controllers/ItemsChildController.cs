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
    public class ItemsChildController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/ItemsChild
        public IQueryable<items_child> Getitems_child()
        {
            return db.items_child;
        }

        // GET: api/ItemsChild/5
        [ResponseType(typeof(items_child))]
        public IHttpActionResult Getitems_child(int id)
        {
            items_child items_child = db.items_child.Find(id);
            if (items_child == null)
            {
                return NotFound();
            }

            return Ok(items_child);
        }

        // PUT: api/ItemsChild/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putitems_child(int id, items_child items_child)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != items_child.Id)
            {
                return BadRequest();
            }

            db.Entry(items_child).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!items_childExists(id))
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

        // POST: api/ItemsChild
        [ResponseType(typeof(items_child))]
        public IHttpActionResult Postitems_child(items_child items_child)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.items_child.Add(items_child);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = items_child.Id }, items_child);
        }

        // DELETE: api/ItemsChild/5
        [ResponseType(typeof(items_child))]
        public IHttpActionResult Deleteitems_child(int id)
        {
            items_child items_child = db.items_child.Find(id);
            if (items_child == null)
            {
                return NotFound();
            }

            db.items_child.Remove(items_child);
            db.SaveChanges();

            return Ok(items_child);
        }

        [HttpGet]
        [Route("GetLighteningDeal")]
        public IHttpActionResult GetLighteningDeal()
        {
            try
            {
                List<items_child> items_Children = db.items_child.OrderBy(p => p.PresentLess).Take(4).ToList();
                return Ok(items_Children);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("GetNewItems")]
        public IHttpActionResult GetNewItem()
        {
            try
            {
                List<items_child> items_Children = db.items_child.OrderBy(p => p.CreationDate).Take(4).ToList();
                return Ok(items_Children);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool items_childExists(int id)
        {
            return db.items_child.Count(e => e.Id == id) > 0;
        }
    }
}