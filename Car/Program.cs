using System;

namespace Car
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string registration;
            string color;
            int odometer;
            int fuel;

            public Car(string _mark, string _model, string _registration, string _color)
            {
                Mark = _mark;
                Model = _model;
                Registration = _registration;
                Color = _color;
                odometer = 0;
                fuel = 60;
            }
            public void Drive()
            {
                odometer += 100;
                fuel -= 5;
            }
            public string Registration
            {
                get { return registration; }
                set
                {
                    if (value.Length >= 6)
                    {
                        registration = value;
                    }
                    else
                    {
                        registration = "undefined";
                    }
                }
            }
            public string Model
            {
                get { return model; }
                set
                {
                    model = value;
                }
            }
            public string Mark
            {
                get { return mark; }
                set
                {
                    mark = value;
                }
            }
            public string Color
            {
                get { return color; }
                set
                {
                    color = value;
                }
            }
            public int Fuel
            {
                get { return fuel; }
                set
                {
                    fuel = value;
                }
            }
            public int Odometer
            {
                get { return odometer; }
                set
                {
                    odometer = value;
                }
            }
            public void DataDisplay()
            {
                Console.WriteLine("mark: " + Mark);
                Console.WriteLine("model: " + Model);
                Console.WriteLine("reg: " + Registration);
                Console.WriteLine("color: " + Color);
                Console.WriteLine("fuel: " + fuel);
                Console.WriteLine("odometer: " + odometer);
            }
        }
        
            
        static void Main(string[] args)
        {
            Car newCar = new Car("bmw", "e46 compact", "777THC", "beige");

            while (newCar.Fuel > 0)
            {
                newCar.Drive();
                Console.WriteLine("fuel: " + newCar.Fuel);
                Console.WriteLine("odometer: " + newCar.Odometer);
            }
            newCar.DataDisplay();
        }
    }
}
