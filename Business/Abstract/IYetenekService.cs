using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYetenekService
    {
        IResult Add(Yetenek yetenek);
        IResult Delete(Yetenek yetenek);
        IResult Update(Yetenek yetenek);
        IDataResult<List<Yetenek>> GetAll();
        IDataResult<Yetenek> GetByYetenekId(int yetenekTipId);
        IDataResult<List<YetenekDetayDto>> GetAllYetenekDetayDtoBySearchFilter (string filterText);
    }
}
