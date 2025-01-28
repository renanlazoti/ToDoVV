using Microsoft.AspNetCore.Mvc;
using ToDoVV.Service.Tasks.Interface;
using ToDoVV.Service.Tasks.Requests;
using ToDoVV.Service.Tasks.Response;
using ToDoVV.Views.Tasks;

namespace ToDoVV.Controllers;

public class TasksController : Controller
{
    private readonly ITasksService _tasksService;

    public TasksController(ITasksService tasksService)
    {
        _tasksService = tasksService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var tasks = _tasksService.GetTasks();

        var model = new TaskViewModel
        {
            Tasks = tasks,
            Task = new GetTasksResponse()
        };

        return View(model);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateTaskRequest task)
    {
        if (ModelState.IsValid)
        {
            _tasksService.CreateTask(task);
            return RedirectToAction(nameof(Index));
        }
        return View(task);
    }

    [HttpPost]
    public IActionResult Update(UpdateTaskRequest task)
    {
        if (ModelState.IsValid)
        {
            _tasksService.UpdateTask(task, task.Id);
            return RedirectToAction(nameof(Index));
        }
        return View(task);
    }


    [HttpGet]
    public IActionResult Delete(int id)
    {
        _tasksService.DeleteTask(id);
        return RedirectToAction(nameof(Index));
    }
}