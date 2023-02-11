namespace Models;

public class Task
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public TaskPriority Priority { get; set; }
}

public enum TaskPriority 
{
    High,
    Medium,
    Low
}