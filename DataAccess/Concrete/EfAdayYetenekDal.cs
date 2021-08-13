using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfAdayYetenekDal : EfEntityRepositoryBase<AdayYetenek, KariyerNetContext>, IAdayYetenekDal
    {
        public List<AdayYetenekDetayDto> GetAllAdayYetenekDetayDtoByFilter(Expression<Func<AdayYetenekDetayDto,bool>> filter = null)
        {
            using(var context = new KariyerNetContext())
            {
                var result = from ay in context.ADAYYETENEKLER
                             join a in context.ADAYLAR
                             on ay.AdayId equals a.Id
                             join y in context.YETENEKLER
                             on ay.YetenekId equals y.Id
                             join yt in context.YETENEKTIPLERI
                             on y.YetenekTipId equals yt.Id
                             orderby y.YetenekTipId
                             select new AdayYetenekDetayDto
                             {
                                 AdayId = ay.AdayId,
                                 AdayYetenekId = ay.Id,
                                 YetenekAdi = y.YetenekAdi,
                                 YetenekId = ay.YetenekId,
                                 YetenekSeviye=ay.YetenekSeviye,
                                 YetenekTipi = yt.YetenekTipi,
                                 YetenekTipId = yt.Id
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();


            }
        }
    }
}
