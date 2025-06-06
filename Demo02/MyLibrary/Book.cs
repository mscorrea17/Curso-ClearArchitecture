﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MyLibrary;

namespace MyLibrary;

public class Book : Product
{
    public string Title { get; set; }
    public Book(int id, string name, decimal unitPrice, int unitsInStock, string title) :
        base(id, name, unitPrice, unitsInStock)
    {
        Title = title;
    }
}

public class Book2(int id, string name, decimal unitPrice, int unitsInStock, string title) :
        Product(id, name, unitPrice, unitsInStock)
{
    public string Title => title;
}
