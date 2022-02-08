using System;

namespace ConsoleApp
{
    partial class CarBase
    {
        private void countGeneralValues()
        { 
            int summ = 0;
            int qnty = 0;
            double vol = 0;
            foreach (Car car in this.cars) 
            {
                qnty += car.CarQuantity;
                summ += car.Engine.Fuel;
                vol += car.AvarageVolume;
            }

            GeneralFuel = summ;
            GeneralCarQuantity = qnty;
            GeneralAverageVolume = vol;
        }

        public void AddCar(int fuel, string carBaseName, int carQuantity)
        {
            Cars.Add(new Car(carBaseName, fuel, carQuantity));
        }

        public static void outputGeneralAvarageVolume()
        { 
            /**/
            Console.WriteLine("|               |               |               |               |");
            Console.WriteLine("|\t" + "\t|\t" + GeneralFuel + "\t|\t " + GeneralCarQuantity + " \t|\t " + GeneralAverageVolume + "\t|");
            Console.WriteLine("|               |               |               |               |");
            Console.WriteLine("-----------------------------------------------------------------");
        }
        public static void tableOutput()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("|               |               |               |               |");
            Console.WriteLine("|   Название    |  Топливо(кг)  |  Кол-во машин | Средняя растр.|");
            Console.WriteLine("|   автобазы    |               |               |    топлива    |");
            Console.WriteLine("|               |               |               |               |");
            Console.WriteLine("----------------------------------------------------------------");
        }

        public void allOutput()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine("|               |               |               |               |");
                Console.WriteLine("|\t" + car.CarBaseName + "\t|\t" + car.Engine.Fuel + "\t|\t" + car.CarQuantity + "\t|\t" + car.AvarageVolume + "\t|");
                Console.WriteLine("|               |               |               |               |");
                Console.WriteLine("-----------------------------------------------------------------");
            }
          
        }

        public void carBaseOutput(int index)
        {
            for (int i = 0; i < this.Cars.Count; i++)
            {
                if (i == index) 
                {
                    Car c = this.Cars[index];
                    Console.WriteLine("|               |               |               |               |");
                    Console.WriteLine("|\t" + c.CarBaseName + "\t|\t" + c.Engine.Fuel + "\t|\t" + c.CarQuantity + "\t|\t" + c.AvarageVolume + "\t|");
                    Console.WriteLine("|               |               |               |               |");
                    Console.WriteLine("-----------------------------------------------------------------");
                }
            }
            
        }
    }
}
