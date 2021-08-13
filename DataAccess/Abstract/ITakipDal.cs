using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITakipDal:IEntityRepository<Takip>
    {
        List<TakipDetayDto> GetAllTakipcilerByAdayId(int adayId);
        List<TakipDetayDto> GetAllTakipEdilenlerByAdayId(int adayId);
        List<TakipDetayDto> GetAllTakipEdilenlerTopThreeByAdayId(int adayId);
        
    }
}
