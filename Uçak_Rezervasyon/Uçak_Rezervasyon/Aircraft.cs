using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uçak_Rezervasyon
{
    internal class Aircraft
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Speed { get; set; }
        public string Classes { get; set; }
        public decimal Price { get; set; }


        public Aircraft(string name, int capacity, int speed, string classes)
            {
                Name = name;
                Capacity = capacity;
                Speed = speed;
                Classes = classes;      
                Price = new Random().Next(1132, 7186);
        }

                public override string ToString()
                {
                    return $"UÇAK MODEL = {Name} | KAPASİTE = {Capacity} | HIZ= {Speed} km/h | SINIF = {Classes} | ÜCRET: {Price}\n";
                }
    }
}
