using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOkulService
    {
        IResult Add(Okul okul);
        IResult Delete(Okul okul);
        IResult Update(Okul okul);
        IDataResult<List<Okul>> GetAll();
        IDataResult<Okul> GetByOkulId(int id);
    }
}
