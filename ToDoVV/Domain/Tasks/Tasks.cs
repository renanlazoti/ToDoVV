﻿namespace ToDoVV.Domain.Tasks;

public class Tasks
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public DateTime DueDate { get; set; }
}

