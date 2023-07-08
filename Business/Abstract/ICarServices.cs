﻿using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarServices : IEntityServices<Car>
    {
        //public List<Car> GetById(int id);
        //public List<Car> GetAll();
        //void Add(Car car);
        //void Delete(Car car);
        //void Update();
        public List<CarDetailDto> GetCarDetails();
    }
}
