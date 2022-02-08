using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        private static CarBase carBase;
        private static int baseCount;

        static void indexInput(CarBase carBase)
        {
            int index;
            bool correct = false;
            try
            {
                do
                {
                    Console.Write("Введите номер автобазы для просмотра данных(<" + baseCount + "): ");
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (index > 0 && index <= baseCount)
                    {
                        index--;
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Введите корректные данные!");
                        Console.WriteLine();
                    }
                } while (!correct);
                CarBase.tableOutput();
                carBase.carBaseOutput(index);
                Console.WriteLine();
            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Введите корректные данные!");
                Console.WriteLine();
                indexInput(carBase);
            }
        }
        static void menu(CarBase carBase)
        {
            int number;
            try
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("Вывести все данные об автобазах: 1");
                Console.WriteLine("Вывести данные об одной из автобаз: 2");
                Console.WriteLine("Выйти: 3");
                Console.WriteLine();

                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch(number)
                {
                    case 1:
                        CarBase.tableOutput();
                        carBase.allOutput();
                        CarBase.outputGeneralAvarageVolume();
                        Console.WriteLine();
                        menu(carBase);
                        break;
                    case 2:
                        indexInput(carBase);
                        menu(carBase);
                        break;
                    case 3:
                        Console.WriteLine("Вы решили не продолжать!");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Введите корректные данные!");
                        Console.WriteLine();
                        menu(carBase);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Введите корректные данные!");
                Console.WriteLine();
                menu(carBase);
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            String carBaseName = string.Empty;
            int letter, fuel, carQuantity;
            baseCount = random.Next(5, 20);
            carBase = new CarBase();

            var arr = new List<Car>();
            for (int i = 0; i < baseCount; i++)
            {
                fuel = random.Next(100, 10000);
                carQuantity = random.Next(10, 1000);
                for (int j = 0; j < 5; j++)
                {
                    letter = random.Next(0, letters.Length - 1);
                    carBaseName += letters[letter];
                }
                Car car = new Car(carBaseName, fuel, carQuantity);
                arr.Add(car);
                carBaseName = string.Empty;
            }
            carBase = new CarBase(arr);

            menu(carBase);
            Console.ReadKey();
        }
    }
}
