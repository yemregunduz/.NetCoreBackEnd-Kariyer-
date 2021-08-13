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
    public class BolumManager : IBolumService
    {
        IBolumDal _bolumDal;
        public BolumManager(IBolumDal bolumDal)
        {
            _bolumDal = bolumDal;
        }
        [CacheRemoveAspect("IBolumService.Get")]
        public IResult Add(Bolum bolum)
        {
            _bolumDal.Add(bolum);
            return new SuccessResult(Messages.BolumEklendi);
        }
        [CacheRemoveAspect("IBolumService.Get")]
        public IResult Delete(Bolum bolum)
        {
            _bolumDal.Delete(bolum);
            return new SuccessResult(Messages.BolumSilindi);
        }
        [CacheAspect]
        public IDataResult<List<Bolum>> GetAll()
        {
            return new SuccessDataResult<List<Bolum>>(_bolumDal.GetAll(), Messages.BolumlerListelendi);
        }
        [CacheAspect]
        public IDataResult<Bolum> GetByBolumId(int id)
        {
            return new SuccessDataResult<Bolum>(_bolumDal.Get(b => b.Id == id),Messages.BolumDetayGetirildi);
        }
        [CacheRemoveAspect("IBolumService.Get")]
        public IResult Update(Bolum bolum)
        {
            _bolumDal.Update(bolum);
            return new SuccessResult(Messages.BolumGuncellendi);
        }
    }
}
