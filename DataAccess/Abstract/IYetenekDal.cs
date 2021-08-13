using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IYetenekDal:IEntityRepository<Yetenek>
    {
        List<YetenekDetayDto> GetAllYetenekDetayDto(Expression<Func<YetenekDetayDto,bool>> filter = null);
    }
}
