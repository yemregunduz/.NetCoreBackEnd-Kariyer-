using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBolumService
    {
        IResult Add(Bolum bolum);
        IResult Delete(Bolum bolum);
        IResult Update(Bolum bolum);
        IDataResult<List<Bolum>> GetAll();
        IDataResult<Bolum> GetByBolumId(int id);
    }
}
