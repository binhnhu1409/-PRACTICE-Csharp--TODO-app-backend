namespace Repositories;

using Models;
using DTOs;

public interface ITodoRepository
{
    Task<TodoTask> Create(TodoRequest request);
    Task<TodoTask> Update(int id, TodoRequest request);
    Task<bool> Delete(int id);
    Task<TodoTask> Get(int id);
    Task<IEnumerable<TodoTask>> GetAll();
}