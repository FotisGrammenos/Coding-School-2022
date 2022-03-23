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
    internal class TransactionRepo : IEntityRepo<Transaction>
    {
        public async Task Create(Transaction entity)
        {
            using var context = new CarServiceContext();
            context.Transactions.Add(entity);
            await context.SaveChangesAsync();
        }
        public async Task Delete(Guid id)
        {
            using var context = new CarServiceContext();
            var foundTodo = context.Transactions.SingleOrDefault(todo => todo.ID == id);
            if (foundTodo is null)
                return;
            context.Transactions.Remove(foundTodo);
            await context.SaveChangesAsync();
        }
        public List<Transaction> GetAll()
        {
            using var context = new CarServiceContext();
            return context.Transactions.ToList();
        }
        public Transaction? GetById(Guid id)
        {
            using var context = new CarServiceContext();
            return context.Transactions.Where(todo => todo.ID == id).SingleOrDefault();
        }
        public async Task Update(Guid id, Transaction entity)
        {
            return;
        }
    }
}
