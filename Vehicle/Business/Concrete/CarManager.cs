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
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
              _carDal.Add(car); 
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car GetId(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetColor(string color)
        {
            var cars = _carDal.GetAll(c =>c.Color.Contains(color)).ToList();
            return cars;
        }

        //public bool OnOffHeadLights(int carId)
        //{
        //    throw new NotImplementedException();
        //}

        public void Update(Car car)
        {
            _carDal.UpDate(car);
        }
    }
}
