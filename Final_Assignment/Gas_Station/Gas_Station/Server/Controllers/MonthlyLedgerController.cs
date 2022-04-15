using Gas_Station.Shared;
using Handlers;
using Microsoft.AspNetCore.Mvc;
using Model;


namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LedgerController : ControllerBase
    {
        private readonly LedgerHandler _handler;

        public LedgerController(LedgerHandler ledgerHandler)
        {
            _handler = ledgerHandler;
        }

        [HttpGet("{year}/{month}/{rent}")]
        public async Task<MonthlyLendegViewModle> Get(int year, int month, decimal rent)
        {
            var ledgerViewModel = new MonthlyLendegViewModle()
            {
                Year = year,
                Month = month
            };
            var ledger = new Ledger()
            {
                Year = year,
                Month = month
            };
            _handler.SetRentCost(rent);
            ledgerViewModel.Income =await _handler.GetIncome(ledger);
            ledgerViewModel.Expenses =await _handler.GetTotalExpences(ledger);
            ledgerViewModel.Total =await _handler.GetTotal(ledger);
            return ledgerViewModel;
        }
    }
}
