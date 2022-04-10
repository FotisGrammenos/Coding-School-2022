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
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        private readonly GasStationContext _context;

        public EmployeeRepo(GasStationContext dbcontext)
        {
            _context = dbcontext;
        }
        public async Task AddAsync(Employee entity)
        {
            await AddLogic(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            DeleteLogic(id);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsynv(Guid id)
        {
            return await _context.Employees.SingleOrDefaultAsync(transaction => transaction.ID == id);
        }

        public async Task UpdateAsync(Guid id, Employee entity)
        {
            UpdateLogic(id, entity);
            await _context.SaveChangesAsync();
        }

        private async Task AddLogic(Employee entity)
        {
            if (entity.ID == Guid.Empty)
                throw new ArgumentException("Given Employee should not have id set", nameof(entity.ID));
            _context.Employees.Add(entity);
        }

        private void DeleteLogic(Guid id)
        {
            var currEmployee = _context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (currEmployee is null)
                throw new ArgumentException($"Given id '{id}' was not found in database");
            _context.Employees.Remove(currEmployee);
        }

        private void UpdateLogic(Guid id, Employee entity)
        {
            var currEmployee = _context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (currEmployee is null)
                throw new ArgumentException($"Given id '{id}' was not found in database");
            currEmployee.Name = entity.Name;
            currEmployee.Surname = entity.Surname;
            currEmployee.Role = entity.Role;
            currEmployee.SallaryPerMonth = entity.SallaryPerMonth;
            currEmployee.HireDateEnd = entity.HireDateEnd;
            currEmployee.HireDateStart = entity.HireDateStart;
        }
    }
}
