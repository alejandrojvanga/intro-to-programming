using System.ComponentModel.DataAnnotations;

namespace Bff.Api.Todos;

public record CreateTodoRequest
{
    [Required, MinLength(3), MaxLength(124)]
    public string Description { get; set; } = string.Empty;
    public DateTimeOffset? DueDate { get; set; }
    public TodoPriority? Priority { get; set; }
}

public enum TodoPriority { Low, High };

public record CreateTodoResponse
{
    public Guid Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTimeOffset? DueDate { get; set; }
    public TodoPriority? Priority { get; set; }
}