using Core.DTOs;
using Core.Exceptions;
using Core.Interfaces;
using Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Numerics;

namespace ferrari_api_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly FerrariService carService;

        public CarsController(FerrariService carService)
        {
            this.carService = carService;
        }

        [HttpGet("collection")]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            return Ok(carService.GetAll());
        }

        [HttpGet("/get/{id}")]
        [AllowAnonymous]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(carService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CarDTO car)
        {
            if (!ModelState.IsValid) return BadRequest();

            carService.Create(car);

            return Ok();
        }

        [HttpPut]
        public IActionResult Edit([FromBody] CarDTO car)
        {
            if (!ModelState.IsValid) return BadRequest();

            carService.Edit(car);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            carService.Delete(id);
            return Ok();
        }
    }
}
