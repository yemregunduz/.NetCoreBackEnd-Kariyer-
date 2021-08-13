using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ITakipService
    {
        IResult Add(Takip takip);
        IResult Delete(Takip takip);
        IDataResult<List<TakipDetayDto>> GetAllTakipcilerByAdayId(int adayId);
        IDataResult<List<TakipDetayDto>> GetAllTakipEdilenlerByAdayId(int adayId);
        IResult CheckIfUserAlreadFollow(int takipciId, int takipEdilenId);
        IDataResult<Takip> GetTakipByTakipciAndTakipEdilenId(int takipciId,int takipEdilenId);
        IDataResult<List<TakipDetayDto>> GetAllTakipEdilenlerTop3ByAdayId(int adayId);
        
    }
}
