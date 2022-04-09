using System;

public class Item : BaseEntitie
{
    public Guid Code { get; set; }

    public string Description { get; set; }

    public ItemType Type { get; set; }

    public decimal Price { get; set; }

    public decimal Cost { get; set; }

    public Item()
	{
        Code = Guid.NewGuid();
	}
}
