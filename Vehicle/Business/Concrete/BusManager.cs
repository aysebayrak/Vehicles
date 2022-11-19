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
            _busDal.Add(bus);
        }

        public void Delete(Bus bus)
        {
            _busDal.Delete(bus);
        }

        public List<Bus> GetAll()
        {
            return _busDal.GetAll();    
        }

        public List<Bus> GetCarsByColor(string color)
        {
            throw new NotImplementedException();
        }

        public Bus GetId(int id)
        {
            return _busDal.Get(b => b.Id == id);
        }

     

        public void Update(Bus bus)
        {
            _busDal.UpDate(bus);
        }
    }
}
