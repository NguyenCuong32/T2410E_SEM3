using System.ComponentModel.DataAnnotations;

namespace TodoList_API.Models
{
    public class Prorioty
    {
        [Key]
        public int Id { get; set; }
        public string ProriotyName { get; set; }
    }
}
