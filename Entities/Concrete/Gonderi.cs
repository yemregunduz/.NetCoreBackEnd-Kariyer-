using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gonderi:IEntity
    {
        public int Id { get; set; }
        public int GonderenId { get; set; }
        public string GonderiIcerik { get; set; }
        public string GonderiImagePath { get; set; }
        public DateTime GonderiTarih { get; set; }
    }
}
