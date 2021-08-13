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
    public class CvManager : ICvService
    {
        ICvDal _cvDal;
        public CvManager(ICvDal cvDal)
        {
            _cvDal = cvDal;
        }
        [CacheRemoveAspect("ICvService.Get")]
        public IResult Add(Cv cv)
        {
            _cvDal.Add(cv);
            return new SuccessResult(Messages.CvEklendi);
        }
        [CacheRemoveAspect("ICvService.Get")]
        public IResult Delete(Cv cv)
        {
            _cvDal.Delete(cv);
            return new SuccessResult(Messages.CvSilindi);
        }
        [CacheAspect]
        public IDataResult<List<Cv>> GetAll()
        {
            return new SuccessDataResult<List<Cv>>(_cvDal.GetAll(), Messages.CvlerListelendi);
        }
        [CacheAspect]
        public IDataResult<Cv> GetByCvId(int id)
        {
            return new SuccessDataResult<Cv>(_cvDal.Get(c => c.Id == id),Messages.CvDetayiGetirildi);
        }
        [CacheRemoveAspect("ICvService.Get")]
        public IResult Update(Cv cv)
        {
            _cvDal.Delete(cv);
            return new SuccessResult(Messages.CvGuncellendi);
        }
    }
}
