using Gas_Station.EF.Repos;
using Gas_Station.Shared;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionLineController : ControllerBase
    {
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;

        public TransactionLineController(IEntityRepo<TransactionLine> transactionRepo)
        {
            _transactionLineRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionLineViewModels>> Get()
        {
            var trasnaction = await _transactionLineRepo.GetAllAsync();
            return trasnaction.Select(x => new TransactionLineViewModels
            {
                ID = x.ID,
                ItemDescription = x.Item.Description,
                ItemPrice = x.Item.Price,
                NetValue = x.NetValue,
                DiscountPercent = x.DiscountPercent,
                Quentity = x.Quantity,
                DiscountValue = x.DiscountValue,
                TotalValue = x.TotalValue,

            }) ;
        }

        [HttpGet("{id}")]
        public async Task<TransactionLineEditViewModel> Get(Guid id)
        {
            var getTransactionLine = new TransactionLineEditViewModel();
            if (id != Guid.Empty)
            {
                var existing = await _transactionLineRepo.GetByIdAsync(id);
                if (existing == null) throw new ArgumentException($"Given id '{id}' was not found in database");

                getTransactionLine.ItemID = existing.ID;
                getTransactionLine.Quentity = existing.Quantity;
                getTransactionLine.NetValue = existing.NetValue;
                getTransactionLine.TotalValue = existing.TotalValue;
                getTransactionLine.DiscountValue = existing.DiscountValue;
                getTransactionLine.DiscountPercent = existing.DiscountPercent;
                getTransactionLine.ItemPrice = existing.Item.Price;

            }
            return getTransactionLine;
        }

        [HttpPost]
        public async Task Post(TransactionLineEditViewModel model)
        {
            var newTransactionLine = new TransactionLine()
            {
                ID = model.ID,
                TransactionID = model.TransactionID,
                ItemID = model.ItemID,
                ItemPrice = model.ItemPrice,
                Quantity=model.Quentity,
                NetValue = model.NetValue,
                TotalValue = model.TotalValue,
                DiscountValue = model.DiscountValue,
                DiscountPercent = model.DiscountPercent,

            };

            await _transactionLineRepo.AddAsync(newTransactionLine);
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionLineEditViewModel model)
        {
            var transactionLineUpdate = await _transactionLineRepo.GetByIdAsync(model.ID);
            if (transactionLineUpdate == null) return NotFound();
            transactionLineUpdate.ItemID = model.ItemID;
            transactionLineUpdate.ItemPrice = model.ItemPrice;
            transactionLineUpdate.Quantity = model.Quentity;
            transactionLineUpdate.NetValue = model.NetValue;
            transactionLineUpdate.TotalValue = model.TotalValue;
            transactionLineUpdate.DiscountValue = model.DiscountValue;
            transactionLineUpdate.DiscountPercent = model.DiscountPercent;
            

            await _transactionLineRepo.UpdateAsync(transactionLineUpdate.ID, transactionLineUpdate);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _transactionLineRepo.DeleteAsync(id);
        }
    }
}
