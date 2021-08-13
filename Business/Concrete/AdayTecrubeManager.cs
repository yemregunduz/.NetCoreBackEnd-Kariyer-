using Business.Abstract;
using Business.Constants;
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
    public class AdayTecrubeManager : IAdayTecrubeService
    {
        IAdayTecrubeDal _adayTecrubeDal;
        public AdayTecrubeManager(IAdayTecrubeDal adayTecrubeDal)
        {
            _adayTecrubeDal = adayTecrubeDal;
        }
        [CacheRemoveAspect("IAdayTecrubeService.Get")]
        public IResult Add(AdayTecrube adayTecrube)
        {
            _adayTecrubeDal.Add(adayTecrube);
            return new SuccessResult(Messages.AdayTecrubeEklendi);
        }
        [CacheRemoveAspect("IAdayTecrubeService.Get")]
        public IResult Delete(AdayTecrube adayTecrube)
        {
            _adayTecrubeDal.Delete(adayTecrube);
            return new SuccessResult(Messages.AdayTecrubeSilindi);
        }
        [CacheAspect]
        public IDataResult<List<AdayTecrube>> GetAll()
        {
            return new SuccessDataResult<List<AdayTecrube>>(_adayTecrubeDal.GetAll(), Messages.AdayTecrubeleriListelendi);
        }
        [CacheAspect]
        public IDataResult<List<AdayTecrubeDetayDto>> GetAllDetayTecrubeDtoByAdayId(int adayId)
        {
            return new SuccessDataResult<List<AdayTecrubeDetayDto>>(_adayTecrubeDal.GetAllAdayTecrubeDetayByAdayId(adayId), Messages.AdayTecrubeleriListelendi);
        }

        [CacheAspect]
        public IDataResult<AdayTecrube> GetByAdayTecrubeId(int id)
        {
            return new SuccessDataResult<AdayTecrube>(_adayTecrubeDal.Get(a => a.Id == id), Messages.AdayTecrubesiGetirildi);
        }
        [CacheRemoveAspect("IAdayTecrubeService.Get")]
        public IResult Update(AdayTecrube adayTecrube)
        {
            _adayTecrubeDal.Update(adayTecrube);
            return new SuccessResult(Messages.AdayTecrubeGuncellendi);
        }
    }
}
