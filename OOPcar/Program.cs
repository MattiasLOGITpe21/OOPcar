using System;

namespace OOPcar
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
            
            public Car(string _mark,string _model,string _registration, string _color)
            {
                mark = _mark;
                model = _model;
                registration = _registration;
                color = _color;
                odometer = 0;
                fuel = 60;
                Console.WriteLine($"The {color} {mark} {model} has been created");
            }

        }
        
        static void Main(string[] args)
        {
            Car myCar = new Car("Mazda", "RX-7", "848Y", "Black");
        }
    }
}
