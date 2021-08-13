using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SistemPersonel:IEntity
    {
        public int Id { get; set; }
        public int PozisyonId { get; set; }
        public string Email { get; set; }
        public byte[] SifreSalt { get; set; }
        public byte[] SifreHash { get; set; }
    }
}
