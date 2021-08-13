using Business.Abstract;
using Entities.Dtos;
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
    public class AuthController : ControllerBase
    {
        IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        //[HttpPost("isverengiris")]
        //public IActionResult IsverenGiris(KullaniciGirisDto kullaniciGirisDto)
        //{
        //    var girisYapacakKullanici = _authService.IsverenGiris(kullaniciGirisDto);
        //    if (!girisYapacakKullanici.Success)
        //    {
        //        return BadRequest(girisYapacakKullanici.Message);
        //    }
        //    var result = _authService.CreateAccessToken();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        
        [HttpPost("isverenkayit")]
        //public IActionResult IsverenKayit(IsverenKayitDto isverenKayitDto)
        //{
        //    var isverenKontrol = _authService.IsverenKontrol(isverenKayitDto.Email);
        //    if (!isverenKontrol.Success)
        //    {
        //        return BadRequest(isverenKontrol.Message);
        //    }
        //    var kayitSonuc = _authService.IsverenKayit(isverenKayitDto, isverenKayitDto.Sifre);
        //    var result = _authService.CreateAccessToken(kayitSonuc);
        //    if (result.Success==true)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result.Message);
        //}
        [HttpPost("adaykayit")]
        public IActionResult AdayKayit(AdayKayitDto adayKayitDto)
        {
            var adayKontrol = _authService.AdayKontrol(adayKayitDto.Email);
            if (!adayKontrol.Success)
            {
                return BadRequest(adayKontrol.Message);
            }
            var kayitSonuc = _authService.AdayKayit(adayKayitDto, adayKayitDto.Sifre);
            var result = _authService.CreateAccessToken(kayitSonuc.Data);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("adaygiris")]
        public IActionResult AdayGiris(KullaniciGirisDto kullaniciGirisDto)
        {
            var girisYapacakKullanici = _authService.AdayGiris(kullaniciGirisDto);
            if (!girisYapacakKullanici.Success)
            {
                return BadRequest(girisYapacakKullanici.Message);
            }
            var result = _authService.CreateAccessToken(girisYapacakKullanici.Data);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
