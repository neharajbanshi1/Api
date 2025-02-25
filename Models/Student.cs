namespace StudentApi.Models;

public class Student
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Address { get; set; }
    public required string Gender { get; set; }
    public int Age { get; set; }
}
