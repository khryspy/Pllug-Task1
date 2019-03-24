using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder_ns
{
    class Cylinder
    {
        double heightCylinder;

        double diameterCylinder;

        public double HeightCylinder
        {
            get { return heightCylinder; }
            set { heightCylinder = value; }
        }

        public double DiameterCylinder
        {
            get { return diameterCylinder; }
            set { diameterCylinder = value; }
        }

        public void setHeightCylinder()
        {
            try
            {
                Console.WriteLine("Введіть висоту вашого холодильника-циліндра:");
                heightCylinder = Convert.ToDouble(Console.ReadLine());

                if (heightCylinder <= 0)
                {
                    Console.WriteLine("Висота холодильника-циліндра не може бути меншою або рівною нулю!");
                    setHeightCylinder();
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Висота холодильника-це додатнє число!Введіть,будь ласка,правильні дані!");
                setHeightCylinder();

            }
        }

        public void setDiameterCylinder()
        {
            try
            {
                Console.WriteLine("Введіть діаметр вашого холодильника-циліндра:");

                diameterCylinder = Convert.ToDouble(Console.ReadLine());

                if (diameterCylinder <= 0)
                {
                    Console.WriteLine("Діаметр холодильника-циліндра не може бути меншим або рівним нулю!");
                    setDiameterCylinder();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Діаметр холодильника-циліндра-це додатнє число!Введіть,будь ласка,правильні дані!");
                setDiameterCylinder();
            }

        }

        public void setCylinder()
        {
            setHeightCylinder();
            setDiameterCylinder();
        }
            
            
            
            
            
            
            
            
            
            
         

  
    }
}
