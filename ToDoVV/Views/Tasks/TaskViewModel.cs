using ToDoVV.Service.Tasks.Response;

namespace ToDoVV.Views.Tasks

{
    public class TaskViewModel
    {
        public List<GetTasksResponse> ?Tasks { get; set; }
        public GetTasksResponse ?Task { get; set; }
    }
}