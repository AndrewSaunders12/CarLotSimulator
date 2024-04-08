using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var andrewsCar = new Car();
            andrewsCar.Year = 2013;
            andrewsCar.Make = "Ford";
            andrewsCar.Model = "GT";
            andrewsCar.EngineNoise = "brrpp";
            andrewsCar.HonkNoise = "meepmeep";
            andrewsCar.IsDrivable = true;

            var batMansCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Plaid",
                EngineNoise = "zzz",
                HonkNoise = "Thud",
                IsDrivable = false,
            };

            var superMansCar = new Car(2019, "Ferrari", "SuperFast", "GRRRR", "BowBow", true);

            andrewsCar.MakeMake();
            andrewsCar.MakeModel();
            batMansCar.MakeMake();
            batMansCar.MakeModel();
            superMansCar.MakeMake();
            superMansCar.MakeModel();






            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

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
