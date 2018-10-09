using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusRoomDetail
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesNo = true;
            
            while (yesNo == true)
            {
                
                double width, length, area, perimeter;
                string widthString, lengthString;
                Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator");

               
                Console.Write("Enter Length: ");
                lengthString = Console.ReadLine();
                length = double.Parse(lengthString);
                Console.Write("Enter Width: ");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);

                area = (length * width);
                perimeter = ((length * 2) + (width * 2));
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.Write("Do you want to continue? Yes or No: ");
                var entry = Console.ReadLine();
                if (entry.ToLower() == "no")
                {
                    yesNo = false;
                }


            }


            
        }
    }
}
