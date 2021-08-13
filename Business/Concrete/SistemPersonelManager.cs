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
    public class SistemPersonelManager : ISistemPersonelService
    {
        ISistemPersonelDal _sistemPersonelDal;
        public SistemPersonelManager(ISistemPersonelDal sistemPersonelDal)
        {
            _sistemPersonelDal = sistemPersonelDal;
        }
        [CacheRemoveAspect("ISistemPersonelService.Get")]
        public IResult Add(SistemPersonel sistemPersonel)
        {
            _sistemPersonelDal.Add(sistemPersonel);
            return new SuccessResult(Messages.SistemPersonelEklendi);
        }
        [CacheRemoveAspect("ISistemPersonelService.Get")]
        public IResult Delete(SistemPersonel sistemPersonel)
        {
            _sistemPersonelDal.Delete(sistemPersonel);
            return new SuccessResult(Messages.SistemPersonelSilindi);
        }
        [CacheAspect]
        public IDataResult<List<SistemPersonel>> GetAll()
        {
            return new SuccessDataResult<List<SistemPersonel>>(_sistemPersonelDal.GetAll(), Messages.SistemPersonelleriListelendi);
        }
        [CacheAspect]
        public IDataResult<SistemPersonel> GetSistemPersonelId(int id)
        {
            return new SuccessDataResult<SistemPersonel>(_sistemPersonelDal.Get(s => s.Id == id), Messages.SistemPersonelDetayGetirildi);
        }
        [CacheRemoveAspect("ISistemPersonelService.Get")]
        public IResult Update(SistemPersonel sistemPersonel)
        {
            _sistemPersonelDal.Update(sistemPersonel);
            return new SuccessResult(Messages.SistemPersonelGuncellendi);
        }
    }
}
