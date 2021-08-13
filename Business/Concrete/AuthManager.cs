using Business.Abstract;
using Business.Constants;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IIsverenService _isverenService;
        ITokenHelper _tokenHelper;
        IAdayService _adayService;
        
        public AuthManager(IIsverenService isverenService,ITokenHelper tokenHelper,IAdayService adayService)
        {
            _isverenService = isverenService;
            _tokenHelper = tokenHelper;
            _adayService = adayService;
        }
        public IDataResult<AccessToken> CreateAccessToken(Aday aday)
        {
            var accessToken = _tokenHelper.CreateToken(aday);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenOlusturuldu);
        }

        public IResult IsverenKontrol(string email)
        {
            var isverenKontrol = _isverenService.GetByEmail(email);
            if (isverenKontrol.Data!=null)
            {
                return new ErrorResult(Messages.KullaniciZatenKayitli);
            }
            return new SuccessResult();
        }

        public IDataResult<Isveren> IsverenKayit(IsverenKayitDto isverenKayitDto, string sifre)
        {
            byte[] sifreHash, sifreSalt;
            HashingHelper.CreatePasswordHash(sifre, out sifreHash, out sifreSalt);
            var isveren = new Isveren
            {
                Email = isverenKayitDto.Email,
                SirketId=isverenKayitDto.SirketId,
                WebSite = isverenKayitDto.WebSite,
                TelNo = isverenKayitDto.TelNo,
                SifreHash = sifreHash,
                SifreSalt = sifreSalt
            };
            _isverenService.Add(isveren);
            return new SuccessDataResult<Isveren>(isveren, Messages.KullaniciKaydedildi);
        }

        public IDataResult<Isveren> IsverenGiris(KullaniciGirisDto kullaniciGirisDto)
        {
            var isverenKontrol = _isverenService.GetByEmail(kullaniciGirisDto.Email);
            if (isverenKontrol.Data==null)
            {
                return new ErrorDataResult<Isveren>(Messages.KullaniciBulunamadi);
            }
            if (!HashingHelper.VerifyPasswordHash(kullaniciGirisDto.Sifre,isverenKontrol.Data.SifreHash,isverenKontrol.Data.SifreSalt))
            {
                return new ErrorDataResult<Isveren>(Messages.SifreHatali);
            }
            return new SuccessDataResult<Isveren>(isverenKontrol.Data, Messages.GirisBasarili);
        }

        public IDataResult<Aday> AdayKayit(AdayKayitDto adayKayitDto, string sifre)
        {
            byte[] sifreHash, sifreSalt;
            HashingHelper.CreatePasswordHash(sifre, out sifreHash, out sifreSalt);
            var aday = new Aday
            {
                Email = adayKayitDto.Email,
                Ad= adayKayitDto.Ad,
                Soyad=adayKayitDto.Soyad,
                TcNo=adayKayitDto.TcNo,
                DogumYili=adayKayitDto.DogumYili,
                SifreHash = sifreHash,
                SifreSalt = sifreSalt
            };
            _adayService.Add(aday);
            return new SuccessDataResult<Aday>(aday, Messages.KullaniciKaydedildi);
        }

        public IDataResult<Aday> AdayGiris(KullaniciGirisDto kullaniciGirisDto)
        {
            var adayKontrol = _adayService.GetByMail(kullaniciGirisDto.Email);
            if (adayKontrol.Data==null)
            {
                return new ErrorDataResult<Aday>(Messages.KullaniciBulunamadi);
            }
            if (!HashingHelper.VerifyPasswordHash(kullaniciGirisDto.Sifre,adayKontrol.Data.SifreHash,adayKontrol.Data.SifreSalt))
            {
                return new ErrorDataResult<Aday>(Messages.SifreHatali);
            }
            return new SuccessDataResult<Aday>(adayKontrol.Data, Messages.GirisBasarili);
        }

        public IResult AdayKontrol(string email)
        {
            var adayKontrol = _adayService.GetByMail(email);
            if (adayKontrol.Data != null)
            {
                return new ErrorResult(Messages.KullaniciZatenKayitli);
            }
            return new SuccessResult();
        }
    }
}

