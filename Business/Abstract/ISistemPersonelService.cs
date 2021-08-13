using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISistemPersonelService
    {
        IResult Add(SistemPersonel sistemPersonel);
        IResult Delete(SistemPersonel sistemPersonel);
        IResult Update(SistemPersonel sistemPersonel);
        IDataResult<List<SistemPersonel>> GetAll();
        IDataResult<SistemPersonel> GetSistemPersonelId(int id);
    }
}
