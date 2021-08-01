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

        public async Task<Car> AddCarAsync(Car car)
        {
            var addedEntity = Db.ExampleEntities.Add(car);
            if (await Db.SaveChangesAsync() == 1)
                return addedEntity.Entity;
            else
                return new Car();
        }

        public async Task<Car> GetCarByIdAsync(int id) 
        {
            var entityQueried = await Db.ExampleEntities.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (entityQueried != null)
                return entityQueried;
            else
                return new Car();
        }

        public async Task<List<Car>> GetAllCarsAsListAsync() 
        {
            return await Db.ExampleEntities.ToListAsync();
        }

        public async Task<bool> EditCarAsync(Car entity)
        {
            Db.ExampleEntities.Update(entity);
            if (await Db.SaveChangesAsync() != 1)
                return false;
            else
                return true;
        }

        public async Task<int> DeleteCarAsync(Car entity)
        {
            Db.ExampleEntities.Remove(entity);
            return await Db.SaveChangesAsync();
        }
        
    }
}
