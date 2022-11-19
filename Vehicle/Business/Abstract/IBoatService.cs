using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBoatService
    {
        void Add(Boat boat);
        void Update(Boat boat); 
        void Delete(Boat boat); 
        Boat Get(int id);
        List<Boat> GetAll();   
        List<Boat> GetCarsByColor(string color);



    }
}
