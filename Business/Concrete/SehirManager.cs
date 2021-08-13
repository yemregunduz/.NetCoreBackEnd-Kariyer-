using Business.Abstract;
using Business.Constants;
using Core.Aspects.Caching;
using DataAccess.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SehirManager : ISehirService
    {
        ISehirDal _sehirDal;
        public SehirManager(ISehirDal sehirDal)
        {
            _sehirDal = sehirDal;
        }
        [CacheRemoveAspect("ISehirService.Get")]
        public IResult Add(Sehir sehir)
        {
            _sehirDal.Add(sehir);
            return new SuccessResult();
        }
        [CacheRemoveAspect("ISehirService.Get")]
        public IResult Delete(Sehir sehir)
        {
            _sehirDal.Delete(sehir);
            return new SuccessResult();
        }
        [CacheAspect]
        public IDataResult<List<Sehir>> GetAll()
        {
            return new SuccessDataResult<List<Sehir>>(_sehirDal.GetAll(), Messages.SehirlerListelendi);
        }
        [CacheAspect]
        public IDataResult<Sehir> GetBySehirId(int id)
        {
            return new SuccessDataResult<Sehir>(_sehirDal.Get(s => s.Id == id),Messages.SehirDetayGetirildi);
        }
        [CacheRemoveAspect("ISehirService.Get")]
        public IResult Update(Sehir sehir)
        {
            _sehirDal.Update(sehir);
            return new SuccessResult();
        }
    }
}
