using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class IsverenDetayDto:IDto
    {
        public int Id { get; set; }
        public int SirketId { get; set; }
        public int SehirId { get; set; }
        public string SehirAdi { get; set; }
        public string WebSite { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public byte[] SifreSalt { get; set; }
        public byte[] SifreHash { get; set; }
        public string SirketAdi { get; set; }
        public string Adres { get; set; }
        public string Sektor { get; set; }
        public string SirketTelNo { get; set; }
        public string SirketImagePath { get; set; }
    }
}
