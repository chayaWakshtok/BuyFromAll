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
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();
        //Login
        [HttpPost]
        [Route("Login")]
        public user Login(user user)
        {
            return db.users.FirstOrDefault(p=>p.Password==user.Password&&p.Email==user.Email);
        }
        // GET: api/Users
        public IQueryable<user> Getusers()
        {
            return db.users;
        }

        // GET: api/Users/5
        [ResponseType(typeof(user))]
        public IHttpActionResult Getuser(int id)
        {
            user user = db.users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putuser(int id, user user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.Id)
            {
                return BadRequest();
            }

            db.Entry(user).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!userExists(id))
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

        // POST: api/Users
        [ResponseType(typeof(user))]
        public IHttpActionResult Postuser(user user)
        {
            user.city = null;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.users.Add(user);
            db.SaveChanges();

            return Ok(user);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(user))]
        public IHttpActionResult Deleteuser(int id)
        {
            user user = db.users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            db.users.Remove(user);
            db.SaveChanges();

            return Ok(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool userExists(int id)
        {
            return db.users.Count(e => e.Id == id) > 0;
        }

    }
}