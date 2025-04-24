﻿using MyLibrary;

Secretary Maria = new Secretary();
Maria.Name = "Maria";

Manager Pedro = new Manager();
Pedro.Name = "Pedro";

Developer Miguel = new Developer();

WriteEmployeeInfo(Maria);
WriteEmployeeInfo(Pedro);
WriteEmployeeInfo(Miguel);

void WriteEmployeeInfo(Employee employee)
{
    Console.WriteLine($"Name: {employee.Name}: {employee.CalculateMonthlyPayment()}");
    

}