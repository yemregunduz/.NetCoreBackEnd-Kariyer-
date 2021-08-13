using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAdayTecrubeDal:IEntityRepository<AdayTecrube>
    {
        List<AdayTecrubeDetayDto> GetAllAdayTecrubeDetayByAdayId(int adayId);
    }
}
