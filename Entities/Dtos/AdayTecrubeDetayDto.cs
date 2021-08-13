using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class AdayTecrubeDetayDto:IDto
    {
        public int Id { get; set; }
        public int AdayId { get; set; }
        public int SirketId { get; set; }
        public string SirketAdi { get; set; }
        public string SirketSektor { get; set; }
        public string SirketImagePath { get; set; }
        public int PozisyonId { get; set; }
        public DateTime IsGirisTarih { get; set; }
        public DateTime IsCikisTarih { get; set; }
        public string PozisyonAd { get; set; }
    }
}
