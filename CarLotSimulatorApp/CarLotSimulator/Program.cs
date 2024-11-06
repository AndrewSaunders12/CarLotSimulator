using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            Car car1 = new Car()
            {
                Make = "Ford",
                Model = "GT",
                Year = 2013,
                IsDriveable = true,
            };
            Console.WriteLine($"{car1.Year} {car1.Make} {car1.Model} is in {car1.IsDriveable} condition. ");
            car1.MakeEngineNoise("thh thh");
            car1.MakeHonkNoise("bop");
            Car car2 = new Car()
            {
                Make = "Bugatti",
                Model = "Divo",
                Year = 2020,
                IsDriveable = true,
            };
            Console.WriteLine($"{car2.Year} {car2.Make} {car2.Model} is in {car2.IsDriveable} condition. ");
            car2.MakeEngineNoise("chop chop");
            car2.MakeHonkNoise("meep meep");
            Car car3 = new Car()
            {
                Make = "Nissian",
                Model = "GTR",
                Year = 2013,
                IsDriveable = true,
            };
            Console.WriteLine($"{car3.Year} {car3.Make} {car3.Model} is in {car3.IsDriveable} condition. ");
            car3.MakeEngineNoise("brum brum");
            car3.MakeHonkNoise("eee");
            
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
