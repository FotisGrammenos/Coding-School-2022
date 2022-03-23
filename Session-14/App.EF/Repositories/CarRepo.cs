using App.EF.Context;
using DataLibrary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.Repositories
{
    public class CarRepo : IEntityRepo<Car>
    {
            public async Task Create(Car entity)
            {
                using var context = new CarServiceContext();
                context.Cars.Add(entity);
                await context.SaveChangesAsync();
            }
            public async Task Delete(Guid id)
            {
                using var context = new CarServiceContext();
                var foundTodo = context.Cars.SingleOrDefault(todo => todo.ID == id);
                if (foundTodo is null)
                    return;
                context.Cars.Remove(foundTodo);
                await context.SaveChangesAsync();
            }
            public List<Car> GetAll()
            {
                using var context = new CarServiceContext();
                return context.Cars.ToList();
            }
            public Car? GetById(Guid id)
            {
                using var context = new CarServiceContext();
                return context.Cars.Where(todo => todo.ID == id).SingleOrDefault();
            }
            public async Task Update(Guid id, Car entity)
            {
                using var context = new CarServiceContext();
                var foundTodo = context.Cars.Include(todo => todo.ID).SingleOrDefault(todo => todo.ID == id);
                if (foundTodo is null)
                    return;
                foundTodo.Brand = entity.Brand;
                foundTodo.CarRegNumber = entity.CarRegNumber;
                await context.SaveChangesAsync();
            }
        
    }
}
