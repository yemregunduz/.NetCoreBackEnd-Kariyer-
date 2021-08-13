using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfIsverenDal : EfEntityRepositoryBase<Isveren, KariyerNetContext>, IIsverenDal
    {
        public List<IsverenDetayDto> GetAllIsverenDetayDto(Expression<Func<IsverenDetayDto, bool>> filter = null)
        {
            using (KariyerNetContext context = new KariyerNetContext())
            {
                var result = from i in context.ISVERENLER
                             join s in context.SIRKETLER
                             on i.SirketId equals s.Id
                             join sh in context.SEHIRLER
                             on s.SehirId equals sh.Id
                             select new IsverenDetayDto
                             {
                                 Id = i.Id,
                                 SirketId = s.Id,
                                 SirketAdi = s.SirketAdi,
                                 Sektor = s.Sektor,
                                 TelNo = i.TelNo,
                                 SehirId = sh.Id,
                                 SehirAdi = sh.SehirAdi,
                                 SirketTelNo = s.SirketTelNo,
                                 Adres = s.Adres,
                                 Email = i.Email,
                                 WebSite = i.WebSite,
                                 SirketImagePath=s.SirketImagePath
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public IsverenDetayDto GetIsverenDetayDto(Expression<Func<IsverenDetayDto, bool>> filter = null)
        {
            using (KariyerNetContext context = new KariyerNetContext())
            {
                var result = from i in context.ISVERENLER
                             join s in context.SIRKETLER
                             on i.SirketId equals s.Id
                             join sh in context.SEHIRLER
                             on s.SehirId equals sh.Id
                             select new IsverenDetayDto
                             {
                                 Id = i.Id,
                                 SirketId = s.Id,
                                 SehirId=sh.Id,
                                 SehirAdi=sh.SehirAdi,
                                 SirketAdi = s.SirketAdi,
                                 Sektor = s.Sektor,
                                 TelNo = i.TelNo,
                                 SirketTelNo = s.SirketTelNo,
                                 Adres = s.Adres,
                                 Email = i.Email,
                                 WebSite = i.WebSite,
                                 SirketImagePath=s.SirketImagePath
                             };
                return  result.SingleOrDefault(filter);
            }
        }
    }
}
