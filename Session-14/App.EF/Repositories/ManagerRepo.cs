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
    internal class ManagerRepo : IEntityRepo<Manager>
    {
        public async Task Create(Manager entity)
        {
            using var context = new CarServiceContext();
            context.Managers.Add(entity);
            await context.SaveChangesAsync();
        }
        public async Task Delete(Guid id)
        {
            using var context = new CarServiceContext();
            var foundTodo = context.Managers.SingleOrDefault(todo => todo.ID == id);
            if (foundTodo is null)
                return;
            context.Managers.Remove(foundTodo);
            await context.SaveChangesAsync();
        }
        public List<Manager> GetAll()
        {
            using var context = new CarServiceContext();
            return context.Managers.ToList();
        }
        public Manager? GetById(Guid id)
        {
            using var context = new CarServiceContext();
            return context.Managers.Where(todo => todo.ID == id).SingleOrDefault();
        }
        public async Task Update(Guid id, Manager entity)
        {
            using var context = new CarServiceContext();
            var foundTodo = context.Managers.Include(todo => todo.ID).SingleOrDefault(todo => todo.ID == id);
            if (foundTodo is null)
                return;
            foundTodo.Name = entity.Name;
            foundTodo.Surname = entity.Surname;
            foundTodo.SallaryPerMonth = entity.SallaryPerMonth;
           
            await context.SaveChangesAsync();
        }
    }
}
