using System.ComponentModel.DataAnnotations;

namespace eVehicle.Models
{
    public class VehicleType
    {
        [Key]
        public int TypeId { get; set; }
        public string? TypeName { get; set; }
    }
}
