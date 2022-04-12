using Gas_Station.EF.Context;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.EF.Repos
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        private readonly GasStationContext _context;

        public TransactionRepo(GasStationContext dbcontext)
        {
            _context = dbcontext;
        }
        public async Task AddAsync(Transaction entity)
        {
            await AddLogic(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            DeleteLogic(id);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await _context.Transactions.Include(trasaction=>trasaction.Customer)
                                                    .Include(trasaction => trasaction.Employee)
                                                    .Include(trasaction=> trasaction.TransactionLines)
                                                    .ToListAsync();
        }

        public async Task<Transaction?> GetByIdAsync(Guid id)
        {
            return await _context.Transactions.Include(trasaction => trasaction.Customer)
                                                    .Include(trasaction => trasaction.Employee)
                                                    .Include(trasaction => trasaction.TransactionLines)
                                                    .SingleOrDefaultAsync(trasaction => trasaction.ID == id);
        }

        public async Task UpdateAsync(Guid id, Transaction entity)
        {
            UpdateLogic(id, entity);
            await _context.SaveChangesAsync();
        }

        private async Task AddLogic(Transaction entity)
        {
            if (entity.ID == Guid.Empty)
                throw new ArgumentException("Given Trasnaction should not have id set", nameof(entity.ID));
            _context.Transactions.Add(entity);
        }

        private void DeleteLogic(Guid id)
        {
            var currTransaction = _context.Transactions.SingleOrDefault(trasaction => trasaction.ID == id);
            if (currTransaction is null)
                throw new ArgumentException($"Given id '{id}' was not found in database");
            _context.Transactions.Remove(currTransaction);
        }

        private void UpdateLogic(Guid id, Transaction entity)
        {
            var currTransaction = _context.Transactions.SingleOrDefault(trasaction => trasaction.ID == id);
            if (currTransaction is null)
                throw new ArgumentException($"Given id '{id}' was not found in database");
            currTransaction.Date = entity.Date;
            currTransaction.TransactionLines = entity.TransactionLines;
            currTransaction.TotalValue = entity.TotalValue;
            currTransaction.CustomerID = entity.CustomerID;
            currTransaction.EmployeeID = entity.EmployeeID;
            currTransaction.PaymentMethod = entity.PaymentMethod;
        }
    }
}