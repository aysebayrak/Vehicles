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
    public class BusManager : IBusService
    {
        IBusDal _busDal;

        public BusManager(IBusDal busDal)
        {
            _busDal = busDal;
        }



        public void Add(Bus bus)
        {
            throw new NotImplementedException();
        }

        public void Delete(Bus bus)
        {
            throw new NotImplementedException();
        }

        public List<Bus> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Bus> GetCarsByColor(string color)
        {
            throw new NotImplementedException();
        }

        public Bus GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool OnOffHeadLights(int carId)
        {
            throw new NotImplementedException();
        }

        public void Update(Bus bus)
        {
            throw new NotImplementedException();
        }
    }
}
