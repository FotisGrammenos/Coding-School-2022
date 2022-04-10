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

		public string CardNumber { get;}

		public List<Transaction> Transactions { get; set; }

		public Customer()
		{
			CardNumber =$"A{Guid.NewGuid().ToString("N").Substring(0, 7)}";	
		}
	}
}
