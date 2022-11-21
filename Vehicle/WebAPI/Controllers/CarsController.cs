using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
         ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getAll")]

        public IActionResult GetAll()
        {
            var result = _carService.GetAll();

            return Ok(result);
        }


        [HttpGet("getCarColor")]

        public IActionResult GetColor(string color)
        {
            var result = _carService.GetColor(color);
            return Ok(result);
        }


        [HttpGet("getById")]

        public IActionResult GetById(int id)
        {
            var result = _carService.GetId(id);
            return Ok(result);
        }


        [HttpPost("Add")]

        public IActionResult Add(Car car)
        {
            _carService.Add(car);
            return Ok();
        }

        [HttpPut ("deleteCar")]
        public IActionResult Delete(Car car)
        {
            _carService.Delete(car);
            return Ok();
        }
        

    }
}
