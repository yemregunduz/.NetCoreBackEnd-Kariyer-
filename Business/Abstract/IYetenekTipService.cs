using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYetenekTipService
    {
        IResult Add(YetenekTip yetenekTip);
        IResult Delete(YetenekTip yetenekTip);
        IResult Update(YetenekTip yetenekTip);
        IDataResult<List<YetenekTip>> GetAll();
        IDataResult<YetenekTip> GetByYetenekTipId(int id);
    }
}
