using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangular_Door;
using Round_Door;
using Sphere_ns;
using Parallelepiped_ns;
using Cylinder_ns;


namespace myprog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            int choiceContinue = 0;

            do
            {
                int choiceRefrigerator = 0;

                int choiceDoor = 0;

                bool correctRefrigerator = false;

                bool correctDoor = false;



                Console.WriteLine("Привіт)Розкажи нам про свій холодильник та двері.Почнемо з типу твого холодильника.");

                while (!correctRefrigerator)
                {
                    try
                    {
                        Console.WriteLine("\nВиберіть із списку тип вашого холодильника:");
                        Console.WriteLine("1-Стандартний холодильник\n2-Холодильник-сфера\n3-Холодильник-циліндр\nВаш вибір:");

                        choiceRefrigerator = Convert.ToInt32(Console.ReadLine());
                        if (choiceRefrigerator != 1 && choiceRefrigerator != 2 && choiceRefrigerator != 3)
                        {
                            Console.WriteLine("Існує тільки три варіанти(1,2,3)!Введіть один з цих варіантів!");
                            continue;

                        }
                        correctRefrigerator = true;

                    }
                    catch (FormatException)
                    {
                        correctRefrigerator = false;
                        Console.WriteLine("Ви ввели не коректні дані.Спробуйте ще раз)\n");
                    }
                }

                Console.WriteLine("Окей)\nА які у вас двері?Виберіть один з варіантів:");

                while (!correctDoor)
                {
                    try
                    {
                        Console.WriteLine("1-Стандартні прямокутні двері\n2-Круглі двері\nВаш варіант:");

                        choiceDoor = Convert.ToInt32(Console.ReadLine());
                        if (choiceDoor != 1 && choiceDoor != 2)
                        {
                            Console.WriteLine("Існує тільки два варіанти(1,2)!Введіть один з цих варіантів!");
                            continue;

                        }

                        correctDoor = true;
                    }
                    catch (FormatException)
                    {
                        correctDoor = false;
                        Console.WriteLine("Ви ввели не коректні дані.Спробуйте ще раз)\n");


                    }

                }

                switch (choiceDoor)
                {
                    case 1:
                        RectangularDoor rectangleDoor = new RectangularDoor();
                        rectangleDoor.setRectangularDoor();

                        switch (choiceRefrigerator)
                        {
                            case 1:
                                Parallelepiped parallelepiped = new Parallelepiped();
                                parallelepiped.setParallelepiped();
                                rectangleDoor.ParallelepipedIntoRectangularDoor(parallelepiped);
                                break;
                            case 2:
                                Sphere sphere = new Sphere();
                                sphere.setSphere();
                                rectangleDoor.SphereIntoRectangularDoor(sphere);
                                break;
                            case 3:
                                Cylinder cylinder = new Cylinder();
                                cylinder.setCylinder();
                                rectangleDoor.CylinderIntoRectangularDoor(cylinder);
                                break;

                        }
                        break;
                    case 2:
                        RoundDoor roundDoor = new RoundDoor();
                        roundDoor.setRoundDoor();

                        switch (choiceRefrigerator)
                        {
                            case 1:
                                Parallelepiped parallelepiped = new Parallelepiped();
                                parallelepiped.setParallelepiped();
                                roundDoor.ParallelepipedIntoRoundDoor(parallelepiped);
                                break;
                            case 2:
                                Sphere sphere = new Sphere();
                                sphere.setSphere();
                                roundDoor.SphereIntoRoundDoor(sphere);
                                break;
                            case 3:
                                Cylinder cylinder = new Cylinder();
                                cylinder.setCylinder();
                                roundDoor.CylinderIntoRoundDoor(cylinder);
                                break;
                        }
                        break;


                }

                Console.WriteLine("Бажаєте продовжити перевірку для інших типів?\n1-Так,хочу продовжити.\n2-Ні,дякую.");
                choiceContinue = Convert.ToInt32(Console.ReadLine());
            }
            while (choiceContinue != 2);



            Console.ReadKey();
        }
    }
}
        
    
    
