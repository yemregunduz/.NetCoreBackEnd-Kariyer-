using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Pozisyon:IEntity
    {
        public int Id { get; set; }
        public string PozisyonAd { get; set; }
        public string ImagePath { get; set; }
    }
}
