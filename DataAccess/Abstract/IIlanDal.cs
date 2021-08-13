using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IIlanDal:IEntityRepository<Ilan>
    {
        List<IlanDetayDto> GetAllIlanDetayDto(Expression<Func<IlanDetayDto, bool>> filter = null);
    }
}
