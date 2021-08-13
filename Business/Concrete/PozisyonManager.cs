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
    public class PozisyonManager : IPozisyonService
    {
        IPozisyonDal _pozisyonDal;
        public PozisyonManager(IPozisyonDal pozisyonDal)
        {
            _pozisyonDal = pozisyonDal;
        }
        [CacheRemoveAspect("IPozisyonService.Get")]
        public IResult Add(Pozisyon pozisyon)
        {
            _pozisyonDal.Add(pozisyon);
            return new SuccessResult(Messages.PozisyonEklendi);
        }
        [CacheRemoveAspect("IPozisyonService.Get")]
        public IResult Delete(Pozisyon pozisyon)
        {
            _pozisyonDal.Delete(pozisyon);
            return new SuccessResult(Messages.PozisyonSilindi);
        }
        [CacheAspect]
        public IDataResult<List<Pozisyon>> GetAll()
        {
            return new SuccessDataResult<List<Pozisyon>>(_pozisyonDal.GetAll(), Messages.PozisyonlarListelendi);
        }
        [CacheAspect]
        public IDataResult<Pozisyon> GetByPozisyonId(int id)
        {
            return new SuccessDataResult<Pozisyon>(_pozisyonDal.Get(p => p.Id == id), Messages.PozisyonDetayıGetirildi);
        }
        [CacheRemoveAspect("IPozisyonService.Get")]
        public IResult Update(Pozisyon pozisyon)
        {
            _pozisyonDal.Update(pozisyon);
            return new SuccessResult(Messages.PozisyonGuncellendi);
        }
    }
}
