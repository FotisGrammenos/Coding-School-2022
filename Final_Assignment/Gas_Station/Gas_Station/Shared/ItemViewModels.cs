using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Gas_Station.Shared
{
    public class ItemListViewModel
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public ItemType Type { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }
    }

    public class ItemEditViewModel
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public ItemType Type { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }
    }
}
