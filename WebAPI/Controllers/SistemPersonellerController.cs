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
    public class SistemPersonellerController : ControllerBase
    {
        ISistemPersonelService _sistemPersonelService;
        public SistemPersonellerController(ISistemPersonelService sistemPersonelService)
        {
            _sistemPersonelService = sistemPersonelService;
        }
        [HttpPost("add")]
        public IActionResult Add(SistemPersonel sistemPersonel)
        {
            var result = _sistemPersonelService.Add(sistemPersonel);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(SistemPersonel sistemPersonel)
        {
            var result = _sistemPersonelService.Delete(sistemPersonel);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(SistemPersonel sistemPersonel)
        {
            var result = _sistemPersonelService.Update(sistemPersonel);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sistemPersonelService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbysistempersonelid")]
        public IActionResult GetBySistemPersonelId(int id)
        {
            var result = _sistemPersonelService.GetSistemPersonelId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
