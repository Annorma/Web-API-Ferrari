using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface FerrariService
    {
        IEnumerable<CarDTO> GetAll();
        CarDTO? Get(int id);
        void Create(CarDTO car);
        void Edit(CarDTO car);
        void Delete(int id);
    }
}
