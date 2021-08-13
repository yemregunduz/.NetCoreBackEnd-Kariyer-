
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
    public class YeteneklerController : ControllerBase
    {
        IYetenekService _yetenekService;
        public YeteneklerController(IYetenekService yetenekService)
        {
            _yetenekService = yetenekService;
        }
        public IActionResult Add(Yetenek yetenek)
        {
            var result = _yetenekService.Add(yetenek);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Yetenek yetenek)
        {
            var result = _yetenekService.Delete(yetenek);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Yetenek yetenek)
        {
            var result = _yetenekService.Update(yetenek);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _yetenekService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyyetenekid")]
        public IActionResult GetByYetenekId(int yetenekId)
        {
            var result = _yetenekService.GetByYetenekId(yetenekId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallyetenekdetaydtobysearchfilter")]
        public IActionResult GetAllYetenekDetaydto(string filterText)
        {
            var result = _yetenekService.GetAllYetenekDetayDtoBySearchFilter(filterText);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
