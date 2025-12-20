using eVehicle.Models;
using eVehicle.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eVehicle.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly eVehicleDBContext eVehicleDBContext;

        public VehicleRepository(eVehicleDBContext eVehicleDBContext)
        {
            this.eVehicleDBContext = eVehicleDBContext;
        }
        public List<VehicleInformation> GetVehicleInformation()
        {
          return  this.eVehicleDBContext.Set<VehicleInformation>().FromSqlRaw("EXEC GET_ALL_VEHICLE").ToList();
        }
    }
}
