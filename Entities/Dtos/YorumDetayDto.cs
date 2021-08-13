using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class YorumDetayDto:IDto
    {
        public int YorumId { get; set; }
        public int GonderiId { get; set; }
        public string YorumIcerik { get; set; }
        public int YorumcuId { get; set; }
        public string YorumcuAd { get; set; }
        public string YorumcuSoyad { get; set; }
        public string YorumcuImagePath { get; set; }
        public DateTime YorumTarih { get; set; }
    }
}
