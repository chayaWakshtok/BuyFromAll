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
    public class UserCommentController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/UserComment
        public IQueryable<User_Comment> GetUser_Comment()
        {
            return db.User_Comment;
        }

        // GET: api/UserComment/5
        [ResponseType(typeof(User_Comment))]
        public IHttpActionResult GetUser_Comment(int id)
        {
            User_Comment user_Comment = db.User_Comment.Find(id);
            if (user_Comment == null)
            {
                return NotFound();
            }

            return Ok(user_Comment);
        }

        // PUT: api/UserComment/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser_Comment(int id, User_Comment user_Comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user_Comment.Id)
            {
                return BadRequest();
            }

            db.Entry(user_Comment).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User_CommentExists(id))
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

        // POST: api/UserComment
        [ResponseType(typeof(User_Comment))]
        public IHttpActionResult PostUser_Comment(User_Comment user_Comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.User_Comment.Add(user_Comment);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = user_Comment.Id }, user_Comment);
        }

        // DELETE: api/UserComment/5
        [ResponseType(typeof(User_Comment))]
        public IHttpActionResult DeleteUser_Comment(int id)
        {
            User_Comment user_Comment = db.User_Comment.Find(id);
            if (user_Comment == null)
            {
                return NotFound();
            }

            db.User_Comment.Remove(user_Comment);
            db.SaveChanges();

            return Ok(user_Comment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool User_CommentExists(int id)
        {
            return db.User_Comment.Count(e => e.Id == id) > 0;
        }
    }
}