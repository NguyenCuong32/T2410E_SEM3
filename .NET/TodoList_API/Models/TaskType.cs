using System.ComponentModel.DataAnnotations;

namespace TodoList_API.Models
{
    public class TaskType
    {
        [Key]
        public int Id { get; set; }
        public string TaskName { get; set; }
    }
}
