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
    public class AdayYeteneklerController : ControllerBase
    {
        IAdayYetenekService _adayYetenekService;
        public AdayYeteneklerController(IAdayYetenekService adayYetenekService)
        {
            _adayYetenekService = adayYetenekService;
        }
        [HttpPost("add")]
        public IActionResult Add(AdayYetenek adayYetenek)
        {
            var result = _adayYetenekService.Add(adayYetenek);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(AdayYetenek adayYetenek)
        {
            var result = _adayYetenekService.Delete(adayYetenek);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(AdayYetenek adayYetenek)
        {
            var result = _adayYetenekService.Update(adayYetenek);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _adayYetenekService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalladayyetenekdetaydtobyadayid")]
        public IActionResult GetAllAdayYetenekDetayDtoByAdayId(int adayId)
        {
            var result = _adayYetenekService.GetAllAdayYetenekDetayDtoByAdayId(adayId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalladayyetenekdetaydtobyadayidandyetenektipid")]
        public IActionResult GetAllAdayYetenekDetayDtoByAdayIdAndYetenekTipId(int adayId, int yetenekTipId)
        {
            var result = _adayYetenekService.GetAllAdayYetenekDetayDtoByAdayIdAndYetenekTipId(adayId, yetenekTipId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("yetenekexist")]
        public IActionResult YetenekExist(int adayId,int yetenekId)
        {
            var result = _adayYetenekService.YetenekExist(adayId, yetenekId);
            return Ok(result);
        }
        
    }
}
