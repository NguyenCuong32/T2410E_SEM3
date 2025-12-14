using System.ComponentModel.DataAnnotations;

namespace eVehicle.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        public string? ColorName { get; set; }
        public string? ColorHex { get; set; }
    }
}
