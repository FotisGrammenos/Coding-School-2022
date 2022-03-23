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
    internal class ServiceTaskRepo : IEntityRepo<ServiceTask>
    {
        public async Task Create(ServiceTask entity)
        {
            using var context = new CarServiceContext();
            context.ServiceTasks.Add(entity);
            await context.SaveChangesAsync();
        }
        public async Task Delete(Guid id)
        {
            using var context = new CarServiceContext();
            var foundTodo = context.ServiceTasks.SingleOrDefault(todo => todo.ID == id);
            if (foundTodo is null)
                return;
            context.ServiceTasks.Remove(foundTodo);
            await context.SaveChangesAsync();
        }
        public List<ServiceTask> GetAll()
        {
            using var context = new CarServiceContext();
            return context.ServiceTasks.ToList();
        }
        public ServiceTask? GetById(Guid id)
        {
            using var context = new CarServiceContext();
            return context.ServiceTasks.Where(todo => todo.ID == id).SingleOrDefault();
        }
        public async Task Update(Guid id, ServiceTask entity)
        {
            using var context = new CarServiceContext();
            var foundTodo = context.ServiceTasks.FirstOrDefault(todo => todo.ID==id);
            if (foundTodo is null)
                return;
            foundTodo.Code = entity.Code;
            foundTodo.Description=entity.Description;
            foundTodo.Hours = entity.Hours;

            await context.SaveChangesAsync();
        }
    }
}
