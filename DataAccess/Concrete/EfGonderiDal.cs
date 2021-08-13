using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfGonderiDal : EfEntityRepositoryBase<Gonderi, KariyerNetContext>, IGonderiDal
    {
        public List<AdayGonderiDetayDto> GetAllAdayGonderiDetayDto(int startIndex,int countOfQuery,Expression<Func<AdayGonderiDetayDto, bool>> filter = null)
        {
            using (var context = new KariyerNetContext())
            {
                var result = from g in context.GONDERILER
                             join a in context.ADAYLAR
                             on g.GonderenId equals a.Id
                             join t in context.TAKIPLER
                             on g.GonderenId equals t.TakipEdilenId                            
                             select new AdayGonderiDetayDto
                             {
                                 GonderenId = g.GonderenId,
                                 AdayAd = a.Ad,
                                 AdayId = a.Id,
                                 AdayImagePath = a.AdayImagePath,
                                 AdaySoyad = a.Soyad,
                                 GonderiIcerik = g.GonderiIcerik,
                                 Id = g.Id,
                                 GonderiImagePath = g.GonderiImagePath,
                                 GonderiTarih=g.GonderiTarih,
                                 TakipEdilenId=t.TakipciId
                             };
                return filter == null ? result.OrderByDescending(g => g.GonderiTarih).Skip(startIndex).Take(countOfQuery).ToList() : result.Where(filter).OrderByDescending(g => g.GonderiTarih).Skip(startIndex).Take(countOfQuery).ToList();

            }
        }

        
    }
}
