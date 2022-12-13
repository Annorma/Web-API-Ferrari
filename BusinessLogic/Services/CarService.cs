using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CarService : FerrariService
    {
        private readonly IRepository<Car> carRep;
        private readonly IMapper mapper;

        public CarService(IRepository<Car> carRep, IMapper mapper)
        {
            this.carRep = carRep;
            this.mapper = mapper;
        }

        public void Create(CarDTO car)
        {
            carRep.Insert(mapper.Map<Car>(car));
            carRep.Save();
        }

        public void Delete(int id)
        {
            var car = carRep.GetByID(id);

            if (car == null) 
                throw new HttpException(ErrorMessages.CarNotFound, HttpStatusCode.NotFound);

            carRep.Delete(car);
            carRep.Save();
        }

        public void Edit(CarDTO car)
        {
            carRep.Update(mapper.Map<Car>(car));
            carRep.Save();
        }

        public CarDTO? Get(int id)
        {
            var car = carRep.GetByID(id);

            if (car == null) 
                throw new HttpException(ErrorMessages.CarNotFound, HttpStatusCode.NotFound);

            return mapper.Map<CarDTO>(car);
        }

        public IEnumerable<CarDTO> GetAll()
        {
            var car = carRep.Get(includeProperties: $"{nameof(Car.Color)}");
            return mapper.Map<IEnumerable<CarDTO>>(car);
        }
    }
}
