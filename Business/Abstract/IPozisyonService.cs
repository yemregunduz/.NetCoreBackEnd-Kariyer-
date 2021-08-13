using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPozisyonService
    {
        IResult Add(Pozisyon pozisyon);
        IResult Delete(Pozisyon pozisyon);
        IResult Update(Pozisyon pozisyon);
        IDataResult<List<Pozisyon>> GetAll();
        IDataResult<Pozisyon> GetByPozisyonId(int id);
    }
}
