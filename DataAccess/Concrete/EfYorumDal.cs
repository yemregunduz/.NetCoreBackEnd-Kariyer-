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
    public class EfYorumDal : EfEntityRepositoryBase<Yorum, KariyerNetContext>, IYorumDal
    {
        public List<YorumDetayDto> GetAllYorumDetayDto(Expression<Func<YorumDetayDto, bool>> filter = null)
        {
            using (var context = new KariyerNetContext())
            {
                var result = from y in context.YORUMLAR
                             join a in context.ADAYLAR
                             on y.YorumcuId equals a.Id
                             orderby y.YorumTarih
                             select new YorumDetayDto
                             {
                                 GonderiId = y.GonderiId,
                                 YorumTarih = y.YorumTarih,
                                 YorumIcerik = y.YorumIcerik,
                                 YorumId = y.Id,
                                 YorumcuAd = a.Ad,
                                 YorumcuId = a.Id,
                                 YorumcuImagePath = a.AdayImagePath,
                                 YorumcuSoyad = a.Soyad
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

                             
            }
        }
    }
}
