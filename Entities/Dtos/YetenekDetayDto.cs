using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class YetenekDetayDto:IDto
    {
        public int YetenekId { get; set; }
        public int YetenekTipId { get; set; }
        public string YetenekTipi { get; set; }
        public string YetenekAdi { get; set; }
    }
}
