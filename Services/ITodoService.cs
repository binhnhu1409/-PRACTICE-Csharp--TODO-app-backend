namespace Services;

using Models;
using DTOs;

public interface ITodoService
{
    Task<TodoTask> CreateAsync(TodoRequest request);
    Task<TodoTask> UpdateAsync(int id, TodoRequest request);
    Task<bool> DeleteAsync(int id);
    Task<TodoTask> GetAsync(int id);
    Task<IEnumerable<TodoTask>> GetAllAsync();
    Task<IEnumerable<TodoTask>> GetTopImportantAsync(int count);
    Task<IEnumerable<TodoTask>> GetTopDuedTasksAsync(int count);
    
}