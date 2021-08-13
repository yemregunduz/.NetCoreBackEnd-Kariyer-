using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class TakipDetayDto:IDto
    {
        public int Id { get; set; }
        public int TakipciId { get; set; }
        public int TakipEdilenId { get; set; }
        public int AdayId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AdayImagePath { get; set; }
    }
}
