using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AdayYetenek:IEntity
    {
        public int Id { get; set; }
        public int AdayId { get; set; }
        public int YetenekId { get; set; }
        public int YetenekSeviye { get; set; }
    }
}
