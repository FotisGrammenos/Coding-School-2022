using Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gas_Station.EF.Context;

namespace Gas_Station.EF.Repos
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        private readonly GasStationContext _context;

        public CustomerRepo(GasStationContext dbcontext)
        {
            _context = dbcontext;
        }

        public async Task AddAsync(Customer entity)
        {
            await AddLogic(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            DeleteLogic(id);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
           return await _context.Customers.ToListAsync();
        }

        public async Task<Customer?> GetByIdAsynv(Guid id)
        {
            return await _context.Customers.SingleOrDefaultAsync(customer=>customer.ID==id);
        }

        public async Task UpdateAsync(Guid id, Customer entity)
        {
            UpdateLogic(id,entity);
            await _context.SaveChangesAsync();
        }

        private async Task AddLogic(Customer entity)
        {
            if (entity.ID == Guid.Empty)
                throw new ArgumentException("Given Customer should not have id set", nameof(entity.ID));
            _context.Customers.Add(entity);
        }

        private void DeleteLogic(Guid id)
        {
            var currCustomer= _context.Customers.SingleOrDefault(customer=>customer.ID==id);
            if (currCustomer is null)
                throw new ArgumentException($"Given id '{id}' was not found in database");
            _context.Customers.Remove(currCustomer);
        }

        private void UpdateLogic(Guid id, Customer entity)
        {
            var currCustomer = _context.Customers.SingleOrDefault(customer=>customer.ID==id);
            if(currCustomer is null)
                throw new ArgumentException($"Given id '{id}' was not found in database");
            currCustomer.Name = entity.Name;
            currCustomer.Surname = entity.Surname;
 
        }
    }
}
