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
    public class SehirlerController : ControllerBase
    {
        ISehirService _sehirService;
        public SehirlerController(ISehirService sehirService)
        {
            _sehirService = sehirService;
        }
        [HttpPost("add")]
        public IActionResult Add(Sehir sehir)
        {
            var result = _sehirService.Add(sehir);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Sehir sehir)
        {
            var result = _sehirService.Delete(sehir);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Sehir sehir)
        {
            var result = _sehirService.Update(sehir);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sehirService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbysehirid")]
        public IActionResult GetBySehirId(int id)
        {
            var result = _sehirService.GetBySehirId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
