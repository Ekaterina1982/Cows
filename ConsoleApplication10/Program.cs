using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (CowConter (45));
            Console.ReadLine();
        }

        public static string CowConter(int n)
        {
            int lastDigit = n % 10;
            int lastDigit2 = n % 100;
            string result=string.Empty;

            if ((lastDigit2 >= 11) & (lastDigit2 <= 19))
                result = "коров";
            else
                if (lastDigit == 1) 
                                    result = "корова";
                else 
                    if (lastDigit >= 2 && lastDigit <= 4)
                                                          result = "коровы";
                    else
                        if ((lastDigit >= 5 && lastDigit <= 9) || (lastDigit == 0))
                                                                                   result = "коров";
                        
              return string.Format("{0} {1}", n, result);

        }

    }


}
