using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IIlanService
    {
        IResult Add(Ilan ilan);
        IResult Delete(Ilan ilan);
        IResult Update(Ilan ilan);
        IDataResult<List<Ilan>> GetAll();
        IDataResult<Ilan> GetByIlanId(int id);
        IDataResult<List<Ilan>> GetAllByPozisyonId(int id);
        IDataResult<List<IlanDetayDto>> GetAllIlanDetayDto();
        IDataResult<List<IlanDetayDto>> GetAllIlanDetayDtoByPozisyonId(int id);
        IDataResult<List<IlanDetayDto>> GetAllIlanDetayDtoBySearchParameters(int? sehirId, int? pozisyonId, int? isverenId);
        
    }
}
