using eVehicle.Models;
using eVehicle.Repositories;
using eVehicle.Repositories.Interfaces;

namespace eVehicle.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            this.brandRepository = brandRepository;
        }

        public void AddBrand(Brand brand)
        {
            this.brandRepository.Add(brand);
        }

        public List<Brand> GetBrands()
        {
            return this.brandRepository.GetAll();
        }
    }
}
