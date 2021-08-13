using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IIsverenService
    {
        IResult Add(Isveren isveren);
        IResult Delete(Isveren isveren);
        IResult Update(Isveren isveren);
        IDataResult<List<Isveren>> GetAll();
        IDataResult<Isveren> GetByIsverenId(int id);
        IDataResult<Isveren> GetByEmail(string email);
        IDataResult<List<IsverenDetayDto>> GetAllIsverenDetayDto();
        IDataResult<IsverenDetayDto> GetIsverenDetayDtoByIsverenId(int id);
        IDataResult<List<IsverenDetayDto>> GetAllIsverenBySehirId(int? sehirId);
    }
}
