namespace Repositories;

using Models;
using DTOs;

public interface ITodoRepository
{
    Task<TodoTask> CreateAsync(TodoRequest request);
    Task<TodoTask> UpdateAsync(int id, TodoRequest request);
    Task<bool> DeleteAsync(int id);
    Task<TodoTask> GetAsync(int id);
    Task<IEnumerable<TodoTask>> GetAllAsync();
}