using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IGonderiDal:IEntityRepository<Gonderi>
    {
        List<AdayGonderiDetayDto> GetAllAdayGonderiDetayDto(int startIndex,int countOfQuery,Expression<Func<AdayGonderiDetayDto, bool>> filter = null);
       
       
    }
}
