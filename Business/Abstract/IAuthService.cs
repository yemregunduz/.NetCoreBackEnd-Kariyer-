using Core.Utilities.Security.JWT;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Isveren> IsverenKayit(IsverenKayitDto isverenKayitDto, string sifre);
        IDataResult<Isveren> IsverenGiris(KullaniciGirisDto kullaniciGirisDto);
        IResult IsverenKontrol(string email);
        IDataResult<AccessToken> CreateAccessToken(Aday aday);
        IDataResult<Aday> AdayKayit(AdayKayitDto adayKayitDto, string sifre);
        IDataResult<Aday> AdayGiris(KullaniciGirisDto kullaniciGirisDto);
        IResult AdayKontrol(string email);
    }
}
