using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sphere_ns;
using Parallelepiped_ns;
using Cylinder_ns;

namespace Rectangular_Door
{
    class RectangularDoor
    {
        double widthRectangularDoor;

        double heightRectangularDoor;

        public void setWidthRectangularDoor(){
             try
            {
                Console.WriteLine("Введіть ширину ваших прямокутних дверей:");

                widthRectangularDoor = Convert.ToDouble(Console.ReadLine());

                if (widthRectangularDoor <= 0) { 
                    Console.WriteLine("Ширина ваших дверей не може бути меншою або рівною нулю!");
                    setWidthRectangularDoor();
                }
            }
            catch (FormatException) {
                Console.WriteLine("Ширина дверей-це додатнє число!Введіть,будь ласка,правильні дані!");
                setWidthRectangularDoor();
            }
        }

        public void setHeightRectangularDoor(){
             try
            {
                Console.WriteLine("Введіть висоту ваших прямокутних дверей:");

                heightRectangularDoor = Convert.ToDouble(Console.ReadLine());

                if (heightRectangularDoor <= 0) { 
                    Console.WriteLine("Висота ваших дверей не може бути меншою або рівною нулю!");
                    setHeightRectangularDoor();
                }
            }
            catch (FormatException) {
                Console.WriteLine("Висота дверей-це додатнє число!Введіть,будь ласка,правильні дані!");
                setHeightRectangularDoor();
            }
        }

        public void setRectangularDoor()
        {
            setWidthRectangularDoor();
            setHeightRectangularDoor();
        }

        public void SphereIntoRectangularDoor(Sphere sphere)
        {
            if (sphere.DiameterSphere < heightRectangularDoor && sphere.DiameterSphere < widthRectangularDoor)
            {
                Console.WriteLine("Ура!Ви можете пронести ваш холодильник-сферу  через стандартні двері!");
            }

            else
                Console.WriteLine("Ваш холодильник-сферу не можливо пронести через стандартні двері!");
               

        }

        public void ParallelepipedIntoRectangularDoor(Parallelepiped parallelepiped)
        {
            if ((parallelepiped.WidthParallelepiped < heightRectangularDoor && parallelepiped.HeightParallelepiped < widthRectangularDoor) ||
                (parallelepiped.WidthParallelepiped < widthRectangularDoor && parallelepiped.HeightParallelepiped < heightRectangularDoor) ||
                (parallelepiped.WidthParallelepiped < heightRectangularDoor && parallelepiped.LengthParallelepiped < widthRectangularDoor) ||
                (parallelepiped.WidthParallelepiped < widthRectangularDoor && parallelepiped.LengthParallelepiped < heightRectangularDoor) ||
                (parallelepiped.LengthParallelepiped < heightRectangularDoor && parallelepiped.HeightParallelepiped < widthRectangularDoor) ||
                (parallelepiped.LengthParallelepiped < widthRectangularDoor && parallelepiped.HeightParallelepiped < heightRectangularDoor))
            {
                Console.WriteLine("Ура!Ваш стандартний холодильник  можливо пронести через стандартні двері!");
            }
            else
                Console.WriteLine("Ваш холодильник не можливо пронести через стандартні двері!");
        }

        public void CylinderIntoRectangularDoor(Cylinder cylinder)
        {
            if ((cylinder.DiameterCylinder < heightRectangularDoor && cylinder.DiameterCylinder < widthRectangularDoor) ||
                (cylinder.DiameterCylinder < heightRectangularDoor && cylinder.HeightCylinder < widthRectangularDoor) ||
            (cylinder.DiameterCylinder < widthRectangularDoor && cylinder.HeightCylinder < heightRectangularDoor))
            {
                Console.WriteLine("Ура!Ваш циліндричний холодильник проходить через стандартні двері!");
            }
            else
                Console.WriteLine("Ваш циліндричний холодильник не проходить через стандартні двері!");


        }
    }

    }
      

    

