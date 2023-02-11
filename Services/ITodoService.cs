namespace Services;

using Models;
using DTOs;

public interface ITodoService
{
    Task<TodoTask> CreateAsync(TodoRequest request, User currentUser);
    Task<TodoTask> UpdateAsync(int id, TodoRequest request, User currentUser);
    Task<bool> DeleteAsync(int id, User currentUser);
    Task<TodoTask> GetAsync(int id);

    Task<IEnumerable<TodoTask>> GetAllAsync(User currentUser);
    Task<IEnumerable<TodoTask>> GetTopImportantAsync(int count, User currentUser);
    Task<IEnumerable<TodoTask>> GetTopDuedTasksAsync(int count, User currentUser);
    
}