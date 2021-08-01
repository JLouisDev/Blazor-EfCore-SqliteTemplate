﻿using Blazor_EfCore_SqliteTemplate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_EfCore_SqliteTemplate.Repository
{
    public interface ICarRepo
    {
        Task<Car> AddCarAsync(Car car);
        Task<int> DeleteCarAsync(Car entity);
        Task<bool> EditCarAsync(Car entity);
        Task<List<Car>> GetAllCarsAsListAsync();
        Task<Car> GetCarByIdAsync(int id);
    }
}
