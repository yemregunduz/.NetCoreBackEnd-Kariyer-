using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfOkulDal: EfEntityRepositoryBase<Okul, KariyerNetContext>,IOkulDal
    {
    }
}
