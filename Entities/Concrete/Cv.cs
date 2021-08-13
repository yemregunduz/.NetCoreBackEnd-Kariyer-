using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Cv:IEntity
    {
        public int Id { get; set; }
        public int AdayId { get; set; }
        public string OnYazi { get; set; }
        
    }
}
