using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class OkulBolumDto:IDto
    {
        public int OkulBolumId { get; set; }
        public int OkulId { get; set; }
        public int BolumId { get; set; }
        public string BolumAdi { get; set; }
        public string OkulAdi { get; set; }
        public string OkulTip { get; set; }
    }
}
