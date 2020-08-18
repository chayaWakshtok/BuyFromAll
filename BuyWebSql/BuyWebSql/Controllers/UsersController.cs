using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using System.Web.Http.Description;
using BuyWebSql.Models;
using Newtonsoft.Json;

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
            return db.users.FirstOrDefault(p => p.Password == user.Password && p.Email == user.Email);
        }

        [HttpPost]
        [Route("LoginFace")]
        public user LoginFace(string faceId)
        {
            return db.users.FirstOrDefault(p => p.FaceId == faceId);
        }
        // GET: api/Users
        public IQueryable<user> Getusers()
        {
            return db.users;
        }

        [Route("getUser")]
        public IHttpActionResult GetuserFace(string id)
        {
            user user = db.users.FirstOrDefault(p=>p.FaceId==id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // GET: api/Users/5
        [ResponseType(typeof(user))]
        public IHttpActionResult Getuser(int id)
        {
            MakeAnalysisRequest(@"C:\Users\user\Pictures\1888657.jpg");

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

         async void MakeAnalysisRequest(string imageFilePath)
        {
            HttpClient client = new HttpClient();

            // Request headers.
            client.DefaultRequestHeaders.Add(
                "Ocp-Apim-Subscription-Key", "eb2b6f51708d466da01dcffa62860379");

            // Request parameters. A third optional parameter is "details".
            string requestParameters = "returnFaceId=true&returnFaceLandmarks=false" +
                "&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses," +
                "emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";

            // Assemble the URI for the REST API Call.
            string uri = "https://buyfromall.cognitiveservices.azure.com/face/v1.0/detect/" + "?" + requestParameters;

            HttpResponseMessage response;

            // Request body. Posts a locally stored JPEG image.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                // This example uses content type "application/octet-stream".
                // The other content types you can use are "application/json"
                // and "multipart/form-data".
                content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/octet-stream");

                // Execute the REST API call.
                response = await client.PostAsync(uri, content);
                
                // Get the JSON response.
                string contentString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<FaceResult>>(contentString);

            }
        }

        static byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream =
                new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
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