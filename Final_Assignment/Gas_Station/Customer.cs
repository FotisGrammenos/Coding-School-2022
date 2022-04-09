using System;

public class Customer
{
	public string Name { get; set; }

	public string Surname { get; set; }

	public Guid	CardNumber { get; set; }

	public Customer()
	{ 
		CardNumber = Guid.NewGuid();
	}
}
