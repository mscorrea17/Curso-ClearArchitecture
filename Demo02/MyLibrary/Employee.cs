namespace MyLibrary;

public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int GetInt()
    {
        return 5;
    }

    public virtual decimal CalculateMonthlyPayment()
    {
        return 12000;
    }
}

public class Secretary : Employee
{
    public override decimal CalculateMonthlyPayment() => 15000;
}

public class Manager : Employee
{
    public override decimal CalculateMonthlyPayment()
    {
        return 30000;
    }
}
public class Developer : Employee
    {
    }


