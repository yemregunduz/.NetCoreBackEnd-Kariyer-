using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Takip:IEntity
    {
        public int Id { get; set; }
        public int TakipciId { get; set; }
        public int TakipEdilenId { get; set; }
    }
}
