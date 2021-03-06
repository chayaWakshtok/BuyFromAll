﻿using System;
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
    public class SitesController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/Sites
        public IQueryable<site> Getsites()
        {
            return db.sites;
        }

        // GET: api/Sites/5
        [ResponseType(typeof(site))]
        public IHttpActionResult Getsite(int id)
        {
            site site = db.sites.Find(id);
            if (site == null)
            {
                return NotFound();
            }

            return Ok(site);
        }

        // PUT: api/Sites/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putsite(int id, site site)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != site.Id)
            {
                return BadRequest();
            }

            db.Entry(site).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!siteExists(id))
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

        // POST: api/Sites
        [ResponseType(typeof(site))]
        public IHttpActionResult Postsite(site site)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sites.Add(site);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = site.Id }, site);
        }

        // DELETE: api/Sites/5
        [ResponseType(typeof(site))]
        public IHttpActionResult Deletesite(int id)
        {
            site site = db.sites.Find(id);
            if (site == null)
            {
                return NotFound();
            }

            db.sites.Remove(site);
            db.SaveChanges();

            return Ok(site);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool siteExists(int id)
        {
            return db.sites.Count(e => e.Id == id) > 0;
        }
    }
}