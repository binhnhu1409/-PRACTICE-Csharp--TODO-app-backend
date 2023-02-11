namespace Models;

public class TodoTask
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public TodoTaskPriority Priority { get; set; }
    public User User { get; set; }

    public TodoTask (int id, string name, User user) 
    {
        ID = id;
        Name = name;
        Priority = TodoTaskPriority.Low;
        User = user;
        DueDate = DateTime.Now.AddDays(2);
    }
}

public enum TodoTaskPriority 
{
    High,
    Medium,
    Low
}