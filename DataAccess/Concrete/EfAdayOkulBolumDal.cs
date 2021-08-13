using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfAdayOkulBolumDal : EfEntityRepositoryBase<AdayOkulBolum, KariyerNetContext>, IAdayOkulBolumDal
    {
        public List<AdayOkulBolumDto> GetAllAdayOkulBolumDtoByAdayId(int adayId)
        {
            using (var context = new KariyerNetContext())
            {
                var result = from aob in context.ADAYOKULBOLUM
                             join a in context.ADAYLAR
                             on aob.AdayId equals a.Id into gj1
                             from a in gj1.DefaultIfEmpty()
                             join ob in context.OKULBOLUM
                             on aob.OkulBolumId equals ob.Id into gj2
                             from ob in gj2.DefaultIfEmpty()
                             join o in context.OKULLAR
                             on ob.OkulId equals o.Id into gj3
                             from o in gj3.DefaultIfEmpty()
                             join b in context.BOLUMLER
                             on ob.BolumId equals b.Id into gj4
                             from b in gj4.DefaultIfEmpty()
                             select new AdayOkulBolumDto
                             {
                                 AdayOkulBolumId = aob.Id,
                                 AdayId = a.Id,
                                 OkulId = ob.OkulId,
                                 OkulBolumId = aob.OkulBolumId,
                                 OkulTip = aob.OkulTip,
                                 BolumAdi = b.BolumAdi,
                                 BolumId = ob.BolumId,
                                 OkulAdi = o.OkulAdi,
                                 OkulImagePath = o.OkulImagePath,
                                 OkulCikisTarih = aob.OkulCikisTarih,
                                 OkulGirisTarih = aob.OkulGirisTarih

                             };
                return result.Where(a => a.AdayId == adayId).ToList();
                             


            }
        }
    }
}
