using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAdayTecrubeService
    {
        IResult Add(AdayTecrube adayTecrube);
        IResult Delete(AdayTecrube adayTecrube);
        IResult Update(AdayTecrube adayTecrube);
        IDataResult<List<AdayTecrube>> GetAll();
        IDataResult<AdayTecrube> GetByAdayTecrubeId(int id);
        IDataResult<List<AdayTecrubeDetayDto>> GetAllDetayTecrubeDtoByAdayId(int adayId);
    }
}
