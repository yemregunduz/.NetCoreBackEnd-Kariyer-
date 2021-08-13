using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAdayDal : IEntityRepository<Aday>
    {
        AdayDetayDto GetAdayByAdayId(Expression<Func<AdayDetayDto, bool>> filter=null);
        void UpdateAdayIletisimBilgileri(Aday aday);
        void UpdateAdaySosyalMedyaBilgileri(Aday aday);
        void UpdateAdayProfilePhoto(Aday aday);
        
    }
}
