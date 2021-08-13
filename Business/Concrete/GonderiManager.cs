using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GonderiManager : IGonderiService
    {
        IGonderiDal _gonderiDal;
        public GonderiManager(IGonderiDal gonderiDal)
        {
            _gonderiDal = gonderiDal;
        }
        public IResult Add(Gonderi gonderi)
        {
            _gonderiDal.Add(gonderi);
            return new SuccessResult(Messages.GonderiEklendi);
        }

        public IResult Delete(Gonderi gonderi)
        {
            _gonderiDal.Delete(gonderi);
            return new SuccessResult(Messages.GonderiSilindi);
        }

        public IDataResult<List<Gonderi>> GetAll()
        {
            return new SuccessDataResult<List<Gonderi>>(_gonderiDal.GetAll(), Messages.GonderilerListelendi);
        }

        public IDataResult<List<AdayGonderiDetayDto>> GetAllAdayGonderiDetayDto(int takipEdilenId, int startIndex, int countOfQuery)
        {
            return new SuccessDataResult<List<AdayGonderiDetayDto>>(_gonderiDal.GetAllAdayGonderiDetayDto(startIndex,countOfQuery,g=>g.TakipEdilenId==takipEdilenId || g.GonderenId==takipEdilenId), Messages.GonderilerListelendi);
        }

        public IDataResult<List<AdayGonderiDetayDto>> GetAllAdayGonderiDetayDtoByAdayId(int startIndex, int countOfQuery,int adayId)
        {
            return new SuccessDataResult<List<AdayGonderiDetayDto>>(_gonderiDal.GetAllAdayGonderiDetayDto(startIndex,countOfQuery, g=>g.AdayId==adayId), Messages.GonderilerListelendi);
        }

        public IDataResult<Gonderi> GetByGonderiId(int gonderiId)
        {
            return new SuccessDataResult<Gonderi>(_gonderiDal.Get(g => g.Id == gonderiId), Messages.GonderiDetayiGetirildi);
        }

        public IResult Update(Gonderi gonderi)
        {
            _gonderiDal.Update(gonderi);
            return new SuccessResult(Messages.GonderiGuncellendi);
        }
    }
}
