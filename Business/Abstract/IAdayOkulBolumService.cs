using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAdayOkulBolumService
    {
        IResult Add(AdayOkulBolum adayOkulBolum);
        IResult Delete(AdayOkulBolum adayOkulBolum);
        IResult Update(AdayOkulBolum adayOkulBolum);
        IDataResult<List<AdayOkulBolum>> GetAll();
        IDataResult<List<AdayOkulBolum>> GetAllByAdayId(int adayId);
        IDataResult<List<AdayOkulBolumDto>> GetAllAdayOkulBolumDto(int adayId);
    }
}
