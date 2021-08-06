using Blazor_EfCore_SqliteTemplate.Data;
using Blazor_EfCore_SqliteTemplate.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_EfCore_SqliteTemplate.Repository
{
    public class CarRepo : ICarRepo
    {
        private ApplicationDbContext Db { get; set; }

        public CarRepo(ApplicationDbContext context)
        {
            Db = context;
        }

        // Returns the number of records affected.
        public async Task<int> AddCarAsync(Car car)
        {
            Db.Cars.Add(car);
            return await Db.SaveChangesAsync();
        }

        public async Task<Car> GetCarByIdAsync(int id) 
        {
            return await Db.Cars.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Car>> GetAllCarsAsListAsync() 
        {
            return await Db.Cars.ToListAsync();
        }

        public async Task<int> EditCarAsync(Car entity)
        {
            Db.Cars.Update(entity);
            return await Db.SaveChangesAsync();
        }

        public async Task<int> DeleteCarAsync(Car entity)
        {
            Db.Cars.Remove(entity);
            return await Db.SaveChangesAsync();
        }
        
    }
}
