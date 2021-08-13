using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAdayYetenekDal:IEntityRepository<AdayYetenek>
    {
        List<AdayYetenekDetayDto> GetAllAdayYetenekDetayDtoByFilter(Expression<Func<AdayYetenekDetayDto, bool>> filter = null);
    }
}
