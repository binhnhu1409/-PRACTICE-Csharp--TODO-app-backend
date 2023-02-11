namespace Models;

using DTOs;

public class TodoTask
{
    public int? ID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
    public TodoTaskPriority? Priority { get; set; }
    public User? User { get; set; }

    public TodoTask()
    {
        
    }
    public TodoTask (int id, string name, User user) 
    {
        ID = id;
        Name = name;
        Priority = TodoTaskPriority.Low;
        User = user;
        DueDate = DateTime.Now.AddDays(2);
    }

    public static TodoTask FromTaskRequest(TodoRequest request)
    {
        var task = new TodoTask
        {
            Name = request.Name,
            Description = request.Description,
        };

        if (request.DueDate is not null)
        {
            task.DueDate = request.DueDate;
        }
        if (request.Priority is not null)
        {
            task.Priority = request.Priority;
        }

        return task;
    }
}

public enum TodoTaskPriority 
{
    High,
    Medium,
    Low
}