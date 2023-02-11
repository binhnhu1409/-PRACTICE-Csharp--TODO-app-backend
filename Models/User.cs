namespace Models;

public class User 
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? Password { get; set; }
    public List<TodoTask>? Tasks { get; set; }

    public User (int id, string firstName, string lastName, string email)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}            