using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class AdayDetayDto : IDto
    {
        public int AdayDetayId { get; set; }
        public int SirketId { get; set; }
        public int AdayYabanciDilId { get; set; }
        public int YabanciDilId { get; set; }
        public string YabanciDilAd { get; set; }
        public int YabanciDilSeviye { get; set; }
        public string SirketAdi { get; set; }
        public string SirketAdres { get; set; }
        public string SirketSektor { get; set; }
        public int AdayOkulBolumId { get; set; }
        public int OkulBolumId { get; set; }
        public int SirketSehirId { get; set; }
        public string SirketImagePath { get; set; }
        public string SirketSehirAdi { get; set; }
        public string SirketTelNo { get; set; }
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public int PozisyonId { get; set; }
        public string PozisyonAd { get; set; }
        public string PozisyonImagePath { get; set; }
        public int AdayId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public DateTime? OkulGirisTarih { get; set; }
        public DateTime? OkulCikisTarih { get; set; }
        public string AdayImagePath { get; set; }
        public int DogumYili { get; set; }
        public string AdayTelNo { get; set; }
        public string AdayAdres { get; set; }
        public int SehirId { get; set; }
        public string SehirAdi { get; set; }
        public string Email { get; set; }
        public string AdayFacebook { get; set; }
        public string AdayInstagram { get; set; }
        public string AdayTwitter { get; set; }
        public string AdayGithub { get; set; }
        public string AdayLinkedin { get; set; }
        public int OkulId { get; set; }
        public int BolumId { get; set; }
        public string OkulAdi { get; set; }
        public string OkulImagePath { get; set; }
        public string BolumAdi { get; set; }
        public string OkulTip { get; set; }
        public byte[] SifreSalt { get; set; }
        public byte[] SifreHash { get; set; }



    }
}
