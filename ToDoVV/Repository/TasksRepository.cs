using ToDoVV.Domain.Tasks;
using ToDoVV.Domain.Tasks.Interface;

namespace ToDoVV.Repository;

public class TasksRepository : ITasksRepository
{
    private static IList<Tasks> _database = new List<Tasks>();
    public Tasks CreateTask(Tasks request)
    {
        var count = _database.Count;
        request.Id = count++;

        _database.Add(request);

        return request;
    }

    public void DeleteTask(int id)
    {
        _database.Remove(_database.FirstOrDefault(x => x.Id == id)!);
    }

    public Tasks GetTaskById(int id)
    {
        var task = _database.FirstOrDefault(x =>x.Id == id);

        return task!;
    }

    public List<Tasks> GetTasks()
    {
        var tasks = _database.ToList();

        return tasks;
    }

    public Tasks UpdateTask(Tasks request, int id)
    {
        var task = _database.FirstOrDefault(x => x.Id == id);
        if (task != null)
        {
            task.Title = request.Title;
            task.Description = request.Description;
            task.Status = request.Status;
            task.DueDate = request.DueDate;
        }

        return task!;
    }
}
