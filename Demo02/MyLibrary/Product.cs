﻿namespace MyLibrary;

public class Product(int id, string name, decimal unitPrice, int unitsInStock)
{
    //  Propiedades

    public int Id => id;
    public string Name => name;
    public decimal UnitPrice => unitPrice;
    public int UnitsInStock => unitsInStock;
    public bool Discontinued { get; private set; }
    public void setDiscontinued() =>
        Discontinued = true;
    public bool GetStatus() =>
         Discontinued;
}

//public class Product2(int id, string name, decimal unitPrice, int unitsInStock,
//    bool disconetinued)
//    : Product(id,name, default, default)
//{
//    public bool Discontinued { get; set; } = disconetinued;
//}