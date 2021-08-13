using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICvService
    {
        IResult Add(Cv cv);
        IResult Delete(Cv cv);
        IResult Update(Cv cv);
        IDataResult<List<Cv>> GetAll();
        IDataResult<Cv> GetByCvId(int id);
    }
}
