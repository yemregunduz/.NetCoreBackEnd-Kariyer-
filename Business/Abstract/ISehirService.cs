using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISehirService
    {
        IResult Add(Sehir sehir);
        IResult Delete(Sehir sehir);
        IResult Update(Sehir sehir);
        IDataResult<List<Sehir>> GetAll();
        IDataResult<Sehir> GetBySehirId(int id);
    }
}
