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
    public class SirketlerController : ControllerBase
    {
        ISirketService _sirketService;
        public SirketlerController(ISirketService sirketService)
        {
            _sirketService = sirketService;
        }
        [HttpPost("add")]
        public IActionResult Add(Sirket sirket)
        {
            var result = _sirketService.Add(sirket);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Sirket sirket)
        {
            var result = _sirketService.Delete(sirket);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Sirket sirket)
        {
            var result = _sirketService.Update(sirket);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sirketService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbysirketid")]
        public IActionResult GetBySirketId(int id)
        {
            var result = _sirketService.GetBySirketId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
