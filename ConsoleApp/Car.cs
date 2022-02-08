using System;
namespace ConsoleApp
{
    class Car
    {
        CarEngine engine;
        public CarEngine Engine { get => engine; set => engine=value; }
        private string carBaseName;
        private int carQuantity;
        private double avarageVolume;
        public string CarBaseName { get { return carBaseName; } set { carBaseName = value; } }
        public int CarQuantity { get { return carQuantity; } set { carQuantity = value; } }
        public double AvarageVolume { get => Engine.Fuel/CarQuantity; set => avarageVolume = value; }

        public Car(string carBaseName, int fuel, int carQuantity)
        {
            this.CarBaseName = carBaseName;
            this.CarQuantity = carQuantity;
            this.engine = new CarEngine() 
            {
                Fuel = fuel
            };
        }
    }
}




