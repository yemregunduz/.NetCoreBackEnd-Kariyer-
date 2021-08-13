using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAdayYetenekService
    {
        IResult Add(AdayYetenek adayYetenek);
        IResult Delete(AdayYetenek adayYetenek);
        IResult Update(AdayYetenek adayYetenek);
        IDataResult<List<AdayYetenek>> GetAll();
        IDataResult<List<AdayYetenekDetayDto>> GetAllAdayYetenekDetayDtoByAdayId(int adayId);
        IDataResult<List<AdayYetenekDetayDto>> GetAllAdayYetenekDetayDtoByAdayIdAndYetenekTipId(int adayId, int yetenekTipId);
        IResult YetenekExist(int adayId, int yetenekId);
    }
}
