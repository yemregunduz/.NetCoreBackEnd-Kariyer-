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
    public class OkulManager : IOkulService
    {
        IOkulDal _okulDal;
        public OkulManager(IOkulDal okulDal)
        {
            _okulDal = okulDal;
        }
        [CacheRemoveAspect("IOkulService.Get")]
        public IResult Add(Okul okul)
        {
            _okulDal.Add(okul);
            return new SuccessResult(Messages.OkulEklendi);
        }
        [CacheRemoveAspect("IOkulService.Get")]
        public IResult Delete(Okul okul)
        {
            _okulDal.Delete(okul);
            return new SuccessResult(Messages.OkulSilindi);
        }
        [CacheAspect]
        public IDataResult<List<Okul>> GetAll()
        {
            return new SuccessDataResult<List<Okul>>(_okulDal.GetAll(), Messages.OkullarListelendi);
        }
        [CacheAspect]
        public IDataResult<Okul> GetByOkulId(int id)
        {
            return new SuccessDataResult<Okul>(_okulDal.Get(o => o.Id == id),Messages.OkulDetayGetirildi);
        }
        [CacheRemoveAspect("IOkulService.Get")]
        public IResult Update(Okul okul)
        {
            _okulDal.Update(okul);
            return new SuccessResult(Messages.OkulGüncellendi);
        }
    }
}
