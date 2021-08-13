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
    public class SirketManager : ISirketService
    {
        ISirketDal _sirketDal;
        public SirketManager(ISirketDal sirketDal)
        {
            _sirketDal = sirketDal;
        }
        [CacheRemoveAspect("ISirketService.Get")]
        public IResult Add(Sirket sirket)
        {
            _sirketDal.Add(sirket);
            return new SuccessResult(Messages.SirketEklendi);
        }
        [CacheRemoveAspect("ISirketService.Get")]
        public IResult Delete(Sirket sirket)
        {
            _sirketDal.Delete(sirket);
            return new SuccessResult(Messages.SirketSilindi);
        }
        [CacheAspect]
        public IDataResult<List<Sirket>> GetAll()
        {
            return new SuccessDataResult<List<Sirket>>(_sirketDal.GetAll(), Messages.SirketlerListelendi);
        }
        [CacheAspect]
        public IDataResult<Sirket> GetBySirketId(int id)
        {
            return new SuccessDataResult<Sirket>(_sirketDal.Get(s => s.Id == id), Messages.SirketDetayGetirildi);
        }
        [CacheRemoveAspect("ISirketService.Get")]
        public IResult Update(Sirket sirket)
        {
            _sirketDal.Update(sirket);
            return new SuccessResult(Messages.SirketGuncellendi);
        }
    }
}
