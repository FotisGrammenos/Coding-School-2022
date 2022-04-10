using Gas_Station.EF.Repos;
using Gas_Station.Shared;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customer)
        {
            _customerRepo = customer;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListViewModel>> Get()
        {
            var customer = await _customerRepo.GetAllAsync();
            return customer.Select(x => new CustomerListViewModel
            {
                Id = x.ID,
                Name = x.Name,
                Surname = x.Surname,
                CardNumber = x.CardNumber
            });
        }

        [HttpGet("{id}")]
        public async Task<CustomerListViewModel> Get(Guid id)
        {
            var getCustomer = new CustomerListViewModel();
            if (id != Guid.Empty)
            {
                var existing = await _customerRepo.GetByIdAsync(id);
                if (existing == null) throw new ArgumentException($"Given id '{id}' was not found in database"); ;

                getCustomer.Id = existing.ID;
                getCustomer.Name = existing.Name;
                getCustomer.Surname = existing.Surname;
                getCustomer.CardNumber = existing.CardNumber;
            }
            return getCustomer;
        }

        [HttpPost]
        public async Task Post(CustomerEditViewModel customer)
        {
            var newCustomer = new Customer()
            {
  
                Name = customer.Name,
                Surname = customer.Surname,
                
            };

            await _customerRepo.AddAsync(newCustomer);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CustomerEditViewModel customer)
        {
            var customerUpdate= await _customerRepo.GetByIdAsync(customer.Id);
            if(customerUpdate == null) return NotFound();
            customerUpdate.Name = customer.Name;
            customerUpdate.Surname = customer.Surname;

            await _customerRepo.UpdateAsync(customer.Id, customerUpdate);
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _customerRepo.DeleteAsync(id);
        }
    }
}
