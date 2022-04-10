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
    public class ItemRepo : IEntityRepo<Item>
    {
        private readonly GasStationContext _context;

        public ItemRepo(GasStationContext dbcontext)
        {
            _context = dbcontext;
        }
        public async Task AddAsync(Item entity)
        {
            await AddLogic(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            DeleteLogic(id);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item?> GetByIdAsynv(Guid id)
        {
            return await _context.Items.SingleOrDefaultAsync(item => item.ID == id);
        }

        public async Task UpdateAsync(Guid id, Item entity)
        {
            UpdateLogic(id, entity);
            await _context.SaveChangesAsync();
        }

        private async Task AddLogic(Item entity)
        {
            if (entity.ID == Guid.Empty)
                throw new ArgumentException("Given Item should not have id set", nameof(entity.ID));
            _context.Items.Add(entity);
        }

        private void DeleteLogic(Guid id)
        {
            var currItem = _context.Items.SingleOrDefault(item => item.ID == id);
            if (currItem is null)
                throw new ArgumentException($"Given id '{id}' was not found in database");
            _context.Items.Remove(currItem);
        }

        private void UpdateLogic(Guid id, Item entity)
        {
            var currItem = _context.Items.SingleOrDefault(item => item.ID == id);
            if (currItem is null)
                throw new ArgumentException($"Given id '{id}' was not found in database");
            currItem.Description=entity.Description;
            currItem.Price=entity.Price;
            currItem.Cost=entity.Cost;
            currItem.Type=entity.Type;

        }
    }
}
