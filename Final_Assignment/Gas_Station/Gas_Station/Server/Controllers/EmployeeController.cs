using Gas_Station.EF.Repos;
using Gas_Station.Shared;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employee)
        {
            _employeeRepo = employee;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListViewModel>> Get()
        {
            var employee =await _employeeRepo.GetAllAsync();
            return employee.Select(x => new EmployeeListViewModel
            {
                Id=x.ID,
                Name=x.Name,
                SallaryPerMonth=x.SallaryPerMonth,
                Surname=x.Surname,
                HireDateStart=x.HireDateStart,
                HireDateEnd=x.HireDateEnd,
                Role=x.Role
            });
        }

        [HttpGet("{id}")]
        public async Task<EmployeeListViewModel> Get(Guid id)
        {
            var getEmployee = new EmployeeListViewModel();
            if (id != Guid.Empty)
            {
                var existing=await _employeeRepo.GetByIdAsync(id);
                if(existing == null) throw new ArgumentException($"Given id '{id}' was not found in database");

                getEmployee.Id=existing.ID;
                getEmployee.Name=existing.Name;
                getEmployee.SallaryPerMonth=existing.SallaryPerMonth;
                getEmployee.Surname=existing.Surname;
                getEmployee.HireDateStart=existing.HireDateStart;
                getEmployee.HireDateEnd=existing.HireDateEnd;
                getEmployee.Role=existing.Role;
            }
            return getEmployee;
        }

        [HttpPost]
        public async Task Post(EmployeeEditViewModel model)
        {
            var newEmployee = new Employee()
            {
                Name = model.Name,
                SallaryPerMonth = model.SallaryPerMonth,
                Surname = model.Surname,
                HireDateStart = model.HireDateStart,
                HireDateEnd = model.HireDateEnd,
                Role = model.Role
            };

            await _employeeRepo.AddAsync(newEmployee);
        }

        [HttpPut]
        public async Task<ActionResult> Put(EmployeeEditViewModel model)
        {
            var customerUpdate= await _employeeRepo.GetByIdAsync(model.Id);
            if(customerUpdate==null) return NotFound();
            customerUpdate.Name=model.Name;
            customerUpdate.SallaryPerMonth=model.SallaryPerMonth;
            customerUpdate.Surname=model.Surname;
            customerUpdate.HireDateStart=model.HireDateStart;
            customerUpdate.HireDateEnd=model.HireDateEnd;
            customerUpdate.Role=model.Role;

            await _employeeRepo.UpdateAsync(model.Id, customerUpdate);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _employeeRepo.DeleteAsync(id);
        }
    }
}
