using ToDoVV.Domain.Tasks.Interface;
using ToDoVV.Repository;
using ToDoVV.Service.Tasks.Interface;
using ToDoVV.Service.Tasks.Requests;
using ToDoVV.Service.Tasks.Response;

namespace ToDoVV.Service.Tasks;

public class TasksService : ITasksService
{
    private readonly ITasksRepository _tasksRepository;

    public TasksService(ITasksRepository tasksRepository)
    {
        _tasksRepository = tasksRepository;
    }

    public void CreateTask(CreateTaskRequest request)
    {
        var task = new Domain.Tasks.Tasks
        {
            Title = request.Title,
            Description = request.Description,
            Status = request.Status,
            DueDate = request.DueDate
        };

        _tasksRepository.CreateTask(task);
    }

    public void DeleteTask(int id)
    {
        _tasksRepository.DeleteTask(id);
    }

    public TaskByIdResponse GetTaskById(int id)
    {
        var task = _tasksRepository.GetTaskById(id);

        return new TaskByIdResponse
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            Status = task.Status,
            DueDate = task.DueDate
        };
    }

    public List<GetTasksResponse> GetTasks()
    {
        var tasks = _tasksRepository.GetTasks();

        return new List<GetTasksResponse>(tasks.Select(task => new GetTasksResponse
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            Status = task.Status,
            DueDate = task.DueDate
        }));
    }

    public void UpdateTask(UpdateTaskRequest request, int id)
    {
        var task = new Domain.Tasks.Tasks
        {
            Title = request.Title,
            Description = request.Description,
            Status = request.Status,
            DueDate = request.DueDate
        };

        _tasksRepository.UpdateTask(task, id);
    }
}
