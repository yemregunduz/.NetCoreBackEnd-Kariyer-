using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Okul:IEntity
    {
        public int Id { get; set; }
        public string OkulAdi { get; set; }
        public string OkulImagePath { get; set; }
    }
}
