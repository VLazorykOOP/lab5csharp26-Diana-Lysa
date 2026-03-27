using System;

namespace Lab5CSharp
{
    public class TransportVehicle
    {
        public string Name { get; set; }

        public TransportVehicle()
        {
            Name = "Невідомий транспорт";
            Console.WriteLine(" Виклик конструктора TransportVehicle (default)");
        }

        public TransportVehicle(string name)
        {
            Name = name;
            Console.WriteLine($"Виклик конструктора TransportVehicle (параметри: {name})");
        }

        public TransportVehicle(TransportVehicle other)
        {
            Name = other.Name;
            Console.WriteLine(" Виклик TransportVehicle (копіювання)");
        }

        ~TransportVehicle()
        {
            Console.WriteLine(" Деструктор TransportVehicle");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Транспорт: {Name}");
        }
    }

    public class Car : TransportVehicle
    {
        public string FuelType { get; set; }

        public Car() : base()
        {
            FuelType = "Бензин";
            Console.WriteLine(" Виклик конструктора Car (default)");
        }

        public Car(string name, string fuelType) : base(name)
        {
            FuelType = fuelType;
            Console.WriteLine($" Виклик конструктора Car (паливо: {fuelType})");
        }

        public Car(Car other) : base(other)
        {
            FuelType = other.FuelType;
            Console.WriteLine("  Виклик Car (копіювання)");
        }

        ~Car()
        {
            Console.WriteLine(" Деструктор Car");
        }

        public override void Show()
        {
            Console.WriteLine($"Автомобіль: {Name}, Тип палива: {FuelType}");
        }
    }

    public class Train : TransportVehicle
    {
        public int Carriages { get; set; }

        public Train() : base()
        {
            Carriages = 0;
            Console.WriteLine("Виклик конструктора Train (default)");
        }

        public Train(string name, int carriages) : base(name)
        {
            Carriages = carriages;
            Console.WriteLine($" Виклик конструктора Train (параметри: {carriages} вагонів)");
        }

        public Train(Train other) : base(other)
        {
            Carriages = other.Carriages;
            Console.WriteLine("Виклик Train (копіювання)");
        }

        ~Train()
        {
            Console.WriteLine("Деструктор Train");
        }

        public override void Show()
        {
            Console.WriteLine($"Поїзд: {Name}, Вагонів: {Carriages}");
        }
    }

    public class Express : Train
    {
        public string Route { get; set; }

        public Express() : base()
        {
            Route = "Стандарт";
            Console.WriteLine(" Виклик конструктора Express (default)");
        }

        public Express(string name, int carriages, string route) : base(name, carriages)
        {
            Route = route;
            Console.WriteLine($" Виклик конструктора Express (маршрут: {route})");
        }

        public Express(Express other) : base(other)
        {
            Route = other.Route;
            Console.WriteLine(" Виклик Express (копіювання)");
        }

        ~Express()
        {
            Console.WriteLine(" Деструктор Express");
        }

        public override void Show()
        {
            Console.WriteLine($"Експрес: {Name}, Вагонів: {Carriages}, Маршрут: {Route}");
        }
    }
}
