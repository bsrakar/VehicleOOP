using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOPFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Toyota();
            string result = toyota.Move();
            Console.WriteLine(result);
            toyota.CarTires = new WinterTires((float)32, 35, (float)50.8);
            result = toyota.CarTires.GetTiresInfo();
            Console.WriteLine(result);

            Car honda = new Honda();
            result = honda.Move();
            Console.WriteLine(result);
            result = honda.CarTires.GetTiresInfo();
            Console.WriteLine(result);

            IMotorcycle hondaMoto= new Honda();
            result = hondaMoto.Move();
            Console.WriteLine(result);

            Motorcycle ktm = new KTM();
            result = ktm.Move();
            Console.WriteLine(result);
            
            Console.ReadLine();
        }
    }
}
