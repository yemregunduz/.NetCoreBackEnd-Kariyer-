using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IOkulBolumDal:IEntityRepository<OkulBolum>
    {
        OkulBolum AddReturnOkulBolumId(OkulBolum okulBolum);
        List<OkulBolumDto> GetAllOkulBolumByOkulId(int okulId);
        
    }
}
