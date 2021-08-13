using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class KullaniciGirisDto:IDto
    {
        public string Email { get; set; }
        public string Sifre { get; set; }
    }
}
