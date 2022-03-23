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
    internal class CustomerRepo: IEntityRepo<Customer>
    {
        public async Task Create(Customer entity)
        {
            using var context = new CarServiceContext();
            context.Customers.Add(entity);
            await context.SaveChangesAsync();
        }
        public async Task Delete(Guid id)
        {
            using var context = new CarServiceContext();
            var foundTodo = context.Customers.SingleOrDefault(todo => todo.ID == id);
            if (foundTodo is null)
                return;
            context.Customers.Remove(foundTodo);
            await context.SaveChangesAsync();
        }
        public List<Customer> GetAll()
        {
            using var context = new CarServiceContext();
            return context.Customers.ToList();
        }
        public Customer? GetById(Guid id)
        {
            using var context = new CarServiceContext();
            return context.Customers.Where(todo => todo.ID == id).SingleOrDefault();
        }
        public async Task Update(Guid id, Customer entity)
        {
            using var context = new CarServiceContext();
            var foundTodo = context.Customers.Include(todo => todo.ID).SingleOrDefault(todo => todo.ID == id);
            if (foundTodo is null)
                return;
            foundTodo.Name = entity.Name;
            foundTodo.TIN = entity.TIN;
            foundTodo.Surname = entity.Surname;
            foundTodo.Phone = entity.Phone;
            await context.SaveChangesAsync();
        }

    }
}
