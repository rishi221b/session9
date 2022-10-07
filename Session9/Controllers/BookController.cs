using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session9.Services;

namespace Session9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;
        public BookController(IBookService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _service.GetAllItems();
            return Ok(items);
        }
    }
}
