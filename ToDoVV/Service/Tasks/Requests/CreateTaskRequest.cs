using System.ComponentModel.DataAnnotations;

namespace ToDoVV.Service.Tasks.Requests;

public class CreateTaskRequest
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public string? Status { get; set; }
    [Required]
    public DateTime DueDate { get; set; }
}
