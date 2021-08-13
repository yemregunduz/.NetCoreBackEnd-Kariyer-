using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sirket : IEntity
    {
        public int Id { get; set; }
        public int SehirId { get; set; }
        public string SirketAdi { get; set; }
        public string Adres { get; set; }
        public string Sektor { get; set; }
        public string SirketTelNo { get; set; }
        public string SirketImagePath { get; set; }
    }
}
