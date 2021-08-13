using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ilan:IEntity
    {
        public int Id { get; set; }
        public int PozisyonId { get; set; }
        public int IsverenId { get; set; }
        public decimal? MaasMax { get; set; }
        public decimal? MaasMin { get; set; }
        public int AcikPozisyonAdet { get; set; }
        public DateTime IlanYayinTarih { get; set; }
        public string IlanIcerik { get; set; }
        public string CalismaSekli { get; set; }
        public DateTime SonBasvuruTarih { get; set; }
        public bool Durum { get; set; }
    }
}
