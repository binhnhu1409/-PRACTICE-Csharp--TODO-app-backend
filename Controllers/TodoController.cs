namespace Controllers;

using Models;
using Services;
using DTOs;

public class TodoController
{
    private readonly ITodoService _service;

    public TodoController(ITodoService service)
    {
        _service = service;
    }

    // POST /api/todos
    public async Task<TodoTask> CreateAsync(TodoRequest request)
    {
        var task = await _service.CreateAsync(request);
        return task;
    }

    //GET /api/todos/{id}
    public async Task<TodoTask> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    //PUT /api/todos/{id}
    public async Task<TodoTask> UpdateAsync(int id, TodoRequest request)
    {
        return await _service.UpdateAsync(id, request);
    }

    // DELETE /api/todos/{id}
    public async Task<TodoTask> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}