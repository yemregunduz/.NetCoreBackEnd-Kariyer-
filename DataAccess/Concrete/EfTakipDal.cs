using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfTakipDal : EfEntityRepositoryBase<Takip, KariyerNetContext>, ITakipDal
    {
        public List<TakipDetayDto> GetAllTakipcilerByAdayId(int adayId)
        {
            using (var context=new KariyerNetContext())
            {
                var result = from t in context.TAKIPLER
                             join a in context.ADAYLAR
                             on t.TakipciId equals a.Id
                             select new TakipDetayDto
                             {
                                 AdayId = t.TakipEdilenId,
                                 Ad = a.Ad,
                                 Soyad = a.Soyad,
                                 AdayImagePath = a.AdayImagePath,
                                 Id = t.Id,
                                 TakipciId = a.Id,
                                 TakipEdilenId = t.TakipEdilenId
                             };
                return result.Where(t => t.AdayId == adayId).ToList();
            }
        }

        public List<TakipDetayDto> GetAllTakipEdilenlerByAdayId(int adayId)
        {
            using (var context = new KariyerNetContext())
            {
                var result = from t in context.TAKIPLER
                             join a in context.ADAYLAR
                             on t.TakipEdilenId equals a.Id
                             select new TakipDetayDto
                             {
                                 AdayId = t.TakipciId,
                                 Ad = a.Ad,
                                 Soyad = a.Soyad,
                                 AdayImagePath = a.AdayImagePath,
                                 Id = t.Id,
                                 TakipciId = t.TakipciId,
                                 TakipEdilenId = a.Id
                             };
                return result.Where(t => t.AdayId == adayId).ToList();
            }
        }

        public List<TakipDetayDto> GetAllTakipEdilenlerTopThreeByAdayId(int adayId)
        {
            using(var context = new KariyerNetContext())
            {
                var result = from t in context.TAKIPLER
                             join a in context.ADAYLAR
                             on t.TakipEdilenId equals a.Id
                             orderby t.Id descending
                             select new TakipDetayDto
                             {
                                 AdayId = t.TakipciId,
                                 Ad = a.Ad,
                                 Soyad = a.Soyad,
                                 AdayImagePath = a.AdayImagePath,
                                 Id = t.Id,
                                 TakipciId = t.TakipciId,
                                 TakipEdilenId = a.Id
                             };
                return result.Where(t => t.AdayId == adayId).OrderByDescending(t => t.Id).Take(3).ToList();

            }
        }
    }
}
