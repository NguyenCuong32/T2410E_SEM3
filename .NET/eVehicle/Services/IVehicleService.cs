using eVehicle.Models;

namespace eVehicle.Services
{
    public interface IVehicleService
    {
        List<VehicleInformation> GetVehicleInformation();
    }
}
