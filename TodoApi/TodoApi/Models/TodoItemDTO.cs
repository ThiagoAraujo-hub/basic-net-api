using TodoApi.Entities;

namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsComplete { get; set; } = false;

        public TodoItemDTO() { }

        public TodoItemDTO(TodoItem todoItem)
        {
            Id = todoItem.Id;
            Name = todoItem.Name;
            IsComplete = todoItem.IsComplete;
        }
    }
}
