using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class AdayYetenekDetayDto:IDto
    {
        public int AdayYetenekId { get; set; }
        public int AdayId { get; set; }
        public int YetenekTipId { get; set; }
        public int YetenekId { get; set; }
        public string YetenekAdi { get; set; }
        public string YetenekTipi { get; set; }
        public int YetenekSeviye { get; set; }
    }
}
