using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OkulBolum:IEntity
    {
        public int Id { get; set; }
        public int OkulId { get; set; }
        public int BolumId { get; set; }
        
    }
}
