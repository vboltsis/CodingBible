namespace DotNet6.Models;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public int Cash { get; set; }
    public int CashIfWonLottery { get; set; }
    public DateTime Birthday { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public TimeOnly TimeOfBirth { get; set; }
}
