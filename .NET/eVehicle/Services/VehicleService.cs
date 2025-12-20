using eVehicle.Models;
using eVehicle.Repositories.Interfaces;

namespace eVehicle.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }
        public List<VehicleInformation> GetVehicleInformation()
        {
           return this.vehicleRepository.GetVehicleInformation();
        }
    }
}
