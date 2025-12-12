namespace eVehicle.Repositories.Interfaces
{
    public interface IRepository
    {
        /// <summary>
        /// Thêm mới dữ liệu
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Add<T>(T objects);
        /// <summary>
        /// Lấy dữ liệu lên
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        List<T> Get<T>();
        /// <summary>
        /// Cập nhật dữ liệu
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Update<T>();
        /// <summary>
        /// Xóa dữ liệu
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Delete<T>();
    }
}
