using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BolumlerController : ControllerBase
    {
        IBolumService _bolumService;
        public BolumlerController(IBolumService bolumService)
        {
            _bolumService = bolumService;
        }
        [HttpPost("add")]
        public IActionResult Add(Bolum bolum)
        {
            var result = _bolumService.Add(bolum);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Bolum bolum)
        {
            var result = _bolumService.Delete(bolum);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Bolum bolum)
        {
            var result = _bolumService.Update(bolum);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bolumService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("geybybolumid")]
        public IActionResult GetByBolumId(int id)
        {
            var result = _bolumService.GetByBolumId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
