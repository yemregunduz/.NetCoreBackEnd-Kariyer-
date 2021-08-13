using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
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
    public class TakipManager : ITakipService
    {
        ITakipDal _takipDal;
        public TakipManager(ITakipDal takipDal)
        {
            _takipDal = takipDal;
        }
        
        public IResult Add(Takip takip)
        {
            IResult result = BusinessRules.Run(CheckIfAlreadyFollorThisUser(takip.TakipEdilenId, takip.TakipciId));
            if (result!=null)
            {
                return result;
            }
            _takipDal.Add(takip);
            return new SuccessResult(Messages.TakipEdildi);
        }

        public IResult CheckIfUserAlreadFollow(int takipciId, int takipEdilenId)
        {
            var result = _takipDal.GetAll(t => t.TakipciId == takipciId && t.TakipEdilenId == takipEdilenId);
            if (result.Count==0)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IResult Delete(Takip takip)
        {
            _takipDal.Delete(takip);
            return new SuccessResult(Messages.TakiptenCikildi);
        }

        public IDataResult<List<TakipDetayDto>> GetAllTakipcilerByAdayId(int adayId)
        {
            return new SuccessDataResult<List<TakipDetayDto>>(_takipDal.GetAllTakipcilerByAdayId(adayId),Messages.TakipcilerListelendi);
        }

        public IDataResult<List<TakipDetayDto>> GetAllTakipEdilenlerByAdayId(int adayId)
        {
            return new SuccessDataResult<List<TakipDetayDto>>(_takipDal.GetAllTakipEdilenlerByAdayId(adayId), Messages.TakipEdilenlerListelendi);
        }

        public IDataResult<List<TakipDetayDto>> GetAllTakipEdilenlerTop3ByAdayId(int adayId)
        {
            return new SuccessDataResult<List<TakipDetayDto>>(_takipDal.GetAllTakipEdilenlerTopThreeByAdayId(adayId));
        }

        public IDataResult<Takip> GetTakipByTakipciAndTakipEdilenId(int takipciId, int takipEdilenId)
        {
            return new SuccessDataResult<Takip>(_takipDal.Get(t => t.TakipciId == takipciId && t.TakipEdilenId == takipEdilenId));
        }




        //BusinessRules
        private IResult CheckIfAlreadyFollorThisUser(int takipEdilenId,int takipciId)
        {
            var result = _takipDal.GetAll(t => t.TakipciId == takipciId && t.TakipEdilenId == takipEdilenId);
            if (result.Count!=0)
            {
                return new ErrorDataResult<List<Takip>>(Messages.ZatenTakiptesin);
            }
            return new SuccessDataResult<List<Takip>>();
        }

    }
}
