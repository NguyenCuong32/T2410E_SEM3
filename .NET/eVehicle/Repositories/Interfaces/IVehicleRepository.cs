using eVehicle.Models;

namespace eVehicle.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        List<VehicleInformation> GetVehicleInformation();
    }
}
