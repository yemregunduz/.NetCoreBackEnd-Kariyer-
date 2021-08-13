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
    public class IsverenManager : IIsverenService
    {
        IIsverenDal _isverenDal;
        public IsverenManager(IIsverenDal isverenDal)
        {
            _isverenDal = isverenDal;
        }
        [CacheRemoveAspect("IIsverenService.Get")]
        public IResult Add(Isveren isveren)
        {
            _isverenDal.Add(isveren);
            return new SuccessResult(Messages.IsverenEklendi);
        }
        [CacheRemoveAspect("IIsverenService.Get")]
        public IResult Delete(Isveren isveren)
        {
            _isverenDal.Delete(isveren);
            return new SuccessResult(Messages.IsverenSilindi);
        }
        [CacheAspect]
        public IDataResult<List<Isveren>> GetAll()
        {
            return new SuccessDataResult<List<Isveren>>(_isverenDal.GetAll(), Messages.IsverenlerListelendi);
        }

        public IDataResult<List<IsverenDetayDto>> GetAllIsverenBySehirId(int? sehirId)
        {
            return new SuccessDataResult<List<IsverenDetayDto>>(_isverenDal.GetAllIsverenDetayDto(i => (!sehirId.HasValue || sehirId == 0) | i.SehirId == sehirId));
        }

        [CacheAspect]
        public IDataResult<List<IsverenDetayDto>> GetAllIsverenDetayDto()
        {
            return new SuccessDataResult<List<IsverenDetayDto>>(_isverenDal.GetAllIsverenDetayDto(), Messages.IsverenlerListelendi);
        }

        [CacheAspect]
        public IDataResult<Isveren> GetByEmail(string email)
        {
            return new SuccessDataResult<Isveren>(_isverenDal.Get(i => i.Email == email));
        }
        [CacheAspect]
        public IDataResult<Isveren> GetByIsverenId(int id)
        {
            return new SuccessDataResult<Isveren>(_isverenDal.Get(i => i.Id == id), Messages.IsverenDetayGetirildi);
        }
        [CacheAspect]
        public IDataResult<IsverenDetayDto> GetIsverenDetayDtoByIsverenId(int id)
        {
            return new SuccessDataResult<IsverenDetayDto>(_isverenDal.GetIsverenDetayDto(i => i.Id == id));
        }

        [CacheRemoveAspect("IIsverenService.Get")]
        public IResult Update(Isveren isveren)
        {
            _isverenDal.Update(isveren);
            return new SuccessResult(Messages.IsverenGuncellendi);
        }
    }
}
