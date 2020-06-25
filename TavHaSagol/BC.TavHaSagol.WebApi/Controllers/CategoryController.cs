using AM.Common.BL;
using AM.Utils;
using BL;
using Entities.Retail;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Unity;

namespace BuyFromAllService.Controllers
{
    [RoutePrefix("api/Category")]
    
    public class CategoryController : ApiController
    {
        private Category _category;
        /// <summary>
        /// 
        /// </summary>
        public CategoryController()
        {
            _category = DIManager.Container.Resolve<Category>();
        }

        /// <summary>  
        /// retrun all category  
        /// </summary>  
        /// <returns></returns> 
        [Route("GetAll")]
        public async Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);

            try
            {
                ActionResult<List<CategoryEntity>> result = await _category.GetAll();

                //_logger.Info(JsonConvert.SerializeObject(result));


                if (result.Status != ActionStatus.Ok)
                {
                    response = Request.CreateErrorResponse
                        (
                        result.Status == ActionStatus.NotFound ? HttpStatusCode.NotFound : HttpStatusCode.InternalServerError,
                        result.FirstExeptionMessage()
                        );
                    //_logger.Error(result.Summary(), result.Exception);
                }
                else response = Request.CreateResponse(HttpStatusCode.OK, result.Result);

            }
            catch (Exception ex)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
                //_logger.Error("Failed to get retailers", ex);
            }

            return response;
        }

        // GET: api/Category/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Category
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> Post([FromBody] CategoryEntity value)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            ActionResult<CategoryEntity> result = new ActionResult<CategoryEntity>(ActionStatus.Ok);

            try
            {
                var resSave = await _category.SaveAsync(value);

                if (resSave.Status != ActionStatus.Ok)
                {
                    response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, resSave.FirstExeptionMessage());
                }
                response = Request.CreateResponse(HttpStatusCode.OK, value);
            }
            catch (Exception ex)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }

        // PUT: api/Category/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/Category/5
        public void Delete(int id)
        {

        }
    }
}
