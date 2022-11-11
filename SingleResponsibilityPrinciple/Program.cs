#region SRP_Before

//class Employee
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public DateOnly DateOfBirth { get; set; }



//    public void PrintTimeSheetReport()
//    {
//        // do something...

//        Console.WriteLine($"{Name} {Surname} {DateOfBirth.ToShortDateString()}");

//    }



//}

#endregion



#region SRP_After
class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateOnly DateOfBirth { get; set; }
}

class TimeSheetReport
{
    // ...

    public void Print(Employee e)
    {
        // ... do something
        Console.WriteLine($"{e.Name} {e.Surname} {e.DateOfBirth.ToShortDateString()}");
    }
}


#endregion