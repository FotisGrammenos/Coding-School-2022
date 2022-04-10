using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Model
{
    public class Item : BaseEntitie
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public ItemType Type { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public List<TransactionLine> TransactionLines { get; set; }

        public Item()
        {
            Code = Guid.NewGuid().ToString("N").Substring(0, 7);
        }
    }
}
