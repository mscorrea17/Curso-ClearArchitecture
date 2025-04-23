namespace MyLibrary;

public class Product
{
    //  Propiedades

    public int Id { get; }

    public string Name { get; };

    public decimal UnitPrice { get;  };

    public int UnitsInStock { get;  };

    //  Constructor

    public Product(int id, string name, decimal unitPrice, int unitsInStock)
    {
        Id = id;
        Name = name;
        UnitPrice = unitPrice;
        UnitsInStock = unitsInStock;
    }
}

