namespace Repositories;

using Models;
using DTOs;

public interface ITodoRepository
{
    Task<TodoTask> CreateAsync(TodoRequest request, User currentUser);
    Task<TodoTask> UpdateAsync(int id, TodoRequest request, User currentUser);
    Task<bool> DeleteAsync(int id, User currentUser);
    Task<TodoTask> GetAsync(int id);
    Task<IEnumerable<TodoTask>> GetAllAsync(User currentUser);
}