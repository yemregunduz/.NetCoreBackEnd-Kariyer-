using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidaton;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Caching;
using DataAccess.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AdayManager : IAdayService
    {
        IAdayDal _adayDal;
        public AdayManager(IAdayDal adayDal)
        {
            _adayDal = adayDal;
        }
        [ValidationAspect(typeof(AdayValidator))]
        [CacheRemoveAspect("IAdayService.Get")]
        public IResult Add(Aday aday)
        {
            _adayDal.Add(aday);
            return new SuccessResult(Messages.AdayEklendi);
        }
        [CacheRemoveAspect("IAdayService.Get")]
        public IResult Delete(Aday aday)
        {
            _adayDal.Delete(aday);
            return new SuccessResult(Messages.AdaySilindi);
        }

        public IDataResult<Aday> GetByAdayId(int id)
        {
            return new SuccessDataResult<Aday>(_adayDal.Get(a=>a.Id==id), Messages.AdayDetayGetirildi);
        }
        [CacheAspect]
        public IDataResult<List<Aday>> GetAll()
        {
            return new SuccessDataResult<List<Aday>>(_adayDal.GetAll(), Messages.AdaylarGetirdi);
        }
        [CacheRemoveAspect("IAdayService.Get")]
        public IResult Update(Aday aday)
        {
            _adayDal.Update(aday);
            return new SuccessResult(Messages.AdayGuncellendi);
        }
        [CacheAspect]
        public IDataResult<Aday> GetByMail(string email)
        {
            return new SuccessDataResult<Aday>(_adayDal.Get(a => a.Email == email));
        }

        public IDataResult<AdayDetayDto> GetAdayByAdayId(int adayId)
        {
            return new SuccessDataResult<AdayDetayDto>(_adayDal.GetAdayByAdayId(a => a.AdayId == adayId));
        }
        [CacheRemoveAspect("IAdayService.Get")]
        public IResult UpdateAdayIletisimBilgileri(Aday aday)
        {
            _adayDal.UpdateAdayIletisimBilgileri(aday);
            return new SuccessResult(Messages.AdayGuncellendi);
        }
        [CacheRemoveAspect("IAdayService.Get")]
        public IResult UpdateAdaySosyalMedyaBilgileri(Aday aday)
        {
            _adayDal.UpdateAdaySosyalMedyaBilgileri(aday);
            return new SuccessResult(Messages.AdayGuncellendi);
        }

        public IDataResult<List<Aday>> GetAllAdaylarBySearchFilter(string filterText)
        {
            return new SuccessDataResult<List<Aday>>(_adayDal.GetAll(a => a.Ad.Contains(filterText) || a.Soyad.Contains(filterText)), Messages.AdaylarGetirdi);
        }

        public IResult UpdateProfilePhoto(Aday aday)
        {
            _adayDal.UpdateAdayProfilePhoto(aday);
            return new SuccessResult(Messages.AdayGuncellendi);
        }
    }
}
