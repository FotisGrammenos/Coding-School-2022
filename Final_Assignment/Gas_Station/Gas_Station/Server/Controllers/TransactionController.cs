using Gas_Station.EF.Repos;
using Gas_Station.Shared;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListViewModel>> Get()
        {
            var trasnaction = await _transactionRepo.GetAllAsync();
            return trasnaction.Select(x => new TransactionListViewModel
            {
                Id = x.ID,
                CustomerFullName =$"{x.Customer.Name} {x.Customer.Surname}",
                EmployeeFullName =$"{x.Employee.Name} {x.Employee.Surname}",
                PayMentMethod = x.PaymentMethod,
                Date = x.Date,
                TotalValue = x.TotalValue,

            });
        }

        [HttpGet("{id}")]
        public async Task<TransactionEditViewModel> Get(Guid id)
        {
            var getTransaction = new TransactionEditViewModel();
            if (id != Guid.Empty)
            {
                var existing = await _transactionRepo.GetByIdAsync(id);
                if (existing == null) throw new ArgumentException($"Given id '{id}' was not found in database");

                getTransaction.ID = existing.ID;
                getTransaction.PayMentMethod = existing.PaymentMethod;
                getTransaction.TotalValue = existing.TotalValue;
                getTransaction.CustomerFullName = $"{existing.Customer.Name} {existing.Customer.Surname}";
                getTransaction.EmployeeFullName = $"{existing.Employee.Name} {existing.Employee.Surname}";
                getTransaction.CustomerID = existing.Customer.ID;
                getTransaction.EmployeeID = existing.Employee.ID;
                getTransaction.TransactionLineList = existing.TransactionLines;
            }
            return getTransaction;
        }

        [HttpPost]
        public async Task Post(TransactionEditViewModel model)
        {
            var newTransaction = new Transaction()
            {
                Date = DateTime.Now,
                CustomerID = model.CustomerID,
                EmployeeID = model.EmployeeID,
                PaymentMethod = model.PayMentMethod,

                // TODO: Load state from previously suspended application
                //TotalValue = model.TotalValue,

                TransactionLines = model.TransactionLineList

            };

            await _transactionRepo.AddAsync(newTransaction);
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionEditViewModel transaction)
        {
            var transactionUpdate = await _transactionRepo.GetByIdAsync(transaction.ID);
            if (transactionUpdate == null) return NotFound();
            transactionUpdate.TransactionLines = transaction.TransactionLineList;
            transactionUpdate.CustomerID = transaction.CustomerID;
            transactionUpdate.EmployeeID = transaction.EmployeeID;
            transactionUpdate.PaymentMethod = transaction.PayMentMethod;

            await _transactionRepo.UpdateAsync(transactionUpdate.ID, transactionUpdate);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _transactionRepo.DeleteAsync(id);
        }
    }
}
