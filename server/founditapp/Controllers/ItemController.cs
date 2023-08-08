using System.Web.Http;

namespace founditapp.Controllers
{
    [RoutePrefix("api/items")]
    public class ItemController : ApiController
    {
        // GET: api/items
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("Response from ItemController");
        }

        // GET: api/items/5
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok($"Response for item with ID {id}");
        }

        // Other actions...
        // POST, PUT, DELETE, etc.
    }
}
