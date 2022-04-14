using Gas_Station.EF.Context;
using Gas_Station.Shared;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Handlers
{
    public class TransactionHandler
    {

        public TransactionHandler()
        {
        }

        public decimal CalculateNetValue(decimal quantity, decimal price)
        {
            return quantity * price;
        }

        public decimal CalculateLineTotalValue(decimal discountValue, decimal netValue)
        {
            return netValue - discountValue;
        }

        public decimal CalculateTransactionTotalValue(List<TransactionLineEditViewModel> linesTotalValues)
        {
            return linesTotalValues.Sum(x=>x.TotalValue);
        }

        public decimal ApplyTenPercentDiscount(decimal netValue)
        {
            if (netValue >= 20)
            {
                return netValue * 0.10m;
            }
            return 0;
        }

        public bool CheckFuelExist(List<TransactionLineEditViewModel> transactionLines, List<ItemListViewModel> items)
        {

            foreach ( var tl in transactionLines)
            {
                var currItem = items.FirstOrDefault(i => i.Id == tl.ItemID);
                if(currItem is null) return false;
                if (currItem.Type == ItemType.Fuel)
                    return true;
            }
            return false;
        }

        public bool CheckCardPaymentAvail(decimal totalValue)
        {
            return totalValue <= 50;
        }
    }
}
