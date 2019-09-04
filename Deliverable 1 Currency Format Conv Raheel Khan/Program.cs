using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_1_Currency_Format_Conv_Raheel_Khan
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double average, sum, min, max;
            int[] nums;
            nums = new int[3];
            char doAgain;
            bool repeat1 = true;

            while (repeat1 == true)
            {               
                Console.WriteLine("Type in Dollar amount one");
                nums[0] = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Type in Dollar amount two");
                nums[1] = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Type in Dollar amount three");
                nums[2] = Convert.ToInt16(Console.ReadLine());

                
                sum = nums.Sum();
                average = nums.Average();
                min = nums.Min();
                max = nums.Max();

                Console.WriteLine("Total Amount:" + sum);
                Console.WriteLine("Average Amount:" + average);
                Console.WriteLine("Smallest Amount:" + min);
                Console.WriteLine("Largest Amount:" + max);
                Console.WriteLine("Total US:" + sum.ToString("C"));
                Console.WriteLine("Total Swedish:" + sum.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));
                Console.WriteLine("Total Japanese:" + sum.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"))); 
                Console.WriteLine("Total Thai:" + sum.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));

                Console.WriteLine("Would you like to run this program a second time? (Y or N)");
                doAgain = Convert.ToChar(Console.ReadLine());
                if (doAgain == 'y' || doAgain == 'Y')
                    {
                        repeat1 = true;
                    }

                else
                    {
                        repeat1 = false;
                    }


                
    }
        }
    }
}
