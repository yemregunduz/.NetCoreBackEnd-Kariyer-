using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sehir:IEntity
    {
        public int Id { get; set; }
        public string SehirAdi { get; set; }
    }
}
