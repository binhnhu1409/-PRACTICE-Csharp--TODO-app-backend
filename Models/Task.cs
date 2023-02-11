namespace Models;

public class Task
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public TaskPriority Priority { get; set; }
    public User User { get; set; }

    public Task (int id, string name, User user) 
    {
        ID = id;
        Name = name;
        Priority = TaskPriority.Low;
        User = user;
        DueDate = DateTime.Now.AddDays(2);
    }
}

public enum TaskPriority 
{
    High,
    Medium,
    Low
}