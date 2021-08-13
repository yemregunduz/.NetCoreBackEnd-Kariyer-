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
    public class TakiplerController : ControllerBase
    {
        ITakipService _takipService;
        public TakiplerController(ITakipService takipService)
        {
            _takipService = takipService;
        }
        [HttpPost("add")]
        public IActionResult Add(Takip takip)
        {
            var result = _takipService.Add(takip);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Takip takip)
        {
            var result = _takipService.Delete(takip);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalltakipcilerbyadayid")]
        public IActionResult GetAllTakipcilerByAdayId(int adayId)
        {
            var result = _takipService.GetAllTakipcilerByAdayId(adayId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalltakipedilenlerbyadayid")]
        public IActionResult GetAllTakipEdilenlerByTakipciId(int adayId)
        {
            var result = _takipService.GetAllTakipEdilenlerByAdayId(adayId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("checkifuseralreadyfollow")]
        public IActionResult CheckIfUserAlreadyFollow(int takipciId,int takipEdilenId)
        {
            var result = _takipService.CheckIfUserAlreadFollow(takipciId, takipEdilenId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        [HttpGet("gettakipbytakipciandtakipedilenid")]
        public IActionResult GetTakipByTakipciAndTakipEdilenId(int takipciId,int takipEdilenId)
        {
            var result = _takipService.GetTakipByTakipciAndTakipEdilenId(takipciId, takipEdilenId);
            if (result.Success==true)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getalltakipedilenlertopthreebyadayid")]
        public IActionResult GetAllTakipEdilenlerTopThreeByAdayId(int adayId)
        {
            var result = _takipService.GetAllTakipEdilenlerTop3ByAdayId(adayId);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
                
        }
    }
}   
