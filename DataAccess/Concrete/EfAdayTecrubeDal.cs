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
    public class EfAdayTecrubeDal : EfEntityRepositoryBase<AdayTecrube, KariyerNetContext>, IAdayTecrubeDal
    {
        public List<AdayTecrubeDetayDto> GetAllAdayTecrubeDetayByAdayId(int adayId)
        {
            using (var context = new KariyerNetContext())
            {
                var result = from at in context.ADAYTECRUBELERI
                             join a in context.ADAYLAR
                             on at.AdayId equals a.Id
                             join s in context.SIRKETLER
                             on at.SirketId equals s.Id
                             join p in context.POZISYONLAR
                             on at.PozisyonId equals p.Id
                             orderby at.GirisTarih descending
                             select new AdayTecrubeDetayDto
                             {
                                 Id = at.Id,
                                 AdayId = at.AdayId,
                                 SirketId = at.SirketId,
                                 SirketAdi = s.SirketAdi,
                                 SirketSektor = s.Sektor,
                                 PozisyonId = at.PozisyonId,
                                 PozisyonAd = p.PozisyonAd,
                                 IsGirisTarih = at.GirisTarih,
                                 IsCikisTarih = at.CikisTarih,
                                 SirketImagePath=s.SirketImagePath
                             };
                return result.Where(a => a.AdayId == adayId).ToList();
            }
        }
    }
}
