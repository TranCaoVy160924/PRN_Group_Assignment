using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository: ICarRepository
    {
        public Car GetCarByID(int carId) 
            => CarDBContext.Instance.GetCarByID(carId);
        public IEnumerable<Car> GetCars()
            => CarDBContext.Instance.GetCarList();
        public void InsertCar(Car car)
            => CarDBContext.Instance.AddNew(car);
        public void DeleteCar(int carID) 
            => CarDBContext.Instance.Remove(carID);
        public void UpdateCar(Car car) 
            => CarDBContext.Instance.Update(car);
    }
}
