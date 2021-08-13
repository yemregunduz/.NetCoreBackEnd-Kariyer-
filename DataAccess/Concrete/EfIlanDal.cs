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
    public class EfIlanDal : EfEntityRepositoryBase<Ilan, KariyerNetContext>, IIlanDal
    {
        public List<IlanDetayDto> GetAllIlanDetayDto(Expression<Func<IlanDetayDto, bool>> filter = null)
        {
            using (KariyerNetContext context = new KariyerNetContext())
            {
                var result = from i in context.ILANLAR
                             
                             join p in context.POZISYONLAR
                             on i.PozisyonId equals p.Id
                             join isv in context.ISVERENLER
                             on i.IsverenId equals isv.Id
                             join sr in context.SIRKETLER
                             on isv.SirketId equals sr.Id
                             join s in context.SEHIRLER
                             on sr.SehirId equals s.Id
                             orderby i.IlanYayinTarih
                             select new IlanDetayDto
                             {
                                 Id = i.Id,
                                 PozisyonId = p.Id,
                                 PozisyonAd = p.PozisyonAd,
                                 SehirId = s.Id,
                                 SehirAdi = s.SehirAdi,
                                 IsverenId=isv.Id,
                                 Email=isv.Email,
                                 SirketId=sr.Id,
                                 Adres=sr.Adres,
                                 Sektor=sr.Sektor,
                                 SirketAdi=sr.SirketAdi,
                                 SirketTelNo=sr.SirketTelNo,
                                 TelNo=isv.TelNo,
                                 WebSite=isv.WebSite,
                                 IlanYayinTarih = i.IlanYayinTarih,
                                 MaasMin = i.MaasMin,
                                 MaasMax = i.MaasMax,
                                 Durum = i.Durum,
                                 CalismaSekli=i.CalismaSekli,
                                 IlanIcerik=i.IlanIcerik,
                                 SonBasvuruTarih = i.SonBasvuruTarih,
                                 SirketImagePath=sr.SirketImagePath
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
