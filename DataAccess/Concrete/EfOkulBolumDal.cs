using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfOkulBolumDal : EfEntityRepositoryBase<OkulBolum, KariyerNetContext>, IOkulBolumDal
    {
        public OkulBolum AddReturnOkulBolumId(OkulBolum okulBolum)
        {
            using (var context = new KariyerNetContext())
            {
                var okulBolumToAdded = context.Entry(okulBolum);
                okulBolumToAdded.State = EntityState.Added;
                context.SaveChanges();
            }   
            return okulBolum;
        }

        public List<OkulBolumDto> GetAllOkulBolumByOkulId(int okulId)
        {
            using (var context = new KariyerNetContext())
            {
                var result = from ob in context.OKULBOLUM
                             join o in context.OKULLAR
                             on ob.OkulId equals o.Id
                             join b in context.BOLUMLER
                             on ob.BolumId equals b.Id
                             select new OkulBolumDto
                             {
                                 OkulBolumId = ob.Id,
                                 BolumId = ob.BolumId,
                                 OkulId = o.Id,
                                 BolumAdi = b.BolumAdi,
                                 OkulAdi = o.OkulAdi,
                             };
                return result.Where(o => o.OkulId == okulId).ToList();
            }
        }
    }
}
