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

                Console.Write("Please enter the width of the room: ");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);
                Console.Write("Please enter the length of the room: ");
                lengthString = Console.ReadLine();
                length = double.Parse(lengthString);

                area = (length * width);
                perimeter = ((length * 2) + (width * 2));
                Console.WriteLine("The Area of the Room is: " + area);
                Console.WriteLine("The perimeter of the room is: " + perimeter);
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
