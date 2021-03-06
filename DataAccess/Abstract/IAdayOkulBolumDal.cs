using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAdayOkulBolumDal:IEntityRepository<AdayOkulBolum>
    {
        List<AdayOkulBolumDto> GetAllAdayOkulBolumDtoByAdayId(int adayId);
    }
}
