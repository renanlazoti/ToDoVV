namespace ToDoVV.Domain.Tasks.Interface;

public interface ITasksRepository
{
    Tasks CreateTask(Tasks request);
    List<Tasks> GetTasks();
    Tasks GetTaskById(int id);
    Tasks UpdateTask(Tasks request, int id);
    void DeleteTask(int id);
}
