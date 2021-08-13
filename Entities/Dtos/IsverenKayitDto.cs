using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class IsverenKayitDto:IDto
    {
        public string Email { get; set; }
        public string Sifre { get; set; }
        public int SirketId { get; set; }
        public string WebSite { get; set; }
        public string TelNo { get; set; }
        

    }
}
