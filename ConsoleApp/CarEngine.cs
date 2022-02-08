namespace ConsoleApp
{
    public class CarEngine
    {
        private int fuel;
        public int Fuel { get { return fuel; } set { fuel = value; } }
        public CarEngine() { }
        public CarEngine(int fuel)
        {
            this.Fuel = fuel;
        }
    }
}


