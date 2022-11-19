using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class BoatManager :IBoatService
    {
        IBoatDal _boatDal;
         
        public BoatManager(IBoatDal boatDal)
        {
            _boatDal = boatDal;
        }

        public void Add(Boat boat)
        {
            throw new NotImplementedException();
        }

        public void Delete(Boat boat)
        {
            throw new NotImplementedException();
        }

        public Boat Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Boat> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Boat> GetCarsByColor(string color)
        {
            throw new NotImplementedException();
        }

        public void Update(Boat boat)
        {
            throw new NotImplementedException();
        }
    }
}
