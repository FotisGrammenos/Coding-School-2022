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
    internal class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public async Task Create(TransactionLine entity)
        {
            using var context = new CarServiceContext();
            context.TransactionLines.Add(entity);
            await context.SaveChangesAsync();
        }
        public async Task Delete(Guid id)
        {
            using var context = new CarServiceContext();
            var foundTodo = context.TransactionLines.SingleOrDefault(todo => todo.ID == id);
            if (foundTodo is null)
                return;
            context.TransactionLines.Remove(foundTodo);
            await context.SaveChangesAsync();
        }
        public List<TransactionLine> GetAll()
        {
            using var context = new CarServiceContext();
            return context.TransactionLines.ToList();
        }
        public TransactionLine? GetById(Guid id)
        {
            using var context = new CarServiceContext();
            return context.TransactionLines.Where(todo => todo.ID == id).SingleOrDefault();
        }
        public async Task Update(Guid id, TransactionLine entity)
        {
            return;
        }
    }
}
