using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Begeni:IEntity
    {
        public int Id { get; set; }
        public int BegenenId { get; set; }
        public int GonderiId { get; set; }
        public DateTime BegeniTarih { get; set; }
    }
}
