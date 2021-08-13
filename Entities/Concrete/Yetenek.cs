using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Yetenek:IEntity
    {
        public int Id { get; set; }
        public string YetenekAdi { get; set; }
        public int YetenekTipId { get; set; }

    }
}
