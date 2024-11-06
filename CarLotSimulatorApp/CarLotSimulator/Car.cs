using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
     public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine($"{EngineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"{HonkNoise}");
        }
        






    }
}
