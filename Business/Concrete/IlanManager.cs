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
    public class IlanManager : IIlanService
    {
        IIlanDal _ilanDal;
        public IlanManager(IIlanDal ilanDal)
        {
            _ilanDal = ilanDal;
        }
        [CacheRemoveAspect("IIlanService.Get")]
        public IResult Add(Ilan ilan)
        {
            _ilanDal.Add(ilan);
            return new SuccessResult(Messages.IlanEklendi);
        }
        [CacheRemoveAspect("IIlanService.Get")]
        public IResult Delete(Ilan ilan)
        {
            _ilanDal.Delete(ilan);
            return new SuccessResult(Messages.IlanSilindi);
        }
        [CacheAspect]
        public IDataResult<List<Ilan>> GetAll()
        {
            return new SuccessDataResult<List<Ilan>>(_ilanDal.GetAll(), Messages.IlanlarListelendi);
        }
        [CacheAspect]
        public IDataResult<List<Ilan>> GetAllByPozisyonId(int id)
        {
            return new SuccessDataResult<List<Ilan>>(_ilanDal.GetAll(a => a.PozisyonId == id), Messages.IlanlarListelendi);
        }
        [CacheAspect]
        public IDataResult<List<IlanDetayDto>> GetAllIlanDetayDto()
        {
            return new SuccessDataResult<List<IlanDetayDto>>(_ilanDal.GetAllIlanDetayDto(), Messages.IlanlarListelendi);
        }
        [CacheAspect]
        public IDataResult<List<IlanDetayDto>> GetAllIlanDetayDtoByPozisyonId(int id)
        {
            return new SuccessDataResult<List<IlanDetayDto>>(_ilanDal.GetAllIlanDetayDto(i => i.PozisyonId == id ),Messages.IlanlarListelendi);
        }

        public IDataResult<List<IlanDetayDto>> GetAllIlanDetayDtoBySearchParameters(int? sehirId, int? pozisyonId, int? isverenId)
        {
                
            return new SuccessDataResult<List<IlanDetayDto>>(_ilanDal.GetAllIlanDetayDto(i =>(!sehirId.HasValue || sehirId==0) | i.SehirId == sehirId && (!pozisyonId.HasValue || pozisyonId==0) | i.PozisyonId == pozisyonId 
            && (!isverenId.HasValue || isverenId==0) | i.IsverenId == isverenId));
        }

        [CacheAspect]
        public IDataResult<Ilan> GetByIlanId(int id)
        {
            return new SuccessDataResult<Ilan>(_ilanDal.Get(i => i.Id == id),Messages.IlanDetayiGetirildi);
        }

        [CacheRemoveAspect("IIlanService.Get")]
        public IResult Update(Ilan ilan)
        {
            _ilanDal.Update(ilan);
            return new SuccessResult(Messages.IlanGuncellendi);
        }
    }
}
