using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        { Console.WriteLine(" Hello World"); }
            public class Car
        {
            // Attributes
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double Price { get; set; }
            public string Color { get; set; }
            public int Mileage { get; set; }
            public bool IsElectric { get; set; }
            public bool IsFourWheelDrive { get; set; }

            // Constructors
            public Car()
            {
                // Default constructor
            }

            public Car(string make, string model, int year, double price, string color, int mileage, bool isElectric, bool isFourWheelDrive)
            {
                Make = make;
                Model = model;
                Year = year;
                Price = price;
                Color = color;
                Mileage = mileage;
                IsElectric = isElectric;
                IsFourWheelDrive = isFourWheelDrive;
            }

            public Car(string make, string model, int year, double price)
            {
                Make = make;
                Model = model;
                Year = year;
                Price = price;
            }

            public Car(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
            }

            public Car(string make)
            {
                Make = make;
            }

            // Methods
            public void Start()
            {
                Console.WriteLine($"The {Make} {Model} is starting.");
            }

            public void Accelerate()
            {
                Console.WriteLine($"The {Make} {Model} is accelerating.");
            }

            public void Brake()
            {
                Console.WriteLine($"The {Make} {Model} is braking.");
            }

            public void TurnLeft()
            {
                Console.WriteLine($"The {Make} {Model} is turning left.");
            }

            public void TurnRight()
            {
                Console.WriteLine($"The {Make} {Model} is turning right.");
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\nPrice: {Price}\nColor: {Color}\nMileage: {Mileage}\nIsElectric: {IsElectric}\nIsFourWheelDrive: {IsFourWheelDrive}");
            }
            }
    }
    
}
