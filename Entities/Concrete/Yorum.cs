using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Yorum:IEntity
    {
        public int Id { get; set; }
        public int GonderiId { get; set; }
        public int YorumcuId { get; set; }
        public string YorumIcerik { get; set; }
        public DateTime YorumTarih { get; set; }
    }
}
