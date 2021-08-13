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
    public class YetenekTiplerController : ControllerBase
    {
        IYetenekTipService _yetenekTipService;
        public YetenekTiplerController(IYetenekTipService yetenekTipService)
        {
            _yetenekTipService = yetenekTipService;
        }
        public IActionResult Add(YetenekTip yetenekTip)
        {
            var result = _yetenekTipService.Add(yetenekTip);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(YetenekTip yetenekTip)
        {
            var result = _yetenekTipService.Delete(yetenekTip);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(YetenekTip yetenekTip)
        {
            var result = _yetenekTipService.Update(yetenekTip);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _yetenekTipService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyyetenektipid")]
        public IActionResult GetByYetenekTipId(int yetenekTipId)
        {
            var result = _yetenekTipService.GetByYetenekTipId(yetenekTipId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
