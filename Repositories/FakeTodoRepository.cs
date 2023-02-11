namespace Repositories;

using Models;
using DTOs;
public class FakeTodoRepository : ITodoRepository
{
    static List<TodoTask> _tasks = new List<TodoTask>();
    static int _taskId = 0;
    public async Task<TodoTask> CreateAsync(TodoRequest request, User currentUser)
    {
        var task = TodoTask.FromTaskRequest(request);
        task.ID = ++_taskId;
        _tasks.Add(task);
        return task;
    }
    public async Task<TodoTask> UpdateAsync(int id, TodoRequest request, User currentUser)
    {
        var task = await GetAsync(id);
        if (task.User.ID != currentUser.ID)
        {
            throw new ArgumentException("You have no permission");
        }

        throw new NotImplementedException();
    }
    public async Task<bool> DeleteAsync(int id, User currentUser)
    {
        throw new NotImplementedException();
    }
    public async Task<TodoTask> GetAsync(int id) 
    {
        throw new NotImplementedException();
    }
    public async Task<IEnumerable<TodoTask>> GetAllAsync(User currentUser) 
    {
        throw new NotImplementedException();
    }
}