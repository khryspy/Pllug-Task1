using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sphere_ns;
using Parallelepiped_ns;
using Cylinder_ns;

namespace Round_Door
{
    class RoundDoor
    {
        double diameterRoundDoor;

        public void setRoundDoor()
        {
             try
            {
                Console.WriteLine("Введіть діаметр ваших круглих дверей:");

                diameterRoundDoor = Convert.ToDouble(Console.ReadLine());

                if (diameterRoundDoor <= 0) { 
                    Console.WriteLine("Діаметр дверей не може бути меншим або рівним нулю!");
                    setRoundDoor();
                }
            }
            catch (FormatException) {
                Console.WriteLine("Діаметр дверей-це додатнє число!Введіть,будь ласка,правильні дані!");
                setRoundDoor();
            }
        }

        public void ParallelepipedIntoRoundDoor(Parallelepiped parallelepiped)
        {
            double diagonalParallelepiped;

            diagonalParallelepiped = Math.Sqrt(Math.Pow(parallelepiped.HeightParallelepiped, 2) + Math.Pow(parallelepiped.LengthParallelepiped, 2)
                + Math.Pow(parallelepiped.WidthParallelepiped, 2));

            if (diagonalParallelepiped < diameterRoundDoor)
            {
                 Console.WriteLine("Ура!Ваш холодильник  проходить через круглі двері!");
            }
            else
                Console.WriteLine("Ваш холодильник не проходить через круглі двері!");
            }

        

        public void SphereIntoRoundDoor(Sphere sphere)
        {
            if (diameterRoundDoor > sphere.DiameterSphere)
            {
                Console.WriteLine("Ура!Ваш холодильник у формі сфери проходить через круглі двері!");
            }
            else
                Console.WriteLine("Ваш холодильник у формі сфери не проходить через круглі двері!");

        }

        public void CylinderIntoRoundDoor(Cylinder cylinder)
        {
            if (diameterRoundDoor > cylinder.DiameterCylinder)
            {
                 Console.WriteLine("Ура!Ваш холодильник у формі циліндра проходить через круглі двері!");
            }
            else
                Console.WriteLine("Ваш холодильник у формі циліндра не проходить через круглі двері!");

            }
        }
    }
        
        
   

