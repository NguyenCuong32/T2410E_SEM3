using eVehicle.Models;
using eVehicle.Repositories;

namespace eVehicle.Services
{
    public class BrandService : IBrandService
    {
        private readonly BrandRepository brandRepository;

        public BrandService(BrandRepository brandRepository)
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
