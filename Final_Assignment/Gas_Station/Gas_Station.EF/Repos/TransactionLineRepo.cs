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
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        private readonly GasStationContext _context;

        public TransactionLineRepo(GasStationContext dbcontext)
        {
            _context = dbcontext;
        }
        public async Task AddAsync(TransactionLine entity)
        {
            AddLogic(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            DeleteLogic(id);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TransactionLine>> GetAllAsync()
        {
            return await _context.TransactionsLine.Include(tl=>tl.Transaction)
                                                  .Include(tl=>tl.Item)
                                                  .ToListAsync();
        }

        public async Task<TransactionLine?> GetByIdAsync(Guid id)
        {
           return await _context.TransactionsLine.Include(tl=>tl.Transaction)
                                                 .Include(tl=>tl.Item)
                                                 .SingleOrDefaultAsync(tl=>tl.ID==id);
        }

        public async Task UpdateAsync(Guid id, TransactionLine entity)
        {
            UpdateLogic(id, entity);
            await _context.SaveChangesAsync();
        }

        private async Task AddLogic(TransactionLine entity)
        {
            if (entity.ID == Guid.Empty)
                throw new ArgumentException("Given Trasnaction should not have id set", nameof(entity.ID));
            _context.TransactionsLine.Add(entity);
        }

        private void DeleteLogic(Guid id)
        {
            var currTransactionLine = _context.TransactionsLine.SingleOrDefault(tl => tl.ID == id);
            if (currTransactionLine is null)
                throw new ArgumentException($"Given id '{id}' was not found in database");
            _context.TransactionsLine.Remove(currTransactionLine);
        }

        private void UpdateLogic(Guid id, TransactionLine entity)
        {
            var currTransactionLine = _context.TransactionsLine.SingleOrDefault(tl => tl.ID == id);
            if (currTransactionLine is null)
                throw new ArgumentException($"Given id '{id}' was not found in database");
            currTransactionLine.ItemID = entity.ItemID;
            currTransactionLine.DiscountPercent = entity.DiscountPercent;
            currTransactionLine.ItemPrice = entity.ItemPrice;
            currTransactionLine.Quantity = entity.Quantity;
            currTransactionLine.NetValue = entity.NetValue;
            currTransactionLine.TotalValue = entity.TotalValue;
            currTransactionLine.DiscountValue = entity.DiscountValue;
           
        }
    }
}
