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
    public class PaymentsController : ApiController
    {
        private buyfromallEntities db = new buyfromallEntities();

        // GET: api/Payments
        public IQueryable<payment> Getpayments()
        {
            return db.payments;
        }

        // GET: api/Payments/5
        [ResponseType(typeof(payment))]
        public IHttpActionResult Getpayment(int id)
        {
            payment payment = db.payments.Find(id);
            if (payment == null)
            {
                return NotFound();
            }

            return Ok(payment);
        }

        // PUT: api/Payments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putpayment(int id, payment payment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != payment.Id)
            {
                return BadRequest();
            }

            db.Entry(payment).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!paymentExists(id))
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

        // POST: api/Payments
        [ResponseType(typeof(payment))]
        public IHttpActionResult Postpayment(payment payment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.payments.Add(payment);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = payment.Id }, payment);
        }

        // DELETE: api/Payments/5
        [ResponseType(typeof(payment))]
        public IHttpActionResult Deletepayment(int id)
        {
            payment payment = db.payments.Find(id);
            if (payment == null)
            {
                return NotFound();
            }

            db.payments.Remove(payment);
            db.SaveChanges();

            return Ok(payment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool paymentExists(int id)
        {
            return db.payments.Count(e => e.Id == id) > 0;
        }
    }
}