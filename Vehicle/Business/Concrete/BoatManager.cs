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
           _boatDal.Add(boat);
        }

        public void Delete(Boat boat)
        {
            _boatDal.Delete(boat);
        }

        public Boat Get(int id)
        {
            return _boatDal.Get(b => b.Id == id);
        }

        public List<Boat> GetAll()
        {
            return _boatDal.GetAll();
        }

        public List<Boat> GetColor(string color)
        {
            var boats = _boatDal.GetAll(b => b.Color.Contains(color)).ToList();
            return boats;
        }

        public void Update(Boat boat)
        {
            _boatDal.UpDate(boat);
        }
    }
}
