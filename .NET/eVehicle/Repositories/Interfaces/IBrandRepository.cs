using eVehicle.Models;

namespace eVehicle.Repositories.Interfaces
{
    public interface IBrandRepository
    {
        /// <summary>
        /// Thêm mới Brand
        /// </summary>
        /// <param name="brand"></param>
        void Add(Brand brand);
        List<Brand> GetAll();
        void Update(Brand brand, int brandId);
        void Delete(Brand brand);

    }
}
