using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Aday:IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public int DogumYili { get; set; }
        
        public string AdayImagePath { get; set; }
        public string AdayTelNo { get; set; }
        public string AdayAdres { get; set; }
        public int? SehirId { get; set; }
        public string AdayFacebook { get; set; }
        public string AdayTwitter { get; set; }
        public string AdayInstagram { get; set; }
        public string AdayGithub { get; set; }
        public string AdayLinkedin { get; set; }
        public string Email { get; set; }
        public byte[] SifreSalt { get; set; }
        public byte[] SifreHash { get; set; }

    }
}
