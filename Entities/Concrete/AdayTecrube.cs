using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AdayTecrube:IEntity
    {
        public int Id { get; set; }
        public int AdayId { get; set; }
        public int SirketId { get; set; }
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public int PozisyonId { get; set; }
    }
}
