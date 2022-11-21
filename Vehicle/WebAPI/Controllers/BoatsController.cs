using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatsController : ControllerBase
    {
        IBoatService _boatService;

        public  BoatsController(IBoatService boatService)
        {
            _boatService = boatService;
        }


        [HttpGet("getAll")]

        public IActionResult GetAll()
        {
            var result = _boatService.GetAll();

            return Ok(result);
        }


        [HttpGet("getBoatColor")]

        public IActionResult GetColor(string color)
        {
            var result = _boatService.GetColor(color);
            return Ok(result);
        }


        [HttpGet("getById")]

        public IActionResult GetById(int id)
        {
            var result = _boatService.GetId(id);
            return Ok(result);
        }


        [HttpPost("Add")]

        public IActionResult Add(Boat boat)
        {
            _boatService.Add(boat);
            return Ok();
        }
    }
}
