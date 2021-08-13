using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAdayService
    {
        IResult Add(Aday aday);
        IResult Delete(Aday aday);
        IResult Update(Aday aday);
        IDataResult<List<Aday>> GetAll();
        IDataResult<Aday> GetByAdayId(int id );
        IDataResult<Aday> GetByMail(string email);
        IDataResult<AdayDetayDto> GetAdayByAdayId(int adayId);
        IResult UpdateAdayIletisimBilgileri(Aday aday);
        IResult UpdateAdaySosyalMedyaBilgileri(Aday aday);
        IResult UpdateProfilePhoto(Aday aday);
        IDataResult<List<Aday>> GetAllAdaylarBySearchFilter(string filterText);
    }
}
