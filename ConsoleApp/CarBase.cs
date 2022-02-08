using System.Collections.Generic;

namespace ConsoleApp
{
    partial class CarBase
    {
        List<Car> cars = new List<Car>();
        public List<Car> Cars { get => cars; set => cars=value; }

        public static int GeneralFuel { get; set; } = 0;
        public static int GeneralCarQuantity { get; set; } = 0;
        public static double GeneralAverageVolume { get; set; } = 0;

        public CarBase(List<Car> cars)
        {
            this.Cars = cars;
            countGeneralValues();
        }

        public CarBase()
        { }
    }
}
