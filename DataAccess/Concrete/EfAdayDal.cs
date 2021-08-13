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
    public class EfAdayDal : EfEntityRepositoryBase<Aday, KariyerNetContext>, IAdayDal
    {
        public AdayDetayDto GetAdayByAdayId(Expression<Func<AdayDetayDto, bool>> filter = null)
        {
            using (var context = new KariyerNetContext())
            {
                var result = from a in context.ADAYLAR
                             join aob in context.ADAYOKULBOLUM
                             on a.Id equals aob.Id into gj1
                             from aob in gj1.DefaultIfEmpty()
                             join ob in context.OKULBOLUM
                             on aob.OkulBolumId equals ob.Id into gj3
                             from ob in gj3.DefaultIfEmpty()
                             join b in context.BOLUMLER
                             on ob.BolumId equals b.Id into gj4
                             from b in gj4.DefaultIfEmpty()
                             join o in context.OKULLAR
                             on ob.OkulId equals o.Id into gj9
                             from o in gj9.DefaultIfEmpty()
                             join sh in context.SEHIRLER
                             on a.SehirId equals sh.Id into gj5
                             from sh in gj5.DefaultIfEmpty()
                             join at in context.ADAYTECRUBELERI
                             on a.Id equals at.AdayId into gj2
                             from at in gj2.DefaultIfEmpty()
                             join s in context.SIRKETLER
                             on at.SirketId equals s.Id into gj6
                             from s in gj6.DefaultIfEmpty()
                             join p in context.POZISYONLAR
                             on at.PozisyonId equals p.Id into gj7
                             from p in gj7.DefaultIfEmpty()
                             
                             
                             select new AdayDetayDto
                             {
                                 AdayId = a.Id,
                                 Ad = a.Ad,
                                 Soyad = a.Soyad,
                                 TcNo = a.TcNo,
                                 DogumYili = a.DogumYili,
                                 SehirId = sh.Id,
                                 SehirAdi = sh.SehirAdi,
                                 AdayTelNo = a.AdayTelNo,
                                 Email = a.Email,
                                 AdayAdres = a.AdayAdres,
                                 AdayGithub = a.AdayGithub,
                                 AdayFacebook = a.AdayFacebook,
                                 AdayInstagram = a.AdayInstagram,
                                 AdayImagePath = a.AdayImagePath,
                                 AdayTwitter = a.AdayTwitter,
                                 AdayLinkedin = a.AdayLinkedin,
                                 OkulBolumId = aob.OkulBolumId,
                                 BolumId = ob.BolumId,
                                 OkulId = ob.OkulId,
                                 BolumAdi = b.BolumAdi,
                                 OkulAdi = o.OkulAdi,
                                 OkulGirisTarih = aob.OkulGirisTarih,
                                 OkulCikisTarih = aob.OkulCikisTarih,
                                 AdayDetayId=at.Id,
                                 CikisTarih=at.CikisTarih,
                                 GirisTarih=at.CikisTarih,
                                 PozisyonId=p.Id,
                                 PozisyonAd=p.PozisyonAd,
                                 PozisyonImagePath=p.ImagePath,
                                 SirketId=s.Id,
                                 SirketAdres=s.Adres,
                                 SirketTelNo=s.SirketTelNo,
                                 SirketSektor=s.Sektor,
                                 SirketAdi=s.SirketAdi,
                                 SirketSehirId=s.SehirId,
                                 SirketSehirAdi=sh.SehirAdi,                                                         
                                 SirketImagePath=s.SirketImagePath,
                                 OkulImagePath=o.OkulImagePath,
                                 OkulTip=aob.OkulTip,
                                 SifreHash=a.SifreHash,
                                 SifreSalt=a.SifreSalt,
                                 AdayOkulBolumId=aob.Id
                             };
                return result.FirstOrDefault(filter);

            }
        }

        public void UpdateAdayIletisimBilgileri(Aday aday)
        {
            using (var context= new KariyerNetContext())
            {
                context.ADAYLAR.Attach(aday);
                context.Entry(aday).Property(a => a.Ad).IsModified = true;
                context.Entry(aday).Property(a => a.Soyad).IsModified = true;
                context.Entry(aday).Property(a => a.AdayAdres).IsModified = true;
                context.Entry(aday).Property(a => a.AdayTelNo).IsModified = true;
                context.Entry(aday).Property(a => a.DogumYili).IsModified = true;
                context.SaveChanges();
            }
        }

        public void UpdateAdayProfilePhoto(Aday aday)
        {
            using (var context = new KariyerNetContext())
            {
                context.ADAYLAR.Attach(aday);
                context.Entry(aday).Property(a => a.AdayImagePath).IsModified = true;
            }
        }

        public void UpdateAdaySosyalMedyaBilgileri(Aday aday)
        {
            using (var context=new KariyerNetContext())
            {
                context.ADAYLAR.Attach(aday);
                context.Entry(aday).Property(a => a.AdayLinkedin).IsModified = true;
                context.Entry(aday).Property(a => a.AdayGithub).IsModified = true;
                context.Entry(aday).Property(a => a.AdayTwitter).IsModified = true;
                context.Entry(aday).Property(a => a.AdayInstagram).IsModified = true;
                context.Entry(aday).Property(a => a.AdayFacebook).IsModified = true;
                context.SaveChanges();

            }
        }
    }
}
