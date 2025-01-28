using ToDoVV.Service.Tasks.Requests;
using ToDoVV.Service.Tasks.Response;

namespace ToDoVV.Service.Tasks.Interface;

public interface ITasksService
{
    public List<GetTasksResponse> GetTasks();
    public TaskByIdResponse GetTaskById(int id);
    public void CreateTask(CreateTaskRequest request);
    public void UpdateTask(UpdateTaskRequest request, int id);
    public void DeleteTask(int id);
}
