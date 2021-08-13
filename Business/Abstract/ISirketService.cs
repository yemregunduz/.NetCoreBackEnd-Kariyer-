using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISirketService
    {
        IResult Add(Sirket sirket);
        IResult Delete(Sirket sirket);
        IResult Update(Sirket sirket);
        IDataResult<List<Sirket>> GetAll();
        IDataResult<Sirket> GetBySirketId(int id);
    }
}
