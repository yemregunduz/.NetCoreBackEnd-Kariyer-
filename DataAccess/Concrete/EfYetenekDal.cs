using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfYetenekDal : EfEntityRepositoryBase<Yetenek, KariyerNetContext>, IYetenekDal
    {
        public List<YetenekDetayDto> GetAllYetenekDetayDto(Expression<Func<YetenekDetayDto,bool>> filter=null)
        {
            using (var context = new KariyerNetContext())
            {
                var result = from y in context.YETENEKLER
                             join yt in context.YETENEKTIPLERI
                             on y.YetenekTipId equals yt.Id
                             orderby yt.Id
                             select new YetenekDetayDto
                             {
                                 YetenekId = y.Id,
                                 YetenekTipId = yt.Id,
                                 YetenekAdi = y.YetenekAdi,
                                 YetenekTipi = yt.YetenekTipi
                             };
                return result.Where(filter).ToList();
            }
        }
    }
}
