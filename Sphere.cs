using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphere_ns
{
    class Sphere
    {
        double diameterSphere;

        public double DiameterSphere
        {
            get { return diameterSphere; }
            set { diameterSphere = value; }
        }

        public void setSphere()
        {
            try
            {
                Console.WriteLine("Введіть діаметр вашого холодильника-сфери:");

                diameterSphere = Convert.ToDouble(Console.ReadLine());

                if (diameterSphere <= 0) { 
                    Console.WriteLine("Діаметр сфери не може бути меншим або рівним нулю!");
                    setSphere();
                }
            }
            catch (FormatException) {
                Console.WriteLine("Діаметр сфери-це додатнє число!Введіть,будь ласка,правильні дані!");
                setSphere();
            }
        }
    }
}
