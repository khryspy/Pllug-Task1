using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped_ns
{
    class Parallelepiped
    {
        double heightParallelepiped;

        double widthParallelepiped;

        double lengthParallelepiped;

        public double HeightParallelepiped
        {
            get { return heightParallelepiped; }
            set { heightParallelepiped = value; }
        }

        public double WidthParallelepiped
        {
            get { return widthParallelepiped; }
            set { widthParallelepiped = value; }
        }

        public double LengthParallelepiped
        {
            get { return lengthParallelepiped; }
            set { lengthParallelepiped = value; }
        }

        public void setHeightParallelepiped()
        {
            try
            {
                Console.WriteLine("Введіть висоту вашого холодильника-паралелепіпеда:");
                heightParallelepiped = Convert.ToDouble(Console.ReadLine());

                if (heightParallelepiped <= 0)
                {
                    Console.WriteLine("Висота холодильника-паралелепіпеда не може бути меншою або рівною нулю!");
                    setHeightParallelepiped();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Висота холодильника-паралелепіпеда-це додатнє число!Введіть,будь ласка,правильні дані!");
                setHeightParallelepiped();
            }
        }

        public void setWidthParallelepiped()
        {
            try
            {
                Console.WriteLine("Введіть ширину вашого холодильника-паралелепіпеда:");
                widthParallelepiped = Convert.ToDouble(Console.ReadLine());
                if (widthParallelepiped<= 0)
                {
                    Console.WriteLine("Ширина холодильника-паралелепіпеда не може бути меншою або рівною нулю!");
                    setWidthParallelepiped();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ширина холодильника-паралелепіпеда-це додатнє число!Введіть,будь ласка,правильні дані!");
                setWidthParallelepiped();
            }
        }

        public void setLengthParallelepiped()
        {
            try
            {
                Console.WriteLine("Введіть довжину вашого холодильника-паралелепіпеда:");
                lengthParallelepiped = Convert.ToDouble(Console.ReadLine());
                if (lengthParallelepiped <= 0)
                {
                    Console.WriteLine("Довжина холодильника-паралелепіпеда не може бути меншою або рівною нулю!");
                    setHeightParallelepiped();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Довжина холодильника-паралелепіпеда-це додатнє число!Введіть,будь ласка,правильні дані!");
                setLengthParallelepiped();
            }
        }

        public void setParallelepiped()
        {
            setHeightParallelepiped();
            setLengthParallelepiped();
            setWidthParallelepiped();
        }

    }
}
