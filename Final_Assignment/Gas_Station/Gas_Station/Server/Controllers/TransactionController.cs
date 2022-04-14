using Gas_Station.EF.Repos;
using Gas_Station.Shared;
using Handlers;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Item> _itemRepo;


        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Item> transactionHandler)
        {
            _transactionRepo = transactionRepo;
            _itemRepo = transactionHandler;
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
                //var itemInside;

                getTransaction.ID = existing.ID;
                getTransaction.PayMentMethod = existing.PaymentMethod;
                getTransaction.TotalValue = existing.TotalValue;
                getTransaction.CustomerFullName = $"{existing.Customer.Name} {existing.Customer.Surname}";
                getTransaction.EmployeeFullName = $"{existing.Employee.Name} {existing.Employee.Surname}";
                getTransaction.CustomerID = existing.Customer.ID;
                getTransaction.EmployeeID = existing.Employee.ID;
                getTransaction.TransactionLineList = new();
                CovertTransactionLineToViewModel(getTransaction, existing);
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
                TransactionLines = new()

            };
            CovertViewModelLineToTransactionLine(model,newTransaction);
            
            
            

             await _transactionRepo.AddAsync(newTransaction);
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionEditViewModel transaction)
        {
            var transactionUpdate = await _transactionRepo.GetByIdAsync(transaction.ID);
            if (transactionUpdate == null) return NotFound();
            transactionUpdate.CustomerID = transaction.CustomerID;
            transactionUpdate.EmployeeID = transaction.EmployeeID;
            transactionUpdate.PaymentMethod = transaction.PayMentMethod;
            transactionUpdate.TransactionLines = new();
            CovertViewModelLineToTransactionLine(transaction, transactionUpdate);


            await _transactionRepo.UpdateAsync(transactionUpdate.ID, transactionUpdate);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _transactionRepo.DeleteAsync(id);
        }

        private void CovertViewModelLineToTransactionLine(TransactionEditViewModel model, Transaction newTransaction)
        {
            foreach (var tl in model.TransactionLineList)
            {
                var helper = new TransactionLine()
                {
                    ItemID = tl.ItemID,
                    ItemPrice = tl.ItemPrice,
                    NetValue = tl.NetValue,
                    DiscountPercent = tl.DiscountPercent,
                    DiscountValue = tl.DiscountValue,
                    TotalValue = tl.TotalValue,
                    Quantity = tl.Quentity,
                };
                newTransaction.TransactionLines.Add(helper);
            }
        }

        private void CovertTransactionLineToViewModel(TransactionEditViewModel model, Transaction newTransaction)
        {
            foreach (var tl in newTransaction.TransactionLines)
            {
                var helper = new TransactionLineEditViewModel()
                {

                    ItemID = tl.ItemID,
                    ItemPrice = tl.ItemPrice,
                    NetValue = tl.NetValue,
                    DiscountPercent = tl.DiscountPercent,
                    DiscountValue = tl.DiscountValue,
                    TotalValue = tl.TotalValue,
                    Quentity = tl.Quantity,
                    ItemDescription = tl.Item.Description
                };
                model.TransactionLineList.Add(helper);
            }
        }
    }
}
