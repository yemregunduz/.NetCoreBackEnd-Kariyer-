using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class AdayGonderiDetayDto:IDto
    {
        public int Id { get; set; }
        public int GonderenId { get; set; }
        public int TakipEdilenId { get; set; }
        public string GonderiIcerik { get; set; }
        public string GonderiImagePath { get; set; }
        public int AdayId { get; set; }
        public string AdayImagePath { get; set; }
        public string AdayAd { get; set; }
        public string AdaySoyad { get; set; }
        public DateTime GonderiTarih { get; set; }


    }
}
