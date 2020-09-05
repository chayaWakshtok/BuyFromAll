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
    public class collaborationDatasController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/collaborationDatas
        public IQueryable<collaborationData> GetcollaborationDatas()
        {
            return db.collaborationDatas;
        }

        // GET: api/collaborationDatas/5
        [ResponseType(typeof(collaborationData))]
        public IHttpActionResult GetcollaborationData(int id)
        {
            collaborationData collaborationData = db.collaborationDatas.Find(id);
            if (collaborationData == null)
            {
                return NotFound();
            }

            return Ok(collaborationData);
        }

        // PUT: api/collaborationDatas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutcollaborationData(int id, collaborationData collaborationData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != collaborationData.id)
            {
                return BadRequest();
            }

            db.Entry(collaborationData).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!collaborationDataExists(id))
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

        // POST: api/collaborationDatas
        [ResponseType(typeof(collaborationData))]
        public IHttpActionResult PostcollaborationData(collaborationData collaborationData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.collaborationDatas.Add(collaborationData);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = collaborationData.id }, collaborationData);
        }

        // DELETE: api/collaborationDatas/5
        [ResponseType(typeof(collaborationData))]
        public IHttpActionResult DeletecollaborationData(int id)
        {
            collaborationData collaborationData = db.collaborationDatas.Find(id);
            if (collaborationData == null)
            {
                return NotFound();
            }

            db.collaborationDatas.Remove(collaborationData);
            db.SaveChanges();

            return Ok(collaborationData);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool collaborationDataExists(int id)
        {
            return db.collaborationDatas.Count(e => e.id == id) > 0;
        }
    }
}