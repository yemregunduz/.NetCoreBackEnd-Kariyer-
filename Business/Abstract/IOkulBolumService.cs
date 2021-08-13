using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOkulBolumService
    {
        IResult Add(OkulBolum okulBolum);
        IResult Delete(OkulBolum okulBolum);
        IResult Update(OkulBolum okulBolum);
        IDataResult<List<OkulBolum>> GetAll();
        IDataResult<List<OkulBolum>> GetAllOkulByBolumId(int bolumId);
        IDataResult<OkulBolum> AddReturnOkulBolumId (OkulBolum okulBolum);
        IDataResult<List<OkulBolumDto>> GetAllOkulBolumlerByOkulId(int okulId);
    }
}
