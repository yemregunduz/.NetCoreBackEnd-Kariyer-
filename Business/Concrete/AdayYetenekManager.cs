using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AdayYetenekManager : IAdayYetenekService
    {
        IAdayYetenekDal _adayYetenekDal;
        public AdayYetenekManager(IAdayYetenekDal adayYetenekDal)
        {
            _adayYetenekDal = adayYetenekDal;
        }
        public IResult Add(AdayYetenek adayYetenek)
        {
            _adayYetenekDal.Add(adayYetenek);
            return new SuccessResult(Messages.AdayaYetenekEklendi);
        }

        public IResult Delete(AdayYetenek adayYetenek)
        {
            _adayYetenekDal.Delete(adayYetenek);
            return new SuccessResult(Messages.AdayYetenegiSilindi);
        }

        public IDataResult<List<AdayYetenek>> GetAll()
        {
            return new SuccessDataResult<List<AdayYetenek>>(_adayYetenekDal.GetAll(), Messages.AdaylarVeYetenekleriListelendi);
        }

        public IDataResult<List<AdayYetenekDetayDto>> GetAllAdayYetenekDetayDtoByAdayId(int adayId)
        {
            return new SuccessDataResult<List<AdayYetenekDetayDto>>(_adayYetenekDal.GetAllAdayYetenekDetayDtoByFilter(yd => yd.AdayId == adayId), Messages.AdayinYetenekleriListelendi);
        }

        public IDataResult<List<AdayYetenekDetayDto>> GetAllAdayYetenekDetayDtoByAdayIdAndYetenekTipId(int adayId, int yetenekTipId)
        {
            return new SuccessDataResult<List<AdayYetenekDetayDto>>(_adayYetenekDal.GetAllAdayYetenekDetayDtoByFilter(yd => yd.AdayId == adayId&&yd.YetenekTipId==yetenekTipId), Messages.AdayinYetenekleriTipeGöreListelendi);
        }

        public IResult Update(AdayYetenek adayYetenek)
        {
            _adayYetenekDal.Update(adayYetenek);
            return new SuccessResult(Messages.AdayYetenegiGuncellendi);
        }

        public IResult YetenekExist(int adayId, int yetenekId)
        {
            var result = _adayYetenekDal.GetAll(y => y.AdayId == adayId && y.YetenekId == yetenekId);
            if (result.Count != 0)
            {
                return new ErrorResult(Messages.ZatenBuYetenegeSahip);
            }
            return new SuccessResult();
        }

    }
}
