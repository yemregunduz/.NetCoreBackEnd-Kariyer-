using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class IlanDetayDto:IDto
    {
        public int Id { get; set; }
        public int? PozisyonId { get; set; }
        public string PozisyonAd { get; set; }
        public int IsverenId { get; set; }
        public int SirketId { get; set; }
        public string SirketTelNo { get; set; }
        public string?Adres { get; set; }
        public string Sektor { get; set; }
        public string SirketAdi { get; set; }
        public string SirketImagePath { get; set; }
        public string WebSite { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public int SehirId { get; set; }
        public string SehirAdi { get; set; }
        public decimal? MaasMax { get; set; }
        public decimal? MaasMin { get; set; }
        public DateTime IlanYayinTarih { get; set; }
        public DateTime SonBasvuruTarih { get; set; }
        public string IlanIcerik { get; set; }
        public string CalismaSekli { get; set; }
        public bool Durum { get; set; }
    }
}
