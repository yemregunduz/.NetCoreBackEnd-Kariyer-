using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGonderiService
    {
        IResult Add(Gonderi gonderi);
        IResult Delete(Gonderi gonderi);
        IResult Update(Gonderi gonderi);
        IDataResult<List<Gonderi>> GetAll();
        IDataResult<Gonderi> GetByGonderiId(int gonderiId);
        IDataResult<List<AdayGonderiDetayDto>> GetAllAdayGonderiDetayDto(int takipEdilenId,int startIndex,int countOfQuery);
        IDataResult<List<AdayGonderiDetayDto>> GetAllAdayGonderiDetayDtoByAdayId(int startIndex,int countOfQuery,int adayId);
    }
}

