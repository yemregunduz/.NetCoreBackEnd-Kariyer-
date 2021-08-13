using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IIsverenDal:IEntityRepository<Isveren>
    {
        List<IsverenDetayDto> GetAllIsverenDetayDto(Expression<Func<IsverenDetayDto, bool>> filter = null);
        IsverenDetayDto GetIsverenDetayDto(Expression<Func<IsverenDetayDto, bool>> filter = null);
    }
}
