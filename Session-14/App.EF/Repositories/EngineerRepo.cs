using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.EF.Context;
using DataLibrary;
using Microsoft.EntityFrameworkCore;

namespace App.EF.Repositories
{
    internal class EngineerRepo : IEntityRepo<Engineer>
    {
        public async Task Create(Engineer entity)
        {
            using var context = new CarServiceContext();
            context.Engineers.Add(entity);
            await context.SaveChangesAsync();
        }
        public async Task Delete(Guid id)
        {
            using var context = new CarServiceContext();
            var foundTodo = context.Engineers.SingleOrDefault(todo => todo.ID == id);
            if (foundTodo is null)
                return;
            context.Engineers.Remove(foundTodo);
            await context.SaveChangesAsync();
        }
        public List<Engineer> GetAll()
        {
            using var context = new CarServiceContext();
            return context.Engineers.ToList();
        }
        public Engineer? GetById(Guid id)
        {
            using var context = new CarServiceContext();
            return context.Engineers.Where(todo => todo.ID == id).SingleOrDefault();
        }
        public async Task Update(Guid id, Engineer entity)
        {
            using var context = new CarServiceContext();
            var foundTodo = context.Engineers.Include(todo => todo.ID).SingleOrDefault(todo => todo.ID == id);
            if (foundTodo is null)
                return;
            foundTodo.Name = entity.Name;
            foundTodo.Surname = entity.Surname;
            foundTodo.SallaryPerMonth = entity.SallaryPerMonth;
            foundTodo.ManagerID = entity.ManagerID;
            
            //
            foundTodo.Manager.ID = entity.Manager.ID;
            //

            await context.SaveChangesAsync();
        }
    }
}
