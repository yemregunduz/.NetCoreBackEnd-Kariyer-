using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Isveren:IEntity
    {
        public int Id { get; set; }
        public int SirketId { get; set; }
        public string WebSite { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public byte[] SifreSalt { get; set; }
        public byte[] SifreHash { get; set; }
    }
}
