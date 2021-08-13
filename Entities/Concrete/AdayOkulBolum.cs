using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AdayOkulBolum : IEntity
    {
        public int Id { get; set; }
        public int AdayId { get; set; }
        public int OkulBolumId { get; set; }
        public DateTime? OkulGirisTarih { get; set; }
        public DateTime? OkulCikisTarih { get; set; }
        public string OkulTip { get; set; }
    }
}
