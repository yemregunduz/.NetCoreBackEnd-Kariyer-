using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class AdayOkulBolumDto
    {
        public int AdayOkulBolumId { get; set; }
        public int? AdayId { get; set; }
        public int? OkulBolumId { get; set; }
        public int? OkulId { get; set; }
        public string OkulAdi { get; set; }
        public string OkulImagePath { get; set; }
        public int BolumId { get; set; }
        public string BolumAdi { get; set; }
        public string OkulTip { get; set; }
        public DateTime? OkulGirisTarih { get; set; }
        public DateTime? OkulCikisTarih { get; set; }
    }
}
