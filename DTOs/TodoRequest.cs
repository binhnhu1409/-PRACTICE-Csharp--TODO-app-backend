namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class TodoRequest
{
    [Required]
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; } = DateTime.Now.AddDays(2);
    public TodoTaskPriority? Priority { get; set; } = TodoTaskPriority.Low;
}