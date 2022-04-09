using System;

public class BaseEntitie
{
    public Guid ID { get; set; }

    public BaseEntitie()
	{
        ID = Guid.NewGuid();
	}
}
