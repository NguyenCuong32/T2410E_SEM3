using eVehicle.Models;
using eVehicle.Repositories.Interfaces;

namespace eVehicle.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly eVehicleDBContext eVehicleDBContext;

        public BrandRepository(eVehicleDBContext eVehicleDBContext)
        {
            this.eVehicleDBContext = eVehicleDBContext;
        }

        public void Add(Brand brand)
        {
            this.eVehicleDBContext.Add(brand);
            this.eVehicleDBContext.SaveChanges();
        }

        public void Delete(Brand brand)
        {
           this.eVehicleDBContext.Brand.Remove(brand);
        }

        public List<Brand> GetAll()
        {
          return this.eVehicleDBContext.Brand.ToList();
        }

        public void Update(Brand brand, int brandId)
        {
            throw new NotImplementedException();
        }
    }
}
