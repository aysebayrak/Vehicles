using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
   public class EfBoatDal : EfEntityRepositoryBase<Boat,Context > ,IBoatDal
    {
    }
}
