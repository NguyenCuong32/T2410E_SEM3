using eVehicle.Models;

namespace eVehicle.Services
{
    public interface IBrandService
    {
        void AddBrand(Brand brand);
        List<Brand> GetBrands();
    }
}
