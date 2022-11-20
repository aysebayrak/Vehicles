using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBusService
    {
        void Add(Bus bus);
        void Delete(Bus bus);
        void Update(Bus bus);
        List<Bus> GetAll();
        Bus GetId(int id);
        List<Bus> GetColor(string color);
        


    }
}
