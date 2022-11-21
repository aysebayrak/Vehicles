using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : ControllerBase
    {
        IBusService _busService;

        public BusesController (IBusService busService)
        {
            _busService = busService; 
        }


        [HttpGet ("getAll")]

        public  IActionResult GetAll()
        {
            var result = _busService.GetAll();

            return Ok(result);
        }


        [HttpGet("getBusColor")]

        public IActionResult GetColor(string color)
        {
            var result = _busService.GetColor(color);
            return Ok(result);
        }


        [HttpGet("getById")]

        public IActionResult GetById(int id)
        {
            var result = _busService.GetId(id);
            return Ok(result);
        }


        [HttpPost("Add")]
        
        public IActionResult Add(Bus bus)
        {
            _busService.Add(bus);
            return Ok();    
        }


    }
}
