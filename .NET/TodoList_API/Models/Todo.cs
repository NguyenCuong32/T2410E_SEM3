using System.ComponentModel.DataAnnotations;

namespace TodoList_API.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int ProriotyId { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
    }
}
