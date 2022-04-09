using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Customer : BaseEntitie
	{
		public string Name { get; set; }

		public string Surname { get; set; }

		public Guid CardNumber { get; set; }

		public List<Transaction> Transactions { get; set; }

		public Customer()
		{
			CardNumber = Guid.NewGuid();
		}
	}
}
