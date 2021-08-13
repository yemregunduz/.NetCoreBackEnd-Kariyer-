using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Bolum:IEntity
    {
        public int Id { get; set; }
        public string BolumAdi { get; set; }
    }
}
